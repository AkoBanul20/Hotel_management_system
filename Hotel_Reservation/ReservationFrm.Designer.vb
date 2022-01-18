<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationFrm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EnrollBtn = New System.Windows.Forms.Button()
        Me.make_reserve_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reservation_grid_list = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.EID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.reservation_grid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 31)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(615, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reservation"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.EnrollBtn)
        Me.Panel2.Controls.Add(Me.make_reserve_btn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(9, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 75)
        Me.Panel2.TabIndex = 17
        '
        'EnrollBtn
        '
        Me.EnrollBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.EnrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.EnrollBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.EnrollBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.EnrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollBtn.ForeColor = System.Drawing.Color.White
        Me.EnrollBtn.Location = New System.Drawing.Point(398, 39)
        Me.EnrollBtn.Name = "EnrollBtn"
        Me.EnrollBtn.Size = New System.Drawing.Size(88, 27)
        Me.EnrollBtn.TabIndex = 8
        Me.EnrollBtn.Text = "Search"
        Me.EnrollBtn.UseVisualStyleBackColor = False
        '
        'make_reserve_btn
        '
        Me.make_reserve_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.make_reserve_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.make_reserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.make_reserve_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.make_reserve_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.make_reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.make_reserve_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.make_reserve_btn.ForeColor = System.Drawing.Color.White
        Me.make_reserve_btn.Location = New System.Drawing.Point(493, 39)
        Me.make_reserve_btn.Name = "make_reserve_btn"
        Me.make_reserve_btn.Size = New System.Drawing.Size(138, 27)
        Me.make_reserve_btn.TabIndex = 5
        Me.make_reserve_btn.Text = "Make Reservation"
        Me.make_reserve_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Reservation"
        '
        'reservation_grid_list
        '
        Me.reservation_grid_list.AllowUserToAddRows = False
        Me.reservation_grid_list.AllowUserToDeleteRows = False
        Me.reservation_grid_list.BackgroundColor = System.Drawing.Color.White
        Me.reservation_grid_list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reservation_grid_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reservation_grid_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.reservation_grid_list.ColumnHeadersHeight = 30
        Me.reservation_grid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.reservation_grid_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reservation_grid_list.DefaultCellStyle = DataGridViewCellStyle6
        Me.reservation_grid_list.EnableHeadersVisualStyles = False
        Me.reservation_grid_list.GridColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.reservation_grid_list.Location = New System.Drawing.Point(9, 165)
        Me.reservation_grid_list.Name = "reservation_grid_list"
        Me.reservation_grid_list.ReadOnly = True
        Me.reservation_grid_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.reservation_grid_list.RowHeadersVisible = False
        Me.reservation_grid_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.reservation_grid_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.reservation_grid_list.ShowEditingIcon = False
        Me.reservation_grid_list.ShowRowErrors = False
        Me.reservation_grid_list.Size = New System.Drawing.Size(647, 329)
        Me.reservation_grid_list.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(188, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(206, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'EID
        '
        Me.EID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EID.HeaderText = "ID"
        Me.EID.Name = "EID"
        Me.EID.ReadOnly = True
        Me.EID.Width = 44
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Room No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Reserved Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Reserved By"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 106
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Check In"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 88
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Check Out"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 101
        '
        'ReservationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 515)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.reservation_grid_list)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReservationFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationFrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.reservation_grid_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents make_reserve_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reservation_grid_list As System.Windows.Forms.DataGridView
    Friend WithEvents EnrollBtn As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents EID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
