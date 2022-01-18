Imports System.Data.SqlClient
Public Class AddReservationFrm

    Sub book_reservation()
        Dim book_reservation_query As String = "INSERT INTO reservations VALUES ('" & room_box.Text & "', '" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "', '" & customer_text.Text & "', 'pending', '" & DateTimePicker2.Value.ToString("hh:mm:ss") & "', '" & DateTimePicker3.Value.ToString("hh:mm:ss") & "')"
        cm = New SqlCommand(book_reservation_query, connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
    End Sub

    Sub load_rooms()
        Dim load_room_query As String = "SELECT * FROM rooms WHERE is_available = 1"
        cm = New SqlCommand(load_room_query, connect)
        dr = cm.ExecuteReader
        While dr.Read
            room_box.Items.Add(dr.Item("room_no"))
        End While
    End Sub


    Sub datetimepicker_format()
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Value = DateTime.Today


        DateTimePicker2.CustomFormat = "hh:mm:ss[.nnnnnnn]"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Value = DateTime.Now

        DateTimePicker3.CustomFormat = "hh:mm tt"
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Value = DateTime.Now

        'DateTimePicker2.ToString("HH:mm")
    End Sub

    Private Sub AddReservationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetimepicker_format()
        load_rooms()
    End Sub

    Private Sub save_room_btn_Click(sender As Object, e As EventArgs) Handles save_room_btn.Click
        book_reservation()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Dispose()
    End Sub
End Class