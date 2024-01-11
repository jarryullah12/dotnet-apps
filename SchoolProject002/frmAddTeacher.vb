Public Class frmAddTeacher

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        With OpenFileDialog1
            .Title = "Select staff Photo"
            .Filter = "Jpeg Images only|*.jpg"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName = "" Then
                Exit Sub
            Else

                imgpic.Load(.FileName)

            End If
        End With
    End Sub

    Private Sub btnClearPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPhoto.Click
        imgpic.Image = Nothing

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtStaffID.Text = "" Or txtName.Text = "" Or cmbGender.Text = "" Or txtPhone.Text = "" Or cmbDesignation.Text = "" Then
            MsgBox("Plz enter all required fields", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim db As New SMSDataContext
        Dim CheckTeacher = From p In db.Teachers
                                 Where p.StaffID = txtStaffID.Text
                                 Select p

        If CheckTeacher.Count <> 0 Then
            MsgBox("A Teacher is already registred with the same registration Number", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If


        Dim NewTeacher As New Teacher With {.Address = txtAddress.Text, .Age = cmbAge.Value, .Designation = cmbDesignation.Text, .Email = txtEmail.Text, .FullName = txtName.Text, .Gender = cmbGender.Text, .PhoneNumber = txtPhone.Text, .Picture = imgpic.ImageLocation, .StaffID = txtStaffID.Text}

        db.Teachers.InsertOnSubmit(NewTeacher)
        db.SubmitChanges()
        MsgBox("Staff Details Saved Successfully...!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Me.Close()

    End Sub
End Class