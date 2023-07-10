Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class Customer_details_Form7_
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    'validation of form 4'
    'customer name validation'
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " " OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'pincode validation'
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'phno validation'
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'phno. digit validation'
    Private Sub Textbox8_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox8.Validating
        Dim phoneNo As String = TextBox8.Text.Trim()

        If phoneNo.Length <> 10 Or Not IsNumeric(phoneNo) Then
            MessageBox.Show("Please enter a valid 10-digit phone number.")
            e.Cancel = True
        End If
    End Sub
    'aadhar validation'
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'aadhar digit validation'
    Private Sub Textbox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        Dim AdhNo As String = TextBox3.Text.Trim()

        If AdhNo.Length <> 12 Or Not IsNumeric(AdhNo) Then
            MessageBox.Show("Please enter a valid 12-digit Aadhar no.")
            e.Cancel = True
        End If
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Customer_details_Form7__Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from CustDet"
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
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into CustDet values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Text + "','" + RichTextBox1.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
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
        cmd.CommandText = "delete from CustDet where custcode ='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

End Class