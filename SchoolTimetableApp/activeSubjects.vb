Public Class activeSubjects
    Inherits List(Of subject)

    'Public Sub New()

    'End Sub

    ''' <summary>
    ''' Searches for a subject in the list of active subjects
    ''' </summary>
    ''' <param name="subj">Subject to search for</param>
    ''' <returns>True if subject is found in list and False otherwise </returns>
    Public Overloads Function Contains(subj As subject) As Boolean
        For Each c_subj As subject In Me
            If subj.Name.Equals(c_subj.Name) And subj.SubjectClass.Equals(c_subj.SubjectClass) And subj.Teacher.Equals(c_subj.Teacher) Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Clears active state of subject
    ''' </summary>
    Public Sub ClearList()
        For Each c_subj As subject In Me
            c_subj.ActiveStatus = False
        Next
    End Sub

    ''' <summary>
    ''' Clears active state of teacher
    ''' </summary>
    Public Sub ClearTeacher()
        For Each c_subj As subject In Me
            c_subj.Teacher.Active = False
        Next
    End Sub

    ''' <summary>
    ''' Clears workload of the teacher
    ''' </summary>
    Public Sub ClearTeacherWorkLoad()
        For Each c_subj As subject In Me
            c_subj.Teacher.WorkLoad = 0
        Next
    End Sub
End Class
