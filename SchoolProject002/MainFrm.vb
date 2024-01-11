Public Class MainFrm

    Private Sub AddNewStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        frmAddStudent.ShowDialog()

    End Sub

    Private Sub ManageStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageStudentToolStripMenuItem.Click
        frmManageStudent.ShowDialog()

    End Sub

    Private Sub AddStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffToolStripMenuItem.Click
        frmAddTeacher.ShowDialog()

    End Sub

    Private Sub ManageStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageStaffToolStripMenuItem.Click
        frmManageTeacher.ShowDialog()

    End Sub

    Private Sub EnterCAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterCAToolStripMenuItem.Click
        frmEnterCA.ShowDialog()

    End Sub

    Private Sub EnterExamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterExamToolStripMenuItem.Click
        frmEnterExams.ShowDialog()

    End Sub

    Private Sub ADDManageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDManageToolStripMenuItem.Click
        frmManageUsers.ShowDialog()

    End Sub

    Private Sub ComputeResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputeResultsToolStripMenuItem.Click
        frmComputeResult.ShowDialog()

    End Sub

    Private Sub PrintResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintResultToolStripMenuItem.Click
        frmPrintResults.ShowDialog()

    End Sub
End Class