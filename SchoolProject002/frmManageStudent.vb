Public Class frmManageStudent

    Private Sub frmManageStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.SMS.Students)

    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If txtSearch.Text = "" Then
            frmManageStudent_Load(sender, e)
        Else
            Me.StudentsTableAdapter.FillByFullname(Me.SMS.Students, txtSearch.Text & "%")
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmAddStudent.ShowDialog()
        frmManageStudent_Load(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        frmManageStudent_Load(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try
            Dim db As New SMSDataContext
            Dim SelectedStudent = From p In db.Students
                                 Where p.ID = Val(DataGridView1.CurrentRow.Cells(0).Value)
                                 Select p

            db.Students.DeleteOnSubmit(SelectedStudent.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Student record successfully Deleted !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            frmManageStudent_Load(sender, e)
        Catch ex As Exception
            MsgBox("Please Select a Student Record from the List First...!", MsgBoxStyle.Exclamation)

        End Try
    End Sub
End Class