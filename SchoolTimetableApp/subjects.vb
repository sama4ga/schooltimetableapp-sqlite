Public Class subject
    Private sub_name As String
    Private sub_class As String
    Private time_per_period As Integer
    Private no_times_per_week As Integer
    Private no_of_double_periods As Integer
    Private sub_category As String
    Private sub_teacher As teacher
    Private active_status As Boolean
    Private last_added As Integer

    ''' <summary>
    ''' Holds the class of this subject
    ''' </summary>
    ''' <returns></returns>
    Public Property SubjectClass As String
        Get
            Return sub_class
        End Get
        Set(value As String)
            sub_class = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the number of double periods for this subject
    ''' </summary>
    ''' <returns></returns>
    Public Property NoOfDoublePeriod As Integer
        Get
            Return no_of_double_periods
        End Get
        Set(value As Integer)
            no_of_double_periods = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the name of the subject
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String
        Get
            Return sub_name
        End Get
        Set(value As String)
            sub_name = value
        End Set
    End Property

    ''' <summary>
    ''' Used to hold reference to a new subject added
    ''' </summary>
    ''' <param name="name">Holds the name of the subject</param>
    ''' <param name="time_per_period">Holds the time allotted to the subject per class period</param>
    ''' <param name="no_times_per_week">Holds the number of times the subject is to be taken per week</param>
    ''' <param name="sub_class">Holds the class this subject belongs to</param>
    ''' <param name="no_of_double_periods">Holds the number of double periods periods for this subject</param>
    ''' <param name="category">Defines the category of this subject</param>
    Public Sub New(name As String, time_per_period As Integer, no_times_per_week As Integer, sub_class As String, no_of_double_periods As Integer, category As String)
        Me.sub_name = name
        Me.time_per_period = time_per_period
        Me.no_times_per_week = no_times_per_week
        Me.sub_class = sub_class
        Me.no_of_double_periods = no_of_double_periods
        Me.sub_category = category
        last_added = -1
    End Sub

    ''' <summary>
    ''' Holds the number (in  minutes) of times the subject is to be taken a week
    ''' </summary>
    ''' <returns></returns>
    Public Property NoOfTimesPerWeek As Integer
        Get
            Return no_times_per_week
        End Get
        Set(value As Integer)
            no_times_per_week = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the time (in minutes) alloted the subject per subject period
    ''' </summary>
    ''' <returns></returns>
    Public Property TimePerPeriod As Integer
        Get
            Return time_per_period
        End Get
        Set(value As Integer)
            time_per_period = value
        End Set
    End Property

    ''' <summary>
    ''' Holds details of the teacher handling the subject
    ''' </summary>
    ''' <returns></returns>
    Public Property Teacher As teacher
        Get
            Return sub_teacher
        End Get
        Set(value As teacher)
            sub_teacher = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the category of the subject
    ''' </summary>
    ''' <returns>General, Commercial, Art or Science</returns>
    Public Property Category As String
        Get
            Return sub_category
        End Get
        Set(value As String)
            sub_category = value
        End Set
    End Property

    ''' <summary>
    ''' Holds the status of the subject
    ''' </summary>
    ''' <returns>True if subject is active or False otherwise</returns>
    Public Property ActiveStatus As Boolean
        Get
            Return active_status
        End Get
        Set(value As Boolean)
            active_status = value
        End Set
    End Property


    ''' <summary>
    ''' Holds the last day subject was added
    ''' </summary>
    ''' <returns></returns>
    Public Property LastAdded As Integer
        Get
            Return last_added
        End Get
        Set(value As Integer)
            last_added = value
        End Set
    End Property


    'Public Overrides Function Equals(subject As subject) As Boolean
    '    If subject.Name.Equals(Me.sub_name) And subject.SubjectClass.Equals(Me.sub_class) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Public Overrides Function Contains(subject As subject)

    'End Function

End Class
