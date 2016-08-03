<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button7 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "Comic Icons 3 button_cancel.png")
        Me.ımageList1.Images.SetKeyName(1, "Comic Icons 3 button_ok.png")
        Me.ımageList1.Images.SetKeyName(2, "Comic Icons 3 floppy.png")
        Me.ımageList1.Images.SetKeyName(3, "Comic Icons 3 folder_downloads.png")
        Me.ımageList1.Images.SetKeyName(4, "Comic Icons 3 folder_find.png")
        '
        'button7
        '
        Me.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button7.ImageIndex = 0
        Me.button7.ImageList = Me.ımageList1
        Me.button7.Location = New System.Drawing.Point(570, 259)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(91, 57)
        Me.button7.TabIndex = 34
        Me.button7.Text = "Programdan Çık"
        Me.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button7.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button3.ImageIndex = 3
        Me.button3.ImageList = Me.ımageList1
        Me.button3.Location = New System.Drawing.Point(225, 259)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(91, 57)
        Me.button3.TabIndex = 33
        Me.button3.Text = "Araç Çıkış"
        Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button2.ImageIndex = 4
        Me.button2.ImageList = Me.ımageList1
        Me.button2.Location = New System.Drawing.Point(339, 259)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(91, 57)
        Me.button2.TabIndex = 32
        Me.button2.Text = "Araç Yerleri"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button1.ImageKey = "Comic Icons 3 floppy.png"
        Me.button1.ImageList = Me.ımageList1
        Me.button1.Location = New System.Drawing.Point(455, 259)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 57)
        Me.button1.TabIndex = 31
        Me.button1.Tag = "jkgkjuhbk"
        Me.button1.Text = "Araç Kaydet"
        Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.textBox8)
        Me.groupBox2.Controls.Add(Me.textBox5)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.comboBox1)
        Me.groupBox2.Controls.Add(Me.textBox6)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.textBox7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Location = New System.Drawing.Point(367, 16)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(273, 188)
        Me.groupBox2.TabIndex = 29
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Araç Bilgileri"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(45, 155)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(46, 13)
        Me.label9.TabIndex = 21
        Me.label9.Text = "Konumu"
        '
        'textBox8
        '
        Me.textBox8.Location = New System.Drawing.Point(130, 115)
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(100, 20)
        Me.textBox8.TabIndex = 7
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(130, 31)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(100, 20)
        Me.textBox5.TabIndex = 4
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(45, 118)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(33, 13)
        Me.label8.TabIndex = 15
        Me.label8.Text = "Renk"
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(130, 147)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 17
        '
        'textBox6
        '
        Me.textBox6.Location = New System.Drawing.Point(130, 59)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(100, 20)
        Me.textBox6.TabIndex = 5
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(45, 89)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(36, 13)
        Me.label7.TabIndex = 14
        Me.label7.Text = "Model"
        '
        'textBox7
        '
        Me.textBox7.Location = New System.Drawing.Point(130, 87)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(100, 20)
        Me.textBox7.TabIndex = 6
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(45, 60)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Marka"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(45, 31)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(51, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Plaka No"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.textBox3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.textBox4)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(28, 16)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(278, 188)
        Me.groupBox1.TabIndex = 30
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Müşteri Bilgileri"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(34, 116)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 13)
        Me.label4.TabIndex = 11
        Me.label4.Text = "Cep Telefonu"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(135, 29)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 0
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(135, 57)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(34, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Soyadı"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(135, 85)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 20)
        Me.textBox3.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(34, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(22, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Adı"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(135, 113)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 20)
        Me.textBox4.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(34, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Tc Kimlik No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "MUHAMMED ENES DOĞRU "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "EMRAH BİRGÜL"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 100)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HAZIRLAYANLAR ;"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "20031920025"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "20031920014"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 335)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ımageList1 As System.Windows.Forms.ImageList
    Private WithEvents button7 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents textBox8 As System.Windows.Forms.TextBox
    Private WithEvents textBox5 As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents textBox6 As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents textBox7 As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
End Class
