<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.v_phnbook_btn = New System.Windows.Forms.Button()
        Me.new_cntct_btn = New System.Windows.Forms.Button()
        Me.search_box = New System.Windows.Forms.GroupBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.s_byno_txt = New System.Windows.Forms.TextBox()
        Me.or_lbl = New System.Windows.Forms.Label()
        Me.s_byno_lbl = New System.Windows.Forms.Label()
        Me.s_byname_txt = New System.Windows.Forms.TextBox()
        Me.s_byname_lbl = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.search_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'v_phnbook_btn
        '
        Me.v_phnbook_btn.Location = New System.Drawing.Point(39, 69)
        Me.v_phnbook_btn.Name = "v_phnbook_btn"
        Me.v_phnbook_btn.Size = New System.Drawing.Size(241, 37)
        Me.v_phnbook_btn.TabIndex = 0
        Me.v_phnbook_btn.Text = "&View Phonebook"
        Me.v_phnbook_btn.UseVisualStyleBackColor = True
        '
        'new_cntct_btn
        '
        Me.new_cntct_btn.Location = New System.Drawing.Point(39, 255)
        Me.new_cntct_btn.Name = "new_cntct_btn"
        Me.new_cntct_btn.Size = New System.Drawing.Size(241, 37)
        Me.new_cntct_btn.TabIndex = 1
        Me.new_cntct_btn.Text = "&Add New Contact"
        Me.new_cntct_btn.UseVisualStyleBackColor = True
        '
        'search_box
        '
        Me.search_box.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.search_box.Controls.Add(Me.search_btn)
        Me.search_box.Controls.Add(Me.s_byno_txt)
        Me.search_box.Controls.Add(Me.or_lbl)
        Me.search_box.Controls.Add(Me.s_byno_lbl)
        Me.search_box.Controls.Add(Me.s_byname_txt)
        Me.search_box.Controls.Add(Me.s_byname_lbl)
        Me.search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_box.Location = New System.Drawing.Point(323, 40)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(301, 298)
        Me.search_box.TabIndex = 2
        Me.search_box.TabStop = False
        Me.search_box.Text = "Search"
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(90, 241)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(127, 31)
        Me.search_btn.TabIndex = 5
        Me.search_btn.Text = "&Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        's_byno_txt
        '
        Me.s_byno_txt.ForeColor = System.Drawing.Color.Black
        Me.s_byno_txt.Location = New System.Drawing.Point(80, 193)
        Me.s_byno_txt.Name = "s_byno_txt"
        Me.s_byno_txt.Size = New System.Drawing.Size(182, 26)
        Me.s_byno_txt.TabIndex = 4
        '
        'or_lbl
        '
        Me.or_lbl.AutoSize = True
        Me.or_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.or_lbl.Location = New System.Drawing.Point(126, 121)
        Me.or_lbl.Name = "or_lbl"
        Me.or_lbl.Size = New System.Drawing.Size(33, 20)
        Me.or_lbl.TabIndex = 3
        Me.or_lbl.Text = "OR"
        '
        's_byno_lbl
        '
        Me.s_byno_lbl.AutoSize = True
        Me.s_byno_lbl.Location = New System.Drawing.Point(17, 154)
        Me.s_byno_lbl.Name = "s_byno_lbl"
        Me.s_byno_lbl.Size = New System.Drawing.Size(142, 20)
        Me.s_byno_lbl.TabIndex = 2
        Me.s_byno_lbl.Text = "Search By Number"
        '
        's_byname_txt
        '
        Me.s_byname_txt.ForeColor = System.Drawing.Color.Black
        Me.s_byname_txt.Location = New System.Drawing.Point(77, 76)
        Me.s_byname_txt.Name = "s_byname_txt"
        Me.s_byname_txt.Size = New System.Drawing.Size(186, 26)
        Me.s_byname_txt.TabIndex = 1
        '
        's_byname_lbl
        '
        Me.s_byname_lbl.AutoSize = True
        Me.s_byname_lbl.Location = New System.Drawing.Point(17, 40)
        Me.s_byname_lbl.Name = "s_byname_lbl"
        Me.s_byname_lbl.Size = New System.Drawing.Size(128, 20)
        Me.s_byname_lbl.TabIndex = 0
        Me.s_byname_lbl.Text = "Search By Name"
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(413, 344)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(127, 31)
        Me.exit_btn.TabIndex = 3
        Me.exit_btn.Text = "&Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 380)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.new_cntct_btn)
        Me.Controls.Add(Me.v_phnbook_btn)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.search_box.ResumeLayout(False)
        Me.search_box.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents v_phnbook_btn As System.Windows.Forms.Button
    Friend WithEvents new_cntct_btn As System.Windows.Forms.Button
    Friend WithEvents search_box As System.Windows.Forms.GroupBox
    Friend WithEvents s_byname_lbl As System.Windows.Forms.Label
    Friend WithEvents s_byno_txt As System.Windows.Forms.TextBox
    Friend WithEvents or_lbl As System.Windows.Forms.Label
    Friend WithEvents s_byno_lbl As System.Windows.Forms.Label
    Friend WithEvents s_byname_txt As System.Windows.Forms.TextBox
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As Button
End Class
