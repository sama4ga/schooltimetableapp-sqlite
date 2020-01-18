Public Class teachers_avialable_time
    Private from_time As Integer
    Private to_time As Integer
    Private day_available As String

    ''' <summary>
    ''' Adds a new record of teacher availability
    ''' </summary>
    ''' <param name="start_time">Start time when teacher is free</param>
    ''' <param name="end_time">Time when teacher is no longer free</param>
    ''' <param name="day">Day when teacher is free and available to teach</param>
    Public Sub New(start_time As Integer, end_time As Integer, day As String)
        from_time = start_time
        to_time = end_time
        day_available = day
    End Sub

    Public Property StartTime As Integer
        Get
            Return from_time
        End Get
        Set(value As Integer)
            from_time = value
        End Set
    End Property

    Public Property EndTime As Integer
        Get
            Return to_time
        End Get
        Set(value As Integer)
            to_time = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the day teacher is available
    ''' </summary>
    ''' <returns>day teacher is available (String)</returns>
    Public Property Day As String
        Get
            Return day_available
        End Get
        Set(value As String)
            day_available = value
        End Set
    End Property

End Class
