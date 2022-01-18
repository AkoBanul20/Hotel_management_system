Imports System.Data.SqlClient

Public Class AddRoomFrm

    Sub clear_input()
        room_type_box.Text = ""
        roomno_text.Clear()
        description_text.Clear()
        price_text.Clear()
        max_person_text.Clear()
    End Sub

    Sub save_room()
        Dim insert_query_string As String = "INSERT INTO  rooms VALUES ('" & roomno_text.Text & "', '" & room_type_box.Text & "', '" & description_text.Text & "', '" & price_text.Text & "', '" & max_person_text.Text & "');"
        cm = New SqlCommand(insert_query_string, connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear_input()
        Me.Dispose()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Dispose()
    End Sub
    Private Sub save_room_btn_Click(sender As Object, e As EventArgs) Handles save_room_btn.Click
        If MessageBox.Show("Save this record? Click yes to confirm", "notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            save_room()
        End If
    End Sub
End Class