Public Class frmManageTeacher

    Private Sub frmManageTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.SMS.Teachers)

    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        Me.TeachersTableAdapter.FillBySearchString(Me.SMS.Teachers, txtSearch.Text & "%", txtSearch.Text)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmAddTeacher.ShowDialog()
        frmManageTeacher_Load(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmManageTeacher_Load(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim db As New SMSDataContext
            Dim SelectedTeacher = From p In db.Teachers
                                 Where p.ID = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                 Select p

            db.Teachers.DeleteOnSubmit(SelectedTeacher.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("teacher record successfully Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            frmManageTeacher_Load(sender, e)

        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical)

        End Try
    End Sub
End Class