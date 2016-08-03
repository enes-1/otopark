Imports System.Data.OleDb
Public Class Form1
    Public bag As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
    Public kmt As New OleDbCommand
    Public adtr As OleDbDataAdapter
    Public dtst As New DataSet
    Sub combo()
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select * from bos"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()
        While oku.Read()
            comboBox1.Items.Add(oku(0).ToString())
        End While
        bag.Close()
        oku.Dispose()
        comboBox1.Sorted = True
    End Sub
    Sub combo2()
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select * from dolu"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()
        While oku.Read()
            Form3.comboBox1.Items.Add(oku(0).ToString())
        End While
        bag.Close()
        oku.Dispose()
        comboBox1.Sorted = True
    End Sub
    Sub listelesene()
        dtst.Clear()
        bag.Open()
        adtr = New OleDbDataAdapter("select * From musbil", bag)
        adtr.Fill(dtst, "musbil")
        Form3.dataView1.Table = dtst.Tables(0)
        Form3.dataGrid1.DataSource = Form3.dataView1
        bag.Close()
        adtr.Dispose()
    End Sub
    Sub plakayaz()
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select * from musbil"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()
        While oku.Read()

            Select Case oku(8).ToString()
                Case "A1"
                    Form2.button1.Text = oku(4).ToString()
                    Form2.button1.BackColor = System.Drawing.Color.Red
                Case "A2"
                    Form2.button2.Text = oku(4).ToString()
                    Form2.button2.BackColor = System.Drawing.Color.Red
                Case "A3"
                    Form2.button3.Text = oku(4).ToString()
                    Form2.button3.BackColor = System.Drawing.Color.Red
                Case "A4"
                    Form2.button4.Text = oku(4).ToString()
                    Form2.button4.BackColor = System.Drawing.Color.Red
                Case "A5"
                    Form2.button5.Text = oku(4).ToString()
                    Form2.button5.BackColor = System.Drawing.Color.Red
                Case "B1"
                    Form2.button6.Text = oku(4).ToString()
                    Form2.button6.BackColor = System.Drawing.Color.Red
                Case "B2"
                    Form2.button7.Text = oku(4).ToString()
                    Form2.button7.BackColor = System.Drawing.Color.Red
                Case "B3"
                    Form2.button8.Text = oku(4).ToString()
                    Form2.button8.BackColor = System.Drawing.Color.Red
                Case "B4"
                    Form2.button9.Text = oku(4).ToString()
                    Form2.button9.BackColor = System.Drawing.Color.Red
                Case "B5"
                    Form2.button10.Text = oku(4).ToString()
                    Form2.button10.BackColor = System.Drawing.Color.Red
                Case "C1"
                    Form2.button11.Text = oku(4).ToString()
                    Form2.button11.BackColor = System.Drawing.Color.Red
                Case "C2"
                    Form2.button12.Text = oku(4).ToString()
                    Form2.button12.BackColor = System.Drawing.Color.Red
                Case "C3"
                    Form2.button13.Text = oku(4).ToString()
                    Form2.button13.BackColor = System.Drawing.Color.Red
                Case "C4"
                    Form2.button14.Text = oku(4).ToString()
                    Form2.button14.BackColor = System.Drawing.Color.Red
                Case "C5"
                    Form2.button15.Text = oku(4).ToString()
                    Form2.button15.BackColor = System.Drawing.Color.Red
                Case "D1"
                    Form2.button16.Text = oku(4).ToString()
                    Form2.button16.BackColor = System.Drawing.Color.Red
                Case "D2"
                    Form2.button17.Text = oku(4).ToString()
                    Form2.button17.BackColor = System.Drawing.Color.Red
                Case "D3"
                    Form2.button18.Text = oku(4).ToString()
                    Form2.button18.BackColor = System.Drawing.Color.Red
                Case "D4"
                    Form2.button19.Text = oku(4).ToString()
                    Form2.button19.BackColor = System.Drawing.Color.Red
                Case "D5"
                    Form2.button20.Text = oku(4).ToString()
                    Form2.button20.BackColor = System.Drawing.Color.Red
            End Select
        End While
        bag.Close()
        oku.Close()
    End Sub
    Sub plakasil()
        Select Case Form3.comboBox1.Text
            Case "A1"
                Form2.button1.Text = "A1"
                Form2.button1.BackColor = System.Drawing.Color.Green
            Case "A2"
                Form2.button2.Text = "A2"
                Form2.button2.BackColor = System.Drawing.Color.Green
            Case "A3"
                Form2.button3.Text = "A3"
                Form2.button3.BackColor = System.Drawing.Color.Green
            Case "A4"
                Form2.button4.Text = "A4"
                Form2.button4.BackColor = System.Drawing.Color.Green
            Case "A5"
                Form2.button5.Text = "A5"
                Form2.button5.BackColor = System.Drawing.Color.Green
            Case "B1"
                Form2.button6.Text = "B1"
                Form2.button6.BackColor = System.Drawing.Color.Green
            Case "B2"
                Form2.button7.Text = "B2"
                Form2.button7.BackColor = System.Drawing.Color.Green
            Case "B3"
                Form2.button8.Text = "B3"
                Form2.button8.BackColor = System.Drawing.Color.Green
            Case "B4"
                Form2.button9.Text = "B4"
                Form2.button9.BackColor = System.Drawing.Color.Green
            Case "B5"
                Form2.button10.Text = "B5"
                Form2.button10.BackColor = System.Drawing.Color.Green
            Case "C1"
                Form2.button11.Text = "C1"
                Form2.button11.BackColor = System.Drawing.Color.Green
            Case "C2"
                Form2.button12.Text = "C2"
                Form2.button12.BackColor = System.Drawing.Color.Green
            Case "C3"
                Form2.button13.Text = "C3"
                Form2.button13.BackColor = System.Drawing.Color.Green
            Case "C4"
                Form2.button14.Text = "C4"
                Form2.button14.BackColor = System.Drawing.Color.Green
            Case "C5"
                Form2.button15.Text = "C5"
                Form2.button15.BackColor = System.Drawing.Color.Green
            Case "D1"
                Form2.button16.Text = "D1"
                Form2.button16.BackColor = System.Drawing.Color.Green
            Case "D2"
                Form2.button17.Text = "D2"
                Form2.button17.BackColor = System.Drawing.Color.Green
            Case "D3"
                Form2.button18.Text = "D3"
                Form2.button18.BackColor = System.Drawing.Color.Green
            Case "D4"
                Form2.button19.Text = "D4"
                Form2.button19.BackColor = System.Drawing.Color.Green
            Case "D5"
                Form2.button20.Text = "D5"
                Form2.button20.BackColor = System.Drawing.Color.Green

        End Select
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combo()
        listelesene()
    End Sub
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If (textBox1.Text <> "" And textBox5.Text <> "" And comboBox1.Text <> "") Then
            bag.Open()
            kmt.Connection = bag
            kmt.CommandText = "INSERT INTO musbil(TcKimlik,Ad,Soyad,CepTel,PlakaNo,Marka,Model,Renk,Konumu) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox1.Text + "') "
            kmt.ExecuteNonQuery()
            kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') "
            kmt.ExecuteNonQuery()
            kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'"
            kmt.ExecuteNonQuery()
            kmt.Dispose()
            bag.Close()
            comboBox1.Items.Clear()
            comboBox1.Text = ""
            combo()
            plakayaz()
            listelesene()
            textBox1.Clear()
            textBox2.Clear()
            textBox3.Clear()
            textBox4.Clear()
            textBox5.Clear()
            textBox6.Clear()
            textBox7.Clear()
            textBox8.Clear()
            comboBox1.Items.Clear()
            MessageBox.Show("Kayıt işlemi tamamlandı ! ")
        Else
            MessageBox.Show("Boş alanları doldurunuz !!!")
        End If
    End Sub
    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button7.Click
        Application.Exit()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
