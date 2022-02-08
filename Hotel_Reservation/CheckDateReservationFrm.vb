Imports System.Data.SqlClient

Public Class CheckDateReservationFrm
    Sub datetimepicker_format()
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Value = DateTime.Today
    End Sub

    Sub available_dates()

    End Sub
    Private Sub CheckDateReservationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetimepicker_format()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Dispose()
    End Sub


End Class