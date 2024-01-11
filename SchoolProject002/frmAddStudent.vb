Public Class frmAddStudent

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtregno.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        cmbAge.Value = 0
        cmbClass.Text = ""
        txtFullName.Text = ""
        cmbStream.Text = ""
        PictureBox1.Image = Nothing
        txtFullName.Text = ""

        cmbGender.Text = ""
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click

        With OpenFileDialog1
            .Title = "Select Student Photo"
            .Filter = "Jpeg Images only|*.jpg"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)

            End If
        End With

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' validation

        If txtregno.Text = "" Or txtFullName.Text = "" Or cmbGender.Text = "" Or cmbClass.Text = "" Or cmbStream.Text = "" Then
            MsgBox("Plz enter all required fields", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If


        'check duplicate record
        Dim db As New SMSDataContext
        Dim CheckStudentDetails = From p In db.Students
                                 Where p.RegistrationNumber = txtregno.Text
                                 Select p
        If CheckStudentDetails.Count <> 0 Then
            MsgBox("A Student is already registred with the same registration Number", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

            Exit Sub
        End If
        'insert record
        Dim NewStudent As New Student With {.Address = txtAddress.Text, .Age = cmbAge.Value, .Class = cmbClass.Text, .PhoneNumber = txtPhone.Text, .Email = txtEmail.Text, .FullName = txtFullName.Text, .Gender = cmbGender.Text, .Picture = PictureBox1.ImageLocation, .RegistrationNumber = txtregno.Text, .Stream = cmbStream.Text}

        db.Students.InsertOnSubmit(NewStudent)
        db.SubmitChanges()
        MsgBox("Student Record Saved Successfully !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        btnClear_Click(sender, e)

    End Sub

    Private Sub btnClearPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPhoto.Click
        PictureBox1.Image = Nothing
    End Sub
End Class