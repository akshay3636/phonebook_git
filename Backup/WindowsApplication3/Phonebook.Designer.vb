<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phonebook
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
        Me.cntct_picbox = New System.Windows.Forms.PictureBox
        Me.name_lbl = New System.Windows.Forms.Label
        Me.n_lbl = New System.Windows.Forms.Label
        Me.number_lbl = New System.Windows.Forms.Label
        Me.no_lbl = New System.Windows.Forms.Label
        Me.Cmpny_lbl = New System.Windows.Forms.Label
        Me.c_lbl = New System.Windows.Forms.Label
        Me.email_lbl = New System.Windows.Forms.Label
        Me.mail_lbl = New System.Windows.Forms.Label
        Me.address_lbl = New System.Windows.Forms.Label
        Me.a_lbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.buttons_box = New System.Windows.Forms.GroupBox
        Me.Previous_btn = New System.Windows.Forms.Button
        Me.next_btn = New System.Windows.Forms.Button
        Me.back_btn = New System.Windows.Forms.Button
        Me.edit_btn = New System.Windows.Forms.Button
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
        Me.name_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_lbl.Location = New System.Drawing.Point(20, 50)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(74, 26)
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
        Me.number_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number_lbl.Location = New System.Drawing.Point(20, 122)
        Me.number_lbl.Name = "number_lbl"
        Me.number_lbl.Size = New System.Drawing.Size(120, 26)
        Me.number_lbl.TabIndex = 3
        Me.number_lbl.Text = "Ph Number :"
        '
        'no_lbl
        '
        Me.no_lbl.AutoSize = True
        Me.no_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_lbl.Location = New System.Drawing.Point(220, 124)
        Me.no_lbl.Name = "no_lbl"
        Me.no_lbl.Size = New System.Drawing.Size(66, 24)
        Me.no_lbl.TabIndex = 4
        Me.no_lbl.Text = "Label4"
        '
        'Cmpny_lbl
        '
        Me.Cmpny_lbl.AutoSize = True
        Me.Cmpny_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmpny_lbl.Location = New System.Drawing.Point(20, 204)
        Me.Cmpny_lbl.Name = "Cmpny_lbl"
        Me.Cmpny_lbl.Size = New System.Drawing.Size(100, 26)
        Me.Cmpny_lbl.TabIndex = 5
        Me.Cmpny_lbl.Text = "Company :"
        '
        'c_lbl
        '
        Me.c_lbl.AutoSize = True
        Me.c_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_lbl.Location = New System.Drawing.Point(220, 204)
        Me.c_lbl.Name = "c_lbl"
        Me.c_lbl.Size = New System.Drawing.Size(66, 24)
        Me.c_lbl.TabIndex = 6
        Me.c_lbl.Text = "Label6"
        '
        'email_lbl
        '
        Me.email_lbl.AutoSize = True
        Me.email_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_lbl.Location = New System.Drawing.Point(403, 202)
        Me.email_lbl.Name = "email_lbl"
        Me.email_lbl.Size = New System.Drawing.Size(70, 26)
        Me.email_lbl.TabIndex = 7
        Me.email_lbl.Text = "Email :"
        '
        'mail_lbl
        '
        Me.mail_lbl.AutoSize = True
        Me.mail_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail_lbl.Location = New System.Drawing.Point(504, 202)
        Me.mail_lbl.Name = "mail_lbl"
        Me.mail_lbl.Size = New System.Drawing.Size(66, 24)
        Me.mail_lbl.TabIndex = 8
        Me.mail_lbl.Text = "Label8"
        '
        'address_lbl
        '
        Me.address_lbl.AutoSize = True
        Me.address_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_lbl.Location = New System.Drawing.Point(20, 290)
        Me.address_lbl.Name = "address_lbl"
        Me.address_lbl.Size = New System.Drawing.Size(84, 26)
        Me.address_lbl.TabIndex = 9
        Me.address_lbl.Text = "Address"
        '
        'a_lbl
        '
        Me.a_lbl.AutoSize = True
        Me.a_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_lbl.Location = New System.Drawing.Point(27, 332)
        Me.a_lbl.Name = "a_lbl"
        Me.a_lbl.Size = New System.Drawing.Size(76, 24)
        Me.a_lbl.TabIndex = 10
        Me.a_lbl.Text = "Label10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'buttons_box
        '
        Me.buttons_box.Controls.Add(Me.edit_btn)
        Me.buttons_box.Controls.Add(Me.back_btn)
        Me.buttons_box.Controls.Add(Me.next_btn)
        Me.buttons_box.Controls.Add(Me.Previous_btn)
        Me.buttons_box.Location = New System.Drawing.Point(63, 396)
        Me.buttons_box.Name = "buttons_box"
        Me.buttons_box.Size = New System.Drawing.Size(583, 113)
        Me.buttons_box.TabIndex = 12
        Me.buttons_box.TabStop = False
        Me.buttons_box.Text = "Menu"
        '
        'Previous_btn
        '
        Me.Previous_btn.Location = New System.Drawing.Point(13, 23)
        Me.Previous_btn.Name = "Previous_btn"
        Me.Previous_btn.Size = New System.Drawing.Size(123, 24)
        Me.Previous_btn.TabIndex = 0
        Me.Previous_btn.Text = "Previous Contact"
        Me.Previous_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(445, 23)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(123, 24)
        Me.next_btn.TabIndex = 1
        Me.next_btn.Text = "Next Contact"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(53, 70)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(123, 24)
        Me.back_btn.TabIndex = 2
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Location = New System.Drawing.Point(402, 70)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(123, 24)
        Me.edit_btn.TabIndex = 3
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'Phonebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 521)
        Me.Controls.Add(Me.buttons_box)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttons_box As System.Windows.Forms.GroupBox
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents Previous_btn As System.Windows.Forms.Button
End Class
