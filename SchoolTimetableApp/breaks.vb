Public Class break
    Private start_time As String
    Private end_time As String
    Private day_break As String
    Private details As String

    ''' <summary>
    ''' Creates new break period
    ''' </summary>
    ''' <param name="name">Name of break</param>
    ''' <param name="start_time">Time break period starts</param>
    ''' <param name="end_time">Time break period ends</param>
    ''' <param name="day">Day(s) break holds</param>
    Public Sub New(name, start_time, end_time, day)
        details = name
        Me.start_time = start_time
        Me.end_time = end_time
        day_break = day
    End Sub

    Public Property StartTime As String
        Get
            Return start_time
        End Get
        Set(value As String)
            start_time = value
        End Set
    End Property

    Public Property EndTime As String
        Get
            Return end_time
        End Get
        Set(value As String)
            end_time = value
        End Set
    End Property

    Public Property Day As String
        Get
            Return day_break
        End Get
        Set(value As String)
            day_break = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return details
        End Get
        Set(value As String)
            details = value
        End Set
    End Property

End Class
