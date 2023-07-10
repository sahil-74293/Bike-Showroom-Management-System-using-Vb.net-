Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Report_Quotation_report_Form13_

    'code to show the print preview'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler
        Dim printPreviewDlg As New PrintPreviewDialog()
        printPreviewDlg.Document = printDoc
        printPreviewDlg.ShowDialog()
    End Sub
    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim bitmap As New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        Dim graphics As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, e.PageBounds.Width - 20, e.PageBounds.Height - 20)
        graphics.DrawImage(bitmap, rect)
        e.HasMorePages = False
    End Sub

    'establishing connection and making changes using dvg'
    Private Sub Report_Quotation_report_Form13__Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection("Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True")
            Dim adapter As New SqlDataAdapter("SELECT * FROM QuotationDet", connection)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
        DataGridView1.ReadOnly = False
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True
    End Sub
    Private Sub dataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
            Dim dataRow As DataRow = dataTable.Rows(e.RowIndex)
            dataRow(row.Cells(e.ColumnIndex).OwningColumn.Name) = row.Cells(e.ColumnIndex).Value
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        Using connection As New SqlConnection("Data Source=AVITA-LIBER-V14;Initial Catalog=bike db;Integrated Security=True")
            Dim adapter As New SqlDataAdapter("SELECT * FROM QuotationDet", connection)
            Dim builder As New SqlCommandBuilder(adapter)
            adapter.Update(dataTable)
        End Using
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Report_Quotation_report_Form13__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class