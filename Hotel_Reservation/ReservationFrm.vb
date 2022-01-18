Imports System.Data.SqlClient

Public Class ReservationFrm
    Sub load_reservations()
        reservation_grid_list.Rows.Clear()
        Dim load_reservation_queyr As String = "SELECT * FROM reservations"
        cm = New SqlCommand(load_reservation_queyr, connect)

        dr = cm.ExecuteReader

        While dr.Read

            Dim checkin As DateTime = dr.Item("check_in")
            Dim date_reserved As DateTime = dr.Item("date_reservation")
            Dim checkout As DateTime = dr.Item("check_out")


            Dim new_checkin = checkin.ToString("hh:mm tt")
            Dim new_checkout = checkout.ToString("hh:mm tt")
            Dim new_date_reserved = date_reserved.ToString("MM/dd/yyyy")
            reservation_grid_list.Rows.Add(dr.Item("ID").ToString(), dr.Item("room").ToString(), new_date_reserved, dr.Item("customer_name").ToString(), new_checkin, new_checkout)
        End While
        dr.Close()


    End Sub
    Private Sub make_reserve_btn_Click(sender As Object, e As EventArgs) Handles make_reserve_btn.Click
        AddReservationFrm.ShowDialog()
    End Sub

    Private Sub ReservationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_reservations()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Dispose()
    End Sub
End Class