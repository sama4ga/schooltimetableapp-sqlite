<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblManageSubjects = New System.Windows.Forms.Label()
        Me.lblAdjustTimetable = New System.Windows.Forms.Label()
        Me.lblGenerateTimetable = New System.Windows.Forms.Label()
        Me.lblManageTeacher = New System.Windows.Forms.Label()
        Me.lblViewTimetable = New System.Windows.Forms.Label()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblManageSubjects
        '
        Me.lblManageSubjects.BackColor = System.Drawing.Color.White
        Me.lblManageSubjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblManageSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblManageSubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblManageSubjects.Image = Global.SchoolTimetableApp.My.Resources.Resources.edit_record
        Me.lblManageSubjects.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblManageSubjects.Location = New System.Drawing.Point(143, 71)
        Me.lblManageSubjects.Name = "lblManageSubjects"
        Me.lblManageSubjects.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblManageSubjects.Size = New System.Drawing.Size(261, 268)
        Me.lblManageSubjects.TabIndex = 0
        Me.lblManageSubjects.Text = "Manage Subjects"
        Me.lblManageSubjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAdjustTimetable
        '
        Me.lblAdjustTimetable.BackColor = System.Drawing.Color.White
        Me.lblAdjustTimetable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdjustTimetable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdjustTimetable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAdjustTimetable.Image = Global.SchoolTimetableApp.My.Resources.Resources.maintenance
        Me.lblAdjustTimetable.Location = New System.Drawing.Point(863, 388)
        Me.lblAdjustTimetable.Name = "lblAdjustTimetable"
        Me.lblAdjustTimetable.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblAdjustTimetable.Size = New System.Drawing.Size(261, 268)
        Me.lblAdjustTimetable.TabIndex = 1
        Me.lblAdjustTimetable.Text = "Manually Adjust Timetable"
        Me.lblAdjustTimetable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblGenerateTimetable
        '
        Me.lblGenerateTimetable.BackColor = System.Drawing.Color.White
        Me.lblGenerateTimetable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenerateTimetable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGenerateTimetable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGenerateTimetable.Image = Global.SchoolTimetableApp.My.Resources.Resources.calendar
        Me.lblGenerateTimetable.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblGenerateTimetable.Location = New System.Drawing.Point(863, 71)
        Me.lblGenerateTimetable.Name = "lblGenerateTimetable"
        Me.lblGenerateTimetable.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblGenerateTimetable.Size = New System.Drawing.Size(261, 268)
        Me.lblGenerateTimetable.TabIndex = 2
        Me.lblGenerateTimetable.Text = "Generate Timetable"
        Me.lblGenerateTimetable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblManageTeacher
        '
        Me.lblManageTeacher.BackColor = System.Drawing.Color.White
        Me.lblManageTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblManageTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblManageTeacher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblManageTeacher.Image = Global.SchoolTimetableApp.My.Resources.Resources.employer
        Me.lblManageTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblManageTeacher.Location = New System.Drawing.Point(516, 71)
        Me.lblManageTeacher.Name = "lblManageTeacher"
        Me.lblManageTeacher.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblManageTeacher.Size = New System.Drawing.Size(261, 268)
        Me.lblManageTeacher.TabIndex = 3
        Me.lblManageTeacher.Text = "Manage Teachers"
        Me.lblManageTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblViewTimetable
        '
        Me.lblViewTimetable.BackColor = System.Drawing.Color.White
        Me.lblViewTimetable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblViewTimetable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblViewTimetable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblViewTimetable.Image = Global.SchoolTimetableApp.My.Resources.Resources.reports
        Me.lblViewTimetable.Location = New System.Drawing.Point(516, 388)
        Me.lblViewTimetable.Name = "lblViewTimetable"
        Me.lblViewTimetable.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblViewTimetable.Size = New System.Drawing.Size(261, 268)
        Me.lblViewTimetable.TabIndex = 4
        Me.lblViewTimetable.Text = "View Timetable"
        Me.lblViewTimetable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblMisc
        '
        Me.lblMisc.BackColor = System.Drawing.Color.White
        Me.lblMisc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMisc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMisc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMisc.Image = Global.SchoolTimetableApp.My.Resources.Resources.rose
        Me.lblMisc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMisc.Location = New System.Drawing.Point(143, 388)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblMisc.Size = New System.Drawing.Size(261, 268)
        Me.lblMisc.TabIndex = 5
        Me.lblMisc.Text = "Miscellaneous Details"
        Me.lblMisc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lblMisc)
        Me.Controls.Add(Me.lblViewTimetable)
        Me.Controls.Add(Me.lblManageTeacher)
        Me.Controls.Add(Me.lblGenerateTimetable)
        Me.Controls.Add(Me.lblAdjustTimetable)
        Me.Controls.Add(Me.lblManageSubjects)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automatic School Timetable Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblManageSubjects As Label
    Friend WithEvents lblAdjustTimetable As Label
    Friend WithEvents lblGenerateTimetable As Label
    Friend WithEvents lblManageTeacher As Label
    Friend WithEvents lblViewTimetable As Label
    Friend WithEvents lblMisc As Label
End Class
