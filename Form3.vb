Public Class Form3
    Sub texteyaz()
        textBox9.Text = (Me.BindingContext(Form1.dtst, "musbil").Position + 1) & " / " & Me.BindingContext(Form1.dtst, "musbil").Count
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.listelesene()
        Form1.combo2()
        textBox1.DataBindings.Add("Text", Form1.dtst, "musbil.TcKimlik")
        textBox2.DataBindings.Add("Text", Form1.dtst, "musbil.Ad")
        textBox3.DataBindings.Add("Text", Form1.dtst, "musbil.Soyad")
        textBox4.DataBindings.Add("Text", Form1.dtst, "musbil.CepTel")
        textBox5.DataBindings.Add("Text", Form1.dtst, "musbil.PlakaNo")
        textBox6.DataBindings.Add("Text", Form1.dtst, "musbil.Marka")
        textBox7.DataBindings.Add("Text", Form1.dtst, "musbil.Model")
        textBox8.DataBindings.Add("Text", Form1.dtst, "musbil.Renk")
        comboBox1.DataBindings.Add("Text", Form1.dtst, "musbil.Konumu")
        texteyaz()
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If (textBox1.Text <> "" And textBox5.Text <> "" And comboBox1.Text <> "") Then
            Dim cevap
            cevap = MsgBox("Kaydı silmek istediğinizden eminmisiniz ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "uyarı")
            If cevap = MsgBoxResult.Yes Then
                Form1.plakasil()
                Form1.bag.Open()
                Form1.kmt.Connection = Form1.bag
                Form1.kmt.CommandText = "DELETE from musbil WHERE TcKimlik='" + textBox1.Text + "'"
                Form1.kmt.ExecuteNonQuery()
                Form1.kmt.CommandText = "INSERT INTO bos(bosyerler) VALUES ('" + comboBox1.Text + "') "
                Form1.kmt.ExecuteNonQuery()
                Form1.kmt.CommandText = "DELETE from dolu WHERE doluyerler='" + comboBox1.Text + "'"
                Form1.kmt.ExecuteNonQuery()
                Form1.kmt.Dispose()
                Form1.bag.Close()
                comboBox1.Items.Clear()
                Form1.comboBox1.Items.Clear()
                comboBox1.Text = ""
                Form1.combo()
                Form1.combo2()
                Form1.dtst.Clear()
                Form1.listelesene()
            End If
        Else
            MessageBox.Show("Boş alanları doldurunuz !!!")
        End If
    End Sub
    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        Application.Exit()
    End Sub
    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
        Me.BindingContext(Form1.dtst, "musbil").Position = Me.BindingContext(Form1.dtst, "musbil").Count
        texteyaz()
    End Sub
    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Me.BindingContext(Form1.dtst, "musbil").Position += 1
        texteyaz()
    End Sub
    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Me.BindingContext(Form1.dtst, "musbil").Position -= 1
        texteyaz()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.BindingContext(Form1.dtst, "musbil").Position = 0
        texteyaz()
    End Sub
End Class