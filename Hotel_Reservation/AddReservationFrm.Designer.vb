<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReservationFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.save_room_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.room_box = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.customer_text = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 321)
        Me.Panel1.TabIndex = 1
        '
        'save_room_btn
        '
        Me.save_room_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.save_room_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_room_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.save_room_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.save_room_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.save_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_room_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_room_btn.ForeColor = System.Drawing.Color.White
        Me.save_room_btn.Location = New System.Drawing.Point(390, 279)
        Me.save_room_btn.Name = "save_room_btn"
        Me.save_room_btn.Size = New System.Drawing.Size(88, 30)
        Me.save_room_btn.TabIndex = 13
        Me.save_room_btn.Text = "Book"
        Me.save_room_btn.UseVisualStyleBackColor = False
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cancel_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.White
        Me.cancel_btn.Location = New System.Drawing.Point(479, 279)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(90, 30)
        Me.cancel_btn.TabIndex = 12
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(91, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Reservation Details"
        '
        'room_box
        '
        Me.room_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.room_box.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_box.FormattingEnabled = True
        Me.room_box.Location = New System.Drawing.Point(95, 63)
        Me.room_box.Name = "room_box"
        Me.room_box.Size = New System.Drawing.Size(239, 25)
        Me.room_box.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Room"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(340, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(229, 23)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateTimePicker2.Location = New System.Drawing.Point(95, 120)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(239, 23)
        Me.DateTimePicker2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Check In Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Check Out Time"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateTimePicker3.Location = New System.Drawing.Point(340, 120)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(229, 23)
        Me.DateTimePicker3.TabIndex = 52
        '
        'customer_text
        '
        Me.customer_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_text.Location = New System.Drawing.Point(95, 175)
        Me.customer_text.Multiline = True
        Me.customer_text.Name = "customer_text"
        Me.customer_text.Size = New System.Drawing.Size(474, 25)
        Me.customer_text.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(92, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 17)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Customer Name"
        '
        'AddReservationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 321)
        Me.Controls.Add(Me.customer_text)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.room_box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save_room_btn)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddReservationFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddReservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents save_room_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents room_box As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents customer_text As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
