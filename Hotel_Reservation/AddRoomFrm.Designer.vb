<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoomFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_room_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.roomno_text = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.room_type_box = New System.Windows.Forms.ComboBox()
        Me.description_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.price_text = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.max_person_text = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 321)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(90, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Room Information"
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
        Me.save_room_btn.Location = New System.Drawing.Point(410, 279)
        Me.save_room_btn.Name = "save_room_btn"
        Me.save_room_btn.Size = New System.Drawing.Size(88, 30)
        Me.save_room_btn.TabIndex = 11
        Me.save_room_btn.Text = "Save"
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
        Me.cancel_btn.Location = New System.Drawing.Point(499, 279)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(90, 30)
        Me.cancel_btn.TabIndex = 10
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Room Type"
        '
        'roomno_text
        '
        Me.roomno_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomno_text.Location = New System.Drawing.Point(94, 73)
        Me.roomno_text.Multiline = True
        Me.roomno_text.Name = "roomno_text"
        Me.roomno_text.Size = New System.Drawing.Size(221, 25)
        Me.roomno_text.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(91, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Room No."
        '
        'room_type_box
        '
        Me.room_type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.room_type_box.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_type_box.FormattingEnabled = True
        Me.room_type_box.Items.AddRange(New Object() {"Standard", "Deluxe", "Economy"})
        Me.room_type_box.Location = New System.Drawing.Point(321, 73)
        Me.room_type_box.Name = "room_type_box"
        Me.room_type_box.Size = New System.Drawing.Size(239, 25)
        Me.room_type_box.TabIndex = 45
        '
        'description_text
        '
        Me.description_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_text.Location = New System.Drawing.Point(94, 128)
        Me.description_text.Multiline = True
        Me.description_text.Name = "description_text"
        Me.description_text.Size = New System.Drawing.Size(466, 63)
        Me.description_text.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Description"
        '
        'price_text
        '
        Me.price_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price_text.Location = New System.Drawing.Point(95, 224)
        Me.price_text.Multiline = True
        Me.price_text.Name = "price_text"
        Me.price_text.Size = New System.Drawing.Size(221, 25)
        Me.price_text.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(318, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Max Person"
        '
        'max_person_text
        '
        Me.max_person_text.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.max_person_text.Location = New System.Drawing.Point(321, 224)
        Me.max_person_text.Multiline = True
        Me.max_person_text.Name = "max_person_text"
        Me.max_person_text.Size = New System.Drawing.Size(239, 25)
        Me.max_person_text.TabIndex = 49
        '
        'AddRoomFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 321)
        Me.Controls.Add(Me.max_person_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.price_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.description_text)
        Me.Controls.Add(Me.room_type_box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.roomno_text)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.save_room_btn)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddRoomFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddRoomFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents save_room_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents roomno_text As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents room_type_box As System.Windows.Forms.ComboBox
    Friend WithEvents description_text As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents price_text As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents max_person_text As System.Windows.Forms.TextBox
End Class
