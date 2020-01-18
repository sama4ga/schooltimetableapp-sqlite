Public Class memory
    Private subj As subject

    Public Sub New(subject As subject)
        subj = subject
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return subj.Name
        End Get
        'Set(value As String)
        '    subj.Name = value
        'End Set
    End Property

    Public ReadOnly Property SubjectClass As String
        Get
            Return subj.SubjectClass
        End Get
        'Set(value As String)
        '    subj.SubjectClass = value
        'End Set
    End Property

    Public ReadOnly Property Teacher As teacher
        Get
            Return subj.Teacher
        End Get
        'Set(value As teacher)
        '    subj.Teacher = value
        'End Set
    End Property


End Class
