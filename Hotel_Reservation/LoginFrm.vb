Imports System.Data.SqlClient

Public Class LoginFrm

    Sub configuration()
        Label3.Parent = PictureBox2
        Label3.BackColor = Color.Transparent
        TextBox2.UseSystemPasswordChar = True
    End Sub
    Sub check_fields()
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Input username field", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Input password field", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TextBox1.Text = Nothing And TextBox2.Text Is Nothing Then
            MessageBox.Show("Please enter your account", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            login_process()
        End If
    End Sub
    Sub login_process()
        cm = New SqlCommand("SELECT username,password FROM accounts WHERE username = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "' ", connect)
        dr = cm.ExecuteReader


        'check if the account is exist
        If dr.Read Then
            MessageBox.Show("Welcome Administrator", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainFrm.Show()
            Me.Hide()
        Else
            MessageBox.Show("data is not in database")
        End If

    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        check_fields()
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configuration()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        close_system()
    End Sub
End Class
