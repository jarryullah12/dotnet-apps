Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'validation check
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Your Username and Password first....!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim db As New SMSDataContext
        Dim CheckUser = From p In db.Users Where p.Username = txtUsername.Text And p.Password = txtPassword.Text Select p

        If CheckUser.Count = 0 Then
            MsgBox("Invalid username & Password....!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

            Exit Sub
        Else
            frmLoading.Show()
            Me.Close()

        End If



        

    End Sub
End Class
