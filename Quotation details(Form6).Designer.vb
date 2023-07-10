<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quotation_details_Form10_
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Quotation_details_Form10_))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        RichTextBox1 = New RichTextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        ComboBox3 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        Button7 = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(43, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 0
        Label1.Text = "Quotation no."' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Date"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(43, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 20)
        Label3.TabIndex = 2
        Label3.Text = "Customer Name"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 3
        Label4.Text = "Address"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 301)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 4
        Label5.Text = "Mobile No"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(43, 358)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 20)
        Label6.TabIndex = 5
        Label6.Text = "Vehicle Name"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(46, 414)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 20)
        Label7.TabIndex = 6
        Label7.Text = "Basic Price"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(46, 473)
        Label8.Name = "Label8"
        Label8.Size = New Size(205, 20)
        Label8.TabIndex = 7
        Label8.Text = "Additional Accessories"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(48, 527)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 20)
        Label9.TabIndex = 8
        Label9.Text = "Insurance"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(50, 578)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 9
        Label10.Text = "Road Tax"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(50, 637)
        Label11.Name = "Label11"
        Label11.Size = New Size(190, 20)
        Label11.TabIndex = 10
        Label11.Text = "Registration Charges"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(50, 686)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 20)
        Label12.TabIndex = 11
        Label12.Text = "Total Price"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(284, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 12
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(284, 136)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 14
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(284, 190)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(223, 81)
        RichTextBox1.TabIndex = 15
        RichTextBox1.Text = ""' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(284, 294)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(284, 411)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(177, 27)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(284, 466)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(177, 27)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(284, 520)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(177, 27)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(284, 571)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(177, 27)
        TextBox6.TabIndex = 20
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(284, 630)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(177, 27)
        TextBox7.TabIndex = 21
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(284, 683)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(177, 27)
        TextBox8.TabIndex = 22
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(284, 355)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(177, 28)
        ComboBox3.TabIndex = 23
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(538, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(454, 489)
        DataGridView1.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(29, 733)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 29)
        Button1.TabIndex = 25
        Button1.Text = "New"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonHighlight
        Button2.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(149, 733)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 29)
        Button2.TabIndex = 26
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonHighlight
        Button4.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(272, 733)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 29)
        Button4.TabIndex = 28
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonHighlight
        Button5.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(591, 591)
        Button5.Name = "Button5"
        Button5.Size = New Size(118, 29)
        Button5.TabIndex = 29
        Button5.Text = "List"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonHighlight
        Button6.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(841, 591)
        Button6.Name = "Button6"
        Button6.Size = New Size(118, 29)
        Button6.TabIndex = 30
        Button6.Text = "Close"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(284, 88)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(177, 27)
        DateTimePicker1.TabIndex = 31
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonHighlight
        Button3.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(512, 682)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 29)
        Button3.TabIndex = 32
        Button3.Text = "calculate"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.ButtonHighlight
        Button7.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.Location = New Point(398, 733)
        Button7.Name = "Button7"
        Button7.Size = New Size(118, 29)
        Button7.TabIndex = 33
        Button7.Text = "Print"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Quotation_details_Form10_
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1032, 777)
        Controls.Add(Button7)
        Controls.Add(Button3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox3)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Quotation_details_Form10_"
        Text = "Quotation_details_Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
