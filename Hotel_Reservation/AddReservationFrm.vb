Imports System.Data.SqlClient
Imports System.Threading.Thread


Public Class AddReservationFrm
    Dim customer_name As String = ""
    Sub get_latest_customer()
        Dim get_latest_customer_query As String = "SELECT TOP 1  CONCAT(firstname,' ',lastname) as customer_name FROM customers ORDER BY id DESC;"
        cm = New SqlCommand(get_latest_customer_query, connect)
        dr = cm.ExecuteReader

        If dr.Read Then
            customer_name = dr.Item("customer_name")
        End If
        Label10.Text = customer_name
    End Sub
    Sub save_customer()
        Dim save_customer_query As String = "INSERT INTO customers (lastname, firstname, middlename, contact_no, address) VALUES " _
                                            & "('" & customer_last_name.Text & "', '" & customer_first_name.Text & "', '" & customer_middle_name.Text & "', '" & customer_contact.Text & "','" & customer_address.Text & "')"
        cm = New SqlCommand(save_customer_query, connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Customer information save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub book_reservation()
        save_customer()
        get_latest_customer()
        Dim book_reservation_query As String = "INSERT INTO reservations VALUES ('" & room_box.Text & "', '" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "', '" & customer_name & "', 'pending', '" & DateTimePicker2.Value.ToString("hh:mm:ss") & "', '" & DateTimePicker3.Value.ToString("hh:mm:ss") & "')"
        cm = New SqlCommand(book_reservation_query, connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ReservationFrm.load_reservations()
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

    Sub check_book_reservation()
        Dim check_resevartion_query As String = "SELECT  room, date_reservation FROM reservations WHERE room='" & room_box.Text & "' AND date_reservation='" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "'"
        cm = New SqlCommand(check_resevartion_query, connect)
        dr = cm.ExecuteReader
        If dr.Read Then
            MessageBox.Show("They are reservation for this room and date!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            book_reservation()
        End If
    End Sub
    Sub datetimepicker_format()
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Value = DateTime.Today


        DateTimePicker2.CustomFormat = "hh:mm tt"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Value = DateTime.Now

        DateTimePicker3.CustomFormat = "hh:mm tt"
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Value = DateTime.Now

        'DateTimePicker2.ToString("HH:mm")
    End Sub

    Sub send_message_confirmation()
        Try
            SerialPort1.Open()

            SerialPort1.Write("AT+CMGS=" & """" & customer_contact.Text & """" & vbCrLf)
            Sleep(1000)
            SerialPort1.Write("You are already have booked reservation for date and time" & Chr(26))
            Sleep(3000)
            Dim asd As String = SerialPort1.ReadExisting
            If InStr(asd, "OK") Then
                MsgBox("SEND", MsgBoxStyle.Information)
                '
            Else
                MsgBox("Failed!", MsgBoxStyle.Exclamation)
                '
            End If
            SerialPort1.DtrEnable = False
            SerialPort1.RtsEnable = False
            SerialPort1.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddReservationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetimepicker_format()
        load_rooms()
    End Sub

    Private Sub save_room_btn_Click(sender As Object, e As EventArgs) Handles save_room_btn.Click
        'book_reservation()
        check_book_reservation()
        'save_customer()
        'get_latest_customer()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Dispose()
    End Sub
End Class