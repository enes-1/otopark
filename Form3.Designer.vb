<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dataView1 = New System.Data.DataView()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
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
        Me.ımageList1.Images.SetKeyName(5, "Comic Icons 3 files_edit.png")
        '
        'button7
        '
        Me.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button7.ImageIndex = 0
        Me.button7.ImageList = Me.ımageList1
        Me.button7.Location = New System.Drawing.Point(654, 214)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(91, 57)
        Me.button7.TabIndex = 38
        Me.button7.Text = "Programdan Çık"
        Me.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button6.ImageIndex = 5
        Me.button6.ImageList = Me.ımageList1
        Me.button6.Location = New System.Drawing.Point(543, 214)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(91, 57)
        Me.button6.TabIndex = 37
        Me.button6.Text = "Araç Giriş"
        Me.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button6.UseVisualStyleBackColor = True
        '
        'textBox9
        '
        Me.textBox9.Location = New System.Drawing.Point(266, 234)
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New System.Drawing.Size(42, 20)
        Me.textBox9.TabIndex = 36
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(359, 231)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(33, 23)
        Me.button5.TabIndex = 35
        Me.button5.Text = ">|"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(317, 231)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(33, 23)
        Me.button4.TabIndex = 34
        Me.button4.Text = ">"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(224, 231)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(33, 23)
        Me.button3.TabIndex = 33
        Me.button3.Text = "<"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(182, 231)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(33, 23)
        Me.button2.TabIndex = 32
        Me.button2.Text = "|<"
        Me.button2.UseVisualStyleBackColor = True
        '
        'dataGrid1
        '
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(28, 290)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(717, 279)
        Me.dataGrid1.TabIndex = 31
        '
        'button1
        '
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.button1.ImageIndex = 3
        Me.button1.ImageList = Me.ımageList1
        Me.button1.Location = New System.Drawing.Point(432, 214)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(91, 57)
        Me.button1.TabIndex = 30
        Me.button1.Text = "Araç Çıkış Yap"
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
        Me.groupBox2.Controls.Add(Me.textBox6)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.textBox7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.comboBox1)
        Me.groupBox2.Location = New System.Drawing.Point(367, 15)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(273, 175)
        Me.groupBox2.TabIndex = 28
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Araç Bilgileri"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(45, 148)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(46, 13)
        Me.label9.TabIndex = 16
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
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(130, 145)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 0
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
        Me.groupBox1.Location = New System.Drawing.Point(28, 15)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(278, 175)
        Me.groupBox1.TabIndex = 29
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 602)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.textBox9)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.dataGrid1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ımageList1 As System.Windows.Forms.ImageList
    Public WithEvents dataView1 As System.Data.DataView
    Private WithEvents button7 As System.Windows.Forms.Button
    Private WithEvents button6 As System.Windows.Forms.Button
    Private WithEvents textBox9 As System.Windows.Forms.TextBox
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Public WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents textBox8 As System.Windows.Forms.TextBox
    Private WithEvents textBox5 As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents textBox6 As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents textBox7 As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
