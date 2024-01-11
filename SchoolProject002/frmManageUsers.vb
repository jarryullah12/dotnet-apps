Public Class frmManageUsers

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lsbExistingUser.Text = "" Then
            MsgBox("Plz select an existing user first!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        If lsbExistingUser.Items.Count = 1 Then
            MsgBox("You cannot remove all users, one account must be left !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim db As New SMSDataContext
        Dim selectedUser = From p In db.Users
                         Where p.Username = lsbExistingUser.Text
                         Select p

        db.Users.DeleteOnSubmit(selectedUser.FirstOrDefault)
        db.SubmitChanges()
        MsgBox("Selected User successfully Removed!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        frmManageUsers_Load(sender, e)

        Exit Sub
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        If txtUsername.Text = "" Or txtPass.Text = "" Or txtRetypPass.Text = "" Or txtFullname.Text = "" Then
            MsgBox("All fields are required ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If

        If txtRetypPass.Text <> txtPass.Text Then
            MsgBox("Password not matched  try again", MsgBoxStyle.Critical + MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
            Exit Sub

        End If


        Dim db As New SMSDataContext
        Dim CheckUser = From p In db.Users
                      Where p.Username = txtUsername.Text
                      Select p

        If CheckUser.Count <> 0 Then
            MsgBox("A user with your selected username already exits", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Dim NewUserDetails As New User With {.FullName = txtFullname.Text, .Password = txtPass.Text, .Picture = imgpic.ImageLocation, .Username = txtUsername.Text}
        db.Users.InsertOnSubmit(NewUserDetails)
        db.SubmitChanges()
        MsgBox("User Details Successfully added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        txtFullname.Clear()
        txtPass.Clear()
        txtRetypPass.Clear()
        txtUsername.Clear()
        imgpic.Image = Nothing
        txtUsername.Focus()
        Exit Sub
    End Sub

    Private Sub btnUploadImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadImg.Click
        With OpenFileDialog1
            .Title = "Select Users Photo"
            .Filter = "Jpeg Images only|*.jpg"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
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

    Private Sub frmManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim db As New SMSDataContext
        Dim UsersList = From p In db.Users
                       Select p Order By p.Username Ascending

        lsbExistingUser.Items.Clear()
        If UsersList.Count <> 0 Then
            For j = 1 To UsersList.Count
                lsbExistingUser.Items.Add(UsersList.ToList(j - 1).Username)
            Next
        End If
    End Sub
End Class