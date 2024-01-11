Public Class frmComputeResult

    

    Private Sub btnLoadResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadResult.Click
        If cmbClass.Text = "" Or cmbStream.Text = "" Or cmbSubject.Text = "" Then
            MsgBox("Enter all fields record", MsgBoxStyle.Critical)
            Exit Sub

        End If

        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                              Where p.Class = cmbClass.Text And p.Stream = cmbStream.Text
                              Select p

        If AssessmentRecords.Count = 0 Then
            MsgBox("No Record Found...!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        For j = 1 To AssessmentRecords.Count
            AssessmentRecords.ToList(j - 1).Exams = Val(AssessmentRecords.ToList(j - 1).CA) + Val(AssessmentRecords.ToList(j - 1).Exams)
            If Val(AssessmentRecords.ToList(j - 1).Exams) >= 70 Then
                AssessmentRecords.ToList(j - 1).Grade = "A"
                AssessmentRecords.ToList(j - 1).Remarks = "Excellent"

            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 60 Then
                AssessmentRecords.ToList(j - 1).Grade = "B"
                AssessmentRecords.ToList(j - 1).Remarks = "Very Good"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 50 Then
                AssessmentRecords.ToList(j - 1).Grade = "C"
                AssessmentRecords.ToList(j - 1).Remarks = "Good"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 40 Then
                AssessmentRecords.ToList(j - 1).Grade = "D"
                AssessmentRecords.ToList(j - 1).Remarks = "Fair"
            ElseIf Val(AssessmentRecords.ToList(j - 1).Exams) >= 35 Then
                AssessmentRecords.ToList(j - 1).Grade = "E"
                AssessmentRecords.ToList(j - 1).Remarks = "Poor"
            Else
                AssessmentRecords.ToList(j - 1).Grade = "F"
                AssessmentRecords.ToList(j - 1).Remarks = "Failed"
            End If
        Next
        db.SubmitChanges()
        Dim TotaledRecords = From p In db.Assessments
                            Where p.Class = cmbClass.Text And p.Stream = cmbStream.Text
                            Select p
                            Order By p.Total Descending

        For j = 1 To TotaledRecords.Count
            TotaledRecords.ToList(j - 1).Position = j
        Next
        db.SubmitChanges()
        Me.AssessmentsTableAdapter.FillByClassStream(Me.SMS.Assessments, cmbClass.Text, cmbStream.Text)

    End Sub
End Class