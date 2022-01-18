Imports System.Data.SqlClient
Public Class RoomFrm

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

    Sub search_room()
        Room_grid_list.Rows.Clear()
        Dim load_rooms_query As String = "SELECT * FROM rooms WHERE room_no LIKE '%" & search_room_text.Text & "%'"

        cm = New SqlCommand(load_rooms_query, connect)
        dr = cm.ExecuteReader
        While dr.Read
            Room_grid_list.Rows.Add(dr.Item("id").ToString, dr.Item("room_no").ToString, dr.Item("room_type").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("max_person").ToString)
        End While
        dr.Close()
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Dispose()
    End Sub

    Private Sub add_new_room_btn_Click(sender As Object, e As EventArgs) Handles add_new_room_btn.Click
        AddRoomFrm.ShowDialog()
    End Sub

    Private Sub RoomFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_rooms()
    End Sub

    Private Sub search_room_text_TextChanged(sender As Object, e As EventArgs) Handles search_room_text.TextChanged
        search_room()
    End Sub
End Class