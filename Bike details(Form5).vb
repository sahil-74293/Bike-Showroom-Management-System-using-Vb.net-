Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Bike_details_Form8_
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    'basic price validation'
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'color validation'
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = ","c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Bike_details_Form8__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub
    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from BikeDet"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        RichTextBox1.Text = ""
        TextBox3.Text = ""
        RichTextBox2.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into BikeDet values('" + TextBox1.Text + "','" + DateTimePicker1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RichTextBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + RichTextBox2.Text + "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("record inserted successfully")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from BikeDet where modelname ='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class