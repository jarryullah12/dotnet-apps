Public Class frmEnterExams
    Dim RecordPosition As Integer
    Private Sub frmEnterExams_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS.Assessments' table. You can move, or remove it, as needed.
        Me.AssessmentsTableAdapter.Fill(Me.SMS.Assessments)

    End Sub

    Private Sub btnLoadRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRecord.Click
        If cmbClass.Text = "" Or cmbStream.Text = "" Or cmbSubject.Text = "" Then
            MsgBox("Enter all fields record", MsgBoxStyle.Critical)
            Exit Sub

        End If



        Dim db As New SMSDataContext
        Dim AssessmentRecords = From p In db.Assessments
                              Where p.Class = cmbClass.Text And p.Stream = cmbStream.Text And p.Subject = cmbSubject.Text
                              Select p

        If AssessmentRecords.Count <> 0 Then
            Me.AssessmentsTableAdapter.FillByClass(Me.SMS.Assessments, cmbClass.Text, cmbStream.Text, cmbSubject.Text)


        Else
            Dim StudentRecords = From p In db.Students
                                Where p.Class = cmbClass.Text And p.Stream = cmbStream.Text
                                Select p

            If StudentRecords.Count = 0 Then
                MsgBox("No Students records in the system that match your criteria!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                For j = 1 To StudentRecords.Count
                    Dim NewAssessmentRecord As New Assessment With {.CA = 0, .Class = cmbClass.Text, .Exams = 0, .FullName = StudentRecords.ToList(j - 1).FullName, .RegistrationNumber = StudentRecords.ToList(j - 1).RegistrationNumber, .Stream = cmbStream.Text, .Subject = cmbSubject.Text}

                    db.Assessments.InsertOnSubmit(NewAssessmentRecord)
                    db.SubmitChanges()

                Next
                Me.AssessmentsTableAdapter.FillByClass(Me.SMS.Assessments, cmbClass.Text, cmbStream.Text, cmbSubject.Text)
                lblCurrentStudent.Text = AssessmentRecords.FirstOrDefault.FullName
                RecordPosition = 0
                txtScore.Focus()

            End If

        End If
    End Sub

    Private Sub btnEnterExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterExam.Click
        If txtScore.Text = "" Then
            MsgBox("Exam score cannot be empty", MsgBoxStyle.Exclamation)
            Exit Sub

        End If

        If Not IsNumeric(txtScore.Text) Then
            MsgBox("Score must be numeric", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If Val(txtScore.Text) < 40 Then
            MsgBox("Exam Score cannot be above 60 Marks", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        Dim db As New SMSDataContext
        Dim AssessmentRecord = From p In db.Assessments
                             Where p.Class = cmbClass.Text And p.Stream = cmbStream.Text And p.Subject = cmbSubject.Text
                             Select p

        If RecordPosition < (AssessmentRecord.Count - 1) Then
            MsgBox("End of Records Reached", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        AssessmentRecord.ToList(RecordPosition).Exams = Val(txtScore.Text)
        db.SubmitChanges()
        RecordPosition += 1
        If RecordPosition = (AssessmentRecord.Count - 1) Then
            MsgBox("End of Record Reached !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        txtScore.Clear()
        txtScore.Focus()
    End Sub
End Class