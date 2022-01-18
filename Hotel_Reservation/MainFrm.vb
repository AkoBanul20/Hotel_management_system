Imports System.Data.SqlClient
Public Class MainFrm

    Sub count_reservations()
        Dim count_reservation_query As String = "SELECT COUNT(status) AS TOTAL FROM reservations WHERE status='pending' "
        cm = New SqlCommand(count_reservation_query, connect)
        dr = cm.ExecuteReader
        While dr.Read
            count_reservation_text.Text = dr.Item("TOTAL").ToString
        End While
    End Sub

    Sub count_available_room()
        Dim count_room_query As String = "SELECT COUNT(is_available) AS TOTAL FROM rooms WHERE is_available=1"
        cm = New SqlCommand(count_room_query, connect)
        dr = cm.ExecuteReader
        While dr.Read
            count_avail_room_text.Text = dr.Item("TOTAL").ToString
        End While
    End Sub

    Sub load_rooms()
        Room_grid_list.Rows.Clear()
        Dim load_rooms_query As String = "SELECT * FROM rooms"

        cm = New SqlCommand(load_rooms_query, connect)
        dr = cm.ExecuteReader
        While dr.Read
            Room_grid_list.Rows.Add(dr.Item("id").ToString, dr.Item("room_no").ToString, dr.Item("room_type").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("max_person").ToString)
        End While
        dr.Close()
    End Sub


    Private Sub room_btn_Click(sender As Object, e As EventArgs) Handles room_btn.Click
        RoomFrm.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        close_system()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_rooms()
        count_available_room()
        count_reservations()
    End Sub

    Private Sub reservation_btn_Click(sender As Object, e As EventArgs) Handles reservation_btn.Click
        ReservationFrm.ShowDialog()
    End Sub
End Class