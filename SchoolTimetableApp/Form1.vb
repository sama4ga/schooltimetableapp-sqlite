Public Class frmMain

#Region "Manage Subjects"
    Private Sub lblManageSubjects_MouseHover(sender As Object, e As EventArgs) Handles lblManageSubjects.MouseHover
        lblManageSubjects.Image = My.Resources.lblHover
    End Sub

    Private Sub lblManageSubjects_MouseLeave(sender As Object, e As EventArgs) Handles lblManageSubjects.MouseLeave
        lblManageSubjects.Image = My.Resources.edit_record
    End Sub

    Private Sub lblManageSubjects_Click(sender As Object, e As EventArgs) Handles lblManageSubjects.Click
        frmManageSubjects.Show()
        Close()
    End Sub

#End Region

#Region "Manage Teacher"
    Private Sub lblManageTeacher_MouseHover(sender As Object, e As EventArgs) Handles lblManageTeacher.MouseHover
        lblManageTeacher.Image = My.Resources.lblHover
    End Sub

    Private Sub lblManageTeacher_MouseLeave(sender As Object, e As EventArgs) Handles lblManageTeacher.MouseLeave
        lblManageTeacher.Image = My.Resources.employer
    End Sub

    Private Sub lblManageTeacher_Click(sender As Object, e As EventArgs) Handles lblManageTeacher.Click
        frmManageTeachers.Show()
        Close()
    End Sub

#End Region


#Region "Generate Timetable"
    Private Sub lblGenerateTimetable_MouseHover(sender As Object, e As EventArgs) Handles lblGenerateTimetable.MouseHover
        lblGenerateTimetable.Image = My.Resources.lblHover
    End Sub

    Private Sub lblGenerateTimetable_MouseLeave(sender As Object, e As EventArgs) Handles lblGenerateTimetable.MouseLeave
        lblGenerateTimetable.Image = My.Resources.calendar
    End Sub

    Private Sub lblGenerateTimetable_Click(sender As Object, e As EventArgs) Handles lblGenerateTimetable.Click
        frmGenerateTimeTable.Show()
        Close()
    End Sub
#End Region


#Region "View Timetable"
    Private Sub lblViewTimetable_MouseHover(sender As Object, e As EventArgs) Handles lblViewTimetable.MouseHover
        lblViewTimetable.Image = My.Resources.lblHover
    End Sub

    Private Sub lblViewTimetable_MouseLeave(sender As Object, e As EventArgs) Handles lblViewTimetable.MouseLeave
        lblViewTimetable.Image = My.Resources.reports
    End Sub

    Private Sub lblViewTimetable_Click(sender As Object, e As EventArgs) Handles lblViewTimetable.Click
        frmViewTimeTable.Show()
        Close()
    End Sub

#End Region


#Region "Adjust Timetable"
    Private Sub lblAdjustTimetable_MouseHover(sender As Object, e As EventArgs) Handles lblAdjustTimetable.MouseHover
        lblAdjustTimetable.Image = My.Resources.lblHover
    End Sub

    Private Sub lblAdjustTimetable_MouseLeave(sender As Object, e As EventArgs) Handles lblAdjustTimetable.MouseLeave
        lblAdjustTimetable.Image = My.Resources.maintenance
    End Sub

    Private Sub lblAdjustTimetable_Click(sender As Object, e As EventArgs) Handles lblAdjustTimetable.Click
        frmAdjustTimetable.Show()
        Close()
    End Sub


#End Region

#Region "Miscellaneous details"
    Private Sub lblMisc_MouseHover(sender As Object, e As EventArgs) Handles lblMisc.MouseHover
        lblMisc.Image = My.Resources.lblHover
    End Sub

    Private Sub lblMisc_MouseLeave(sender As Object, e As EventArgs) Handles lblMisc.MouseLeave
        lblMisc.Image = My.Resources.rose
    End Sub

    Private Sub lblMisc_Click(sender As Object, e As EventArgs) Handles lblMisc.Click
        frmMisc.Show()
        Close()
    End Sub


#End Region

End Class
