Imports System.Diagnostics.Eventing.Reader
Imports System.Data.SqlClient
Imports System.Xml

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from Login where username ='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'and usertype ='" & ComboBox1.SelectedItem & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("you are logged in as " + dt.Rows(0)(2))
            If (ComboBox1.SelectedIndex = 0) Then
                Dim a As New admin_control
                a.Show()
            Else
                Dim u As New Form3
                u.Show()
            End If
        Else
            MessageBox.Show("recheck the entered values")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class