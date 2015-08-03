<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pbook_edit
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
        Me.Name_lbl = New System.Windows.Forms.Label()
        Me.no_lbl = New System.Windows.Forms.Label()
        Me.cmpny_lbl = New System.Windows.Forms.Label()
        Me.mail_lbl = New System.Windows.Forms.Label()
        Me.adrs_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.name_txtbox = New System.Windows.Forms.TextBox()
        Me.no_txtbox = New System.Windows.Forms.TextBox()
        Me.cmpny_txtbox = New System.Windows.Forms.TextBox()
        Me.mail_txtbox = New System.Windows.Forms.TextBox()
        Me.adrs_txtbox = New System.Windows.Forms.TextBox()
        Me.can_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.menu_grpbox = New System.Windows.Forms.GroupBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.sino_lbl = New System.Windows.Forms.Label()
        Me.si_txt = New System.Windows.Forms.TextBox()
        Me.iupload_btn = New System.Windows.Forms.Button()
        Me.OFGSelectImage = New System.Windows.Forms.OpenFileDialog()
        Me.ibrowse_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_grpbox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_lbl.Location = New System.Drawing.Point(30, 94)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(51, 16)
        Me.Name_lbl.TabIndex = 0
        Me.Name_lbl.Text = "Name :"
        '
        'no_lbl
        '
        Me.no_lbl.AutoSize = True
        Me.no_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_lbl.Location = New System.Drawing.Point(30, 165)
        Me.no_lbl.Name = "no_lbl"
        Me.no_lbl.Size = New System.Drawing.Size(81, 16)
        Me.no_lbl.TabIndex = 1
        Me.no_lbl.Text = "Ph Number :"
        '
        'cmpny_lbl
        '
        Me.cmpny_lbl.AutoSize = True
        Me.cmpny_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpny_lbl.Location = New System.Drawing.Point(30, 293)
        Me.cmpny_lbl.Name = "cmpny_lbl"
        Me.cmpny_lbl.Size = New System.Drawing.Size(72, 16)
        Me.cmpny_lbl.TabIndex = 2
        Me.cmpny_lbl.Text = "Company :"
        '
        'mail_lbl
        '
        Me.mail_lbl.AutoSize = True
        Me.mail_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail_lbl.Location = New System.Drawing.Point(379, 296)
        Me.mail_lbl.Name = "mail_lbl"
        Me.mail_lbl.Size = New System.Drawing.Size(48, 16)
        Me.mail_lbl.TabIndex = 3
        Me.mail_lbl.Text = "Email :"
        '
        'adrs_lbl
        '
        Me.adrs_lbl.AutoSize = True
        Me.adrs_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adrs_lbl.Location = New System.Drawing.Point(30, 323)
        Me.adrs_lbl.Name = "adrs_lbl"
        Me.adrs_lbl.Size = New System.Drawing.Size(65, 16)
        Me.adrs_lbl.TabIndex = 4
        Me.adrs_lbl.Text = "Address :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'name_txtbox
        '
        Me.name_txtbox.Location = New System.Drawing.Point(158, 93)
        Me.name_txtbox.Name = "name_txtbox"
        Me.name_txtbox.Size = New System.Drawing.Size(230, 20)
        Me.name_txtbox.TabIndex = 6
        '
        'no_txtbox
        '
        Me.no_txtbox.Location = New System.Drawing.Point(158, 161)
        Me.no_txtbox.Name = "no_txtbox"
        Me.no_txtbox.Size = New System.Drawing.Size(230, 20)
        Me.no_txtbox.TabIndex = 7
        '
        'cmpny_txtbox
        '
        Me.cmpny_txtbox.Location = New System.Drawing.Point(158, 292)
        Me.cmpny_txtbox.Name = "cmpny_txtbox"
        Me.cmpny_txtbox.Size = New System.Drawing.Size(165, 20)
        Me.cmpny_txtbox.TabIndex = 8
        '
        'mail_txtbox
        '
        Me.mail_txtbox.Location = New System.Drawing.Point(480, 292)
        Me.mail_txtbox.Name = "mail_txtbox"
        Me.mail_txtbox.Size = New System.Drawing.Size(169, 20)
        Me.mail_txtbox.TabIndex = 9
        '
        'adrs_txtbox
        '
        Me.adrs_txtbox.Location = New System.Drawing.Point(33, 342)
        Me.adrs_txtbox.Multiline = True
        Me.adrs_txtbox.Name = "adrs_txtbox"
        Me.adrs_txtbox.Size = New System.Drawing.Size(614, 55)
        Me.adrs_txtbox.TabIndex = 10
        '
        'can_btn
        '
        Me.can_btn.Location = New System.Drawing.Point(22, 16)
        Me.can_btn.Name = "can_btn"
        Me.can_btn.Size = New System.Drawing.Size(145, 31)
        Me.can_btn.TabIndex = 11
        Me.can_btn.Text = "&Cancel/Back"
        Me.can_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(189, 16)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(145, 31)
        Me.save_btn.TabIndex = 12
        Me.save_btn.Text = "&Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'menu_grpbox
        '
        Me.menu_grpbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.menu_grpbox.Controls.Add(Me.delete_btn)
        Me.menu_grpbox.Controls.Add(Me.save_btn)
        Me.menu_grpbox.Controls.Add(Me.can_btn)
        Me.menu_grpbox.Location = New System.Drawing.Point(123, 447)
        Me.menu_grpbox.Name = "menu_grpbox"
        Me.menu_grpbox.Size = New System.Drawing.Size(525, 53)
        Me.menu_grpbox.TabIndex = 13
        Me.menu_grpbox.TabStop = False
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(357, 16)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(144, 31)
        Me.delete_btn.TabIndex = 13
        Me.delete_btn.Text = "&Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'sino_lbl
        '
        Me.sino_lbl.AutoSize = True
        Me.sino_lbl.Location = New System.Drawing.Point(30, 42)
        Me.sino_lbl.Name = "sino_lbl"
        Me.sino_lbl.Size = New System.Drawing.Size(39, 13)
        Me.sino_lbl.TabIndex = 14
        Me.sino_lbl.Text = "Si No :"
        '
        'si_txt
        '
        Me.si_txt.Location = New System.Drawing.Point(158, 42)
        Me.si_txt.Name = "si_txt"
        Me.si_txt.Size = New System.Drawing.Size(230, 20)
        Me.si_txt.TabIndex = 15
        '
        'iupload_btn
        '
        Me.iupload_btn.Location = New System.Drawing.Point(514, 244)
        Me.iupload_btn.Name = "iupload_btn"
        Me.iupload_btn.Size = New System.Drawing.Size(121, 21)
        Me.iupload_btn.TabIndex = 16
        Me.iupload_btn.Text = "&Upload Image"
        Me.iupload_btn.UseVisualStyleBackColor = True
        '
        'OFGSelectImage
        '
        Me.OFGSelectImage.FileName = "OpenFileDialog1"
        '
        'ibrowse_btn
        '
        Me.ibrowse_btn.Location = New System.Drawing.Point(514, 216)
        Me.ibrowse_btn.Name = "ibrowse_btn"
        Me.ibrowse_btn.Size = New System.Drawing.Size(120, 22)
        Me.ibrowse_btn.TabIndex = 17
        Me.ibrowse_btn.Text = "&Browse Image"
        Me.ibrowse_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(492, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 170)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image (size:150x150 | <15kb)"
        '
        'pbook_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ibrowse_btn)
        Me.Controls.Add(Me.iupload_btn)
        Me.Controls.Add(Me.si_txt)
        Me.Controls.Add(Me.sino_lbl)
        Me.Controls.Add(Me.menu_grpbox)
        Me.Controls.Add(Me.adrs_txtbox)
        Me.Controls.Add(Me.mail_txtbox)
        Me.Controls.Add(Me.cmpny_txtbox)
        Me.Controls.Add(Me.no_txtbox)
        Me.Controls.Add(Me.name_txtbox)
        Me.Controls.Add(Me.adrs_lbl)
        Me.Controls.Add(Me.mail_lbl)
        Me.Controls.Add(Me.cmpny_lbl)
        Me.Controls.Add(Me.no_lbl)
        Me.Controls.Add(Me.Name_lbl)
        Me.Name = "pbook_edit"
        Me.Text = "Update Contacts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_grpbox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name_lbl As Label
    Friend WithEvents no_lbl As Label
    Friend WithEvents cmpny_lbl As Label
    Friend WithEvents mail_lbl As Label
    Friend WithEvents adrs_lbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents name_txtbox As TextBox
    Friend WithEvents no_txtbox As TextBox
    Friend WithEvents cmpny_txtbox As TextBox
    Friend WithEvents mail_txtbox As TextBox
    Friend WithEvents adrs_txtbox As TextBox
    Friend WithEvents can_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents menu_grpbox As GroupBox
    Friend WithEvents delete_btn As Button
    Friend WithEvents sino_lbl As Label
    Friend WithEvents si_txt As TextBox
    Friend WithEvents iupload_btn As Button
    Friend WithEvents OFGSelectImage As OpenFileDialog
    Friend WithEvents ibrowse_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
