Imports System.Drawing.Printing

Public Class printDgv
    Inherits PrintDocument

    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Private dgv As DataGridView
    Private fntPrintFont As Font

    Public Sub New(dgv As DataGridView)
        Me.dgv = dgv
    End Sub

    Public Property DataGridView As DataGridView
        Get
            Return dgv
        End Get
        Set(ByVal value As DataGridView)
            Me.dgv = value
        End Set
    End Property

    Public Property Font As Font
        ' Allows the user to override the default font
        Get
            Return fntPrintFont
        End Get
        Set(ByVal Value As Font)
            fntPrintFont = Value
        End Set
    End Property



    Protected Overrides Sub OnPrintPage(e As PrintPageEventArgs)

        MyBase.OnPrintPage(e)

        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow
        Dim rowsToPaint As Integer() = {0, 6, 12, 18, 24, 30}
        Dim groupRow As Boolean = False
        Dim groupRowHeight As Integer = 52
        Dim width As Integer = 90
        Dim height As Integer = 22

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = dgv.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invisible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, width, height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    FormatCell(cell, fmt, rc)

                    e.Graphics.DrawString(dgv.Columns(cell.ColumnIndex).HeaderText, dgv.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Integer
        For thisNDX = mRow To dgv.RowCount - 1
            ' no need to try to print the new row
            If dgv.Rows(thisNDX).IsNewRow Then Exit For

            row = dgv.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            ' x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells

                If cell.Visible Then

                    If cell.Value Is Nothing Then cell.Value = ""

                    If cell.Value.ToString().Contains("/" & vbNewLine) Then
                        rc = New Rectangle(x, y, width, groupRowHeight)
                        groupRow = True
                    ElseIf cell.Value.ToString().Contains("/") Then
                        cell.Value = cell.Value.ToString.Replace("/", "/" & vbNewLine)
                        rc = New Rectangle(x, y, width, groupRowHeight)            'cell.Size.Width, cell.Size.Height + 30
                        groupRow = True
                    Else
                        rc = New Rectangle(x, y, width, height)
                    End If


                    ' SAMPLE CODE: How To setup a RowPrePaint rule
                    'If rowsToPaint.Contains(mRow) Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    FormatCell(cell, fmt, rc)

                    e.Graphics.DrawString(cell.Value.ToString(), dgv.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next




            ' check for class rows
            If rowsToPaint.Contains(mRow) Then
                x = e.MarginBounds.Left
                h = 0
                rc = New Rectangle(x, y, x + row.Cells.Count * width, height)

                Using br As New SolidBrush(Color.MistyRose)
                    e.Graphics.FillRectangle(br, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)
                    fmt.Alignment = StringAlignment.Center
                    e.Graphics.DrawString(row.Cells(0).Value.ToString(), dgv.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End Using

            End If




            ' check for other cells in groupRow that are not the same height
            If groupRow Then
                x = e.MarginBounds.Left
                h = 0

                For Each cell As DataGridViewCell In row.Cells

                    If cell.Visible Then

                        If cell.Size.Height < groupRowHeight Then
                            rc = New Rectangle(x, y, width, groupRowHeight)
                            e.Graphics.FillRectangle(New SolidBrush(Color.White), rc)
                            e.Graphics.DrawRectangle(Pens.Black, rc)
                            FormatCell(cell, fmt, rc)
                            e.Graphics.DrawString(cell.Value.ToString(), dgv.Font, Brushes.Black, rc, fmt)
                        End If

                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    End If
                Next
            End If
            groupRow = False

            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub


    Protected Overrides Sub OnBeginPrint(e As Printing.PrintEventArgs)

        MyBase.OnBeginPrint(e)

        mRow = 0
        newpage = True

        ' Sets the default font
        If fntPrintFont Is Nothing Then
            fntPrintFont = New Font("Times New Roman", 12)
        End If


        DefaultPageSettings.Landscape = True
        DefaultPageSettings.Margins = New Margins(20, 20, 50, 15)
        DefaultPageSettings.PrinterSettings.PrintToFile = True
    End Sub


    Protected Overrides Sub OnEndPrint(e As PrintEventArgs)
        MyBase.OnEndPrint(e)

    End Sub

    Protected Overrides Sub OnQueryPageSettings(e As QueryPageSettingsEventArgs)
        MyBase.OnQueryPageSettings(e)

    End Sub

    Private Sub FormatCell(cell As DataGridViewCell, ByRef fmt As StringFormat, ByRef rc As Rectangle)

        Select Case dgv.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
            Case DataGridViewContentAlignment.BottomRight, DataGridViewContentAlignment.MiddleRight
                fmt.Alignment = StringAlignment.Far
                rc.Offset(-1, 0)
            Case DataGridViewContentAlignment.BottomCenter, DataGridViewContentAlignment.MiddleCenter
                fmt.Alignment = StringAlignment.Center
            Case Else
                fmt.Alignment = StringAlignment.Near
                rc.Offset(2, 0)
        End Select

    End Sub
End Class
