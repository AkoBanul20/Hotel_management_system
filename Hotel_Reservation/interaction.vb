Module interaction
    Sub close_system()
        Dim ask As String = MessageBox.Show("Do you want to exit application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("System Terminated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
End Module
