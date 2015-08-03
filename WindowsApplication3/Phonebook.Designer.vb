<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Phonebook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cntct_picbox = New System.Windows.Forms.PictureBox()
        Me.name_lbl = New System.Windows.Forms.Label()
        Me.n_lbl = New System.Windows.Forms.Label()
        Me.number_lbl = New System.Windows.Forms.Label()
        Me.no_lbl = New System.Windows.Forms.Label()
        Me.Cmpny_lbl = New System.Windows.Forms.Label()
        Me.c_lbl = New System.Windows.Forms.Label()
        Me.email_lbl = New System.Windows.Forms.Label()
        Me.mail_lbl = New System.Windows.Forms.Label()
        Me.address_lbl = New System.Windows.Forms.Label()
        Me.a_lbl = New System.Windows.Forms.Label()
        Me.nam_lbl = New System.Windows.Forms.Label()
        Me.buttons_box = New System.Windows.Forms.GroupBox()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.lcntct_btn = New System.Windows.Forms.Button()
        Me.fcntct_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.Previous_btn = New System.Windows.Forms.Button()
        Me.sino_lbl = New System.Windows.Forms.Label()
        Me.si_lbl = New System.Windows.Forms.Label()
        CType(Me.cntct_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.buttons_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'cntct_picbox
        '
        Me.cntct_picbox.Location = New System.Drawing.Point(533, 37)
        Me.cntct_picbox.Name = "cntct_picbox"
        Me.cntct_picbox.Size = New System.Drawing.Size(150, 150)
        Me.cntct_picbox.TabIndex = 0
        Me.cntct_picbox.TabStop = False
        '
        'name_lbl
        '
        Me.name_lbl.AutoSize = True
        Me.name_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_lbl.Location = New System.Drawing.Point(20, 86)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(51, 16)
        Me.name_lbl.TabIndex = 1
        Me.name_lbl.Text = "Name :"
        '
        'n_lbl
        '
        Me.n_lbl.AutoSize = True
        Me.n_lbl.Location = New System.Drawing.Point(221, 48)
        Me.n_lbl.Name = "n_lbl"
        Me.n_lbl.Size = New System.Drawing.Size(0, 13)
        Me.n_lbl.TabIndex = 2
        '
        'number_lbl
        '
        Me.number_lbl.AutoSize = True
        Me.number_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number_lbl.Location = New System.Drawing.Point(20, 141)
        Me.number_lbl.Name = "number_lbl"
        Me.number_lbl.Size = New System.Drawing.Size(81, 16)
        Me.number_lbl.TabIndex = 3
        Me.number_lbl.Text = "Ph Number :"
        '
        'no_lbl
        '
        Me.no_lbl.AutoSize = True
        Me.no_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.no_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_lbl.Location = New System.Drawing.Point(124, 143)
        Me.no_lbl.Name = "no_lbl"
        Me.no_lbl.Size = New System.Drawing.Size(49, 16)
        Me.no_lbl.TabIndex = 4
        Me.no_lbl.Text = "Label4"
        '
        'Cmpny_lbl
        '
        Me.Cmpny_lbl.AutoSize = True
        Me.Cmpny_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmpny_lbl.Location = New System.Drawing.Point(20, 204)
        Me.Cmpny_lbl.Name = "Cmpny_lbl"
        Me.Cmpny_lbl.Size = New System.Drawing.Size(72, 16)
        Me.Cmpny_lbl.TabIndex = 5
        Me.Cmpny_lbl.Text = "Company :"
        '
        'c_lbl
        '
        Me.c_lbl.AutoSize = True
        Me.c_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.c_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_lbl.Location = New System.Drawing.Point(124, 204)
        Me.c_lbl.Name = "c_lbl"
        Me.c_lbl.Size = New System.Drawing.Size(49, 16)
        Me.c_lbl.TabIndex = 6
        Me.c_lbl.Text = "Label6"
        '
        'email_lbl
        '
        Me.email_lbl.AutoSize = True
        Me.email_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_lbl.Location = New System.Drawing.Point(416, 202)
        Me.email_lbl.Name = "email_lbl"
        Me.email_lbl.Size = New System.Drawing.Size(48, 16)
        Me.email_lbl.TabIndex = 7
        Me.email_lbl.Text = "Email :"
        '
        'mail_lbl
        '
        Me.mail_lbl.AutoSize = True
        Me.mail_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mail_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail_lbl.Location = New System.Drawing.Point(478, 202)
        Me.mail_lbl.Name = "mail_lbl"
        Me.mail_lbl.Size = New System.Drawing.Size(49, 16)
        Me.mail_lbl.TabIndex = 8
        Me.mail_lbl.Text = "Label8"
        '
        'address_lbl
        '
        Me.address_lbl.AutoSize = True
        Me.address_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_lbl.Location = New System.Drawing.Point(20, 290)
        Me.address_lbl.Name = "address_lbl"
        Me.address_lbl.Size = New System.Drawing.Size(59, 16)
        Me.address_lbl.TabIndex = 9
        Me.address_lbl.Text = "Address"
        '
        'a_lbl
        '
        Me.a_lbl.AutoSize = True
        Me.a_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.a_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_lbl.Location = New System.Drawing.Point(20, 332)
        Me.a_lbl.Name = "a_lbl"
        Me.a_lbl.Size = New System.Drawing.Size(56, 16)
        Me.a_lbl.TabIndex = 10
        Me.a_lbl.Text = "Label10"
        '
        'nam_lbl
        '
        Me.nam_lbl.AutoSize = True
        Me.nam_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nam_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nam_lbl.Location = New System.Drawing.Point(122, 86)
        Me.nam_lbl.Name = "nam_lbl"
        Me.nam_lbl.Size = New System.Drawing.Size(49, 16)
        Me.nam_lbl.TabIndex = 11
        Me.nam_lbl.Text = "Label1"
        '
        'buttons_box
        '
        Me.buttons_box.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.buttons_box.Controls.Add(Me.exit_btn)
        Me.buttons_box.Controls.Add(Me.lcntct_btn)
        Me.buttons_box.Controls.Add(Me.fcntct_btn)
        Me.buttons_box.Controls.Add(Me.edit_btn)
        Me.buttons_box.Controls.Add(Me.back_btn)
        Me.buttons_box.Controls.Add(Me.next_btn)
        Me.buttons_box.Controls.Add(Me.Previous_btn)
        Me.buttons_box.Location = New System.Drawing.Point(80, 396)
        Me.buttons_box.Name = "buttons_box"
        Me.buttons_box.Size = New System.Drawing.Size(583, 113)
        Me.buttons_box.TabIndex = 12
        Me.buttons_box.TabStop = False
        Me.buttons_box.Text = "Menu"
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(227, 70)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(123, 21)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "&Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'lcntct_btn
        '
        Me.lcntct_btn.Location = New System.Drawing.Point(454, 24)
        Me.lcntct_btn.Name = "lcntct_btn"
        Me.lcntct_btn.Size = New System.Drawing.Size(123, 23)
        Me.lcntct_btn.TabIndex = 5
        Me.lcntct_btn.Text = "&Last Contact"
        Me.lcntct_btn.UseVisualStyleBackColor = True
        '
        'fcntct_btn
        '
        Me.fcntct_btn.Location = New System.Drawing.Point(6, 23)
        Me.fcntct_btn.Name = "fcntct_btn"
        Me.fcntct_btn.Size = New System.Drawing.Size(123, 24)
        Me.fcntct_btn.TabIndex = 4
        Me.fcntct_btn.Text = "&First Contact"
        Me.fcntct_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Location = New System.Drawing.Point(402, 70)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(123, 24)
        Me.edit_btn.TabIndex = 3
        Me.edit_btn.Text = "E&dit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(53, 70)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(123, 24)
        Me.back_btn.TabIndex = 2
        Me.back_btn.Text = "&Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(294, 24)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(123, 24)
        Me.next_btn.TabIndex = 1
        Me.next_btn.Text = "&Next Contact"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'Previous_btn
        '
        Me.Previous_btn.Location = New System.Drawing.Point(165, 24)
        Me.Previous_btn.Name = "Previous_btn"
        Me.Previous_btn.Size = New System.Drawing.Size(123, 24)
        Me.Previous_btn.TabIndex = 0
        Me.Previous_btn.Text = "&Previous Contact"
        Me.Previous_btn.UseVisualStyleBackColor = True
        '
        'sino_lbl
        '
        Me.sino_lbl.AutoSize = True
        Me.sino_lbl.Location = New System.Drawing.Point(20, 37)
        Me.sino_lbl.Name = "sino_lbl"
        Me.sino_lbl.Size = New System.Drawing.Size(39, 13)
        Me.sino_lbl.TabIndex = 13
        Me.sino_lbl.Text = "Si No :"
        '
        'si_lbl
        '
        Me.si_lbl.AutoSize = True
        Me.si_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.si_lbl.Location = New System.Drawing.Point(124, 37)
        Me.si_lbl.Name = "si_lbl"
        Me.si_lbl.Size = New System.Drawing.Size(33, 13)
        Me.si_lbl.TabIndex = 14
        Me.si_lbl.Text = "Si No"
        '
        'Phonebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 521)
        Me.Controls.Add(Me.si_lbl)
        Me.Controls.Add(Me.sino_lbl)
        Me.Controls.Add(Me.buttons_box)
        Me.Controls.Add(Me.nam_lbl)
        Me.Controls.Add(Me.a_lbl)
        Me.Controls.Add(Me.address_lbl)
        Me.Controls.Add(Me.mail_lbl)
        Me.Controls.Add(Me.email_lbl)
        Me.Controls.Add(Me.c_lbl)
        Me.Controls.Add(Me.Cmpny_lbl)
        Me.Controls.Add(Me.no_lbl)
        Me.Controls.Add(Me.number_lbl)
        Me.Controls.Add(Me.n_lbl)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.cntct_picbox)
        Me.Name = "Phonebook"
        Me.Text = "Phonebook"
        CType(Me.cntct_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.buttons_box.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cntct_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents name_lbl As System.Windows.Forms.Label
    Friend WithEvents n_lbl As System.Windows.Forms.Label
    Friend WithEvents number_lbl As System.Windows.Forms.Label
    Friend WithEvents no_lbl As System.Windows.Forms.Label
    Friend WithEvents Cmpny_lbl As System.Windows.Forms.Label
    Friend WithEvents c_lbl As System.Windows.Forms.Label
    Friend WithEvents email_lbl As System.Windows.Forms.Label
    Friend WithEvents mail_lbl As System.Windows.Forms.Label
    Friend WithEvents address_lbl As System.Windows.Forms.Label
    Friend WithEvents a_lbl As System.Windows.Forms.Label
    Friend WithEvents nam_lbl As System.Windows.Forms.Label
    Friend WithEvents buttons_box As System.Windows.Forms.GroupBox
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents Previous_btn As System.Windows.Forms.Button
    Friend WithEvents lcntct_btn As Button
    Friend WithEvents fcntct_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents sino_lbl As Label
    Friend WithEvents si_lbl As Label
End Class
