Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Quotation_details_Form10_
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    'quotation no. validation'
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'Basic price Validation'
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'Additional accessories validation'
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'insurance accessories validation'
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'road tax validation'
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    'registration charge validation'
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private quoteNumber As Integer

    Private Sub Quotation_details_Form10__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True"

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()

        'code for displaying combobox list'
        Dim sqlQuery As String = "select custname from CustDet"
        Dim cmd As New SqlCommand(sqlQuery, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            ComboBox2.Items.Add(reader("custname").ToString())
        End While
        reader.Close()

        'displaying the vehicle name list in combobox 3'
        Dim Query As String = "select modelname from BikeDet"
        Dim command As New SqlCommand(Query, con)
        Dim red As SqlDataReader = command.ExecuteReader()
        While red.Read()
            ComboBox3.Items.Add(red("modelname").ToString())
        End While
        red.Close()

    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from QuotationDet"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        ComboBox2.Text = ""
        RichTextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox3.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into QuotationDet values('" + TextBox1.Text + "','" + DateTimePicker1.Text + "','" + ComboBox2.Text + "','" + RichTextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox3.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')"
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
        cmd.CommandText = "delete from QuotationDet where QuotNo ='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim connString As String = "Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True"
        Dim conn As New SqlConnection(connString)

        Dim cmd As New SqlCommand("SELECT address, phno FROM CustDet WHERE custname = @custname", conn)

        cmd.Parameters.AddWithValue("@custname", ComboBox2.SelectedItem)

        conn.Open()

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            RichTextBox1.Text = reader("address")
            TextBox2.Text = reader("phno")
        End If

        reader.Close()
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'displaying the sum of textboxes in total price'
        Dim sum As Integer = 0
        sum += Integer.Parse(TextBox3.Text)
        sum += Integer.Parse(TextBox4.Text)
        sum += Integer.Parse(TextBox5.Text)
        sum += Integer.Parse(TextBox6.Text)
        sum += Integer.Parse(TextBox7.Text)
        TextBox8.Text = sum.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Set the PrintPreviewDialog's Document property to the PrintDocument
        PrintPreviewDialog1.Document = PrintDocument1

        ' Show the PrintPreviewDialog
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create a Bitmap of the form's current state
        Dim formBitmap As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(formBitmap, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Draw the Bitmap onto the PrintDocument'
        e.Graphics.DrawImage(formBitmap, 0, 0)
    End Sub
    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
        ' Hide the buttons and DataGridView on the PrintPreviewDialog
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        DataGridView1.Visible = False
    End Sub
End Class
