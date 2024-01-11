Public Class frmPrintResults

    Private Sub frmPrintResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnPrintResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintResult.Click
        If cmbClass.Text = "" Or cmbStream.Text = "" Or cmbSubject.Text = "" Then
            MsgBox("Select all Options to Proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Me.AssessmentsTableAdapter.FillByClassStreamSubject(Me.SMS.Assessments, cmbClass.Text, cmbStream.Text, cmbSubject.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class