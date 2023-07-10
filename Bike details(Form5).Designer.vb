<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bike_details_Form8_
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Bike_details_Form8_))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        DateTimePicker1 = New DateTimePicker()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(35, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 0
        Label1.Text = "vehicle model name"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(35, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 20)
        Label2.TabIndex = 1
        Label2.Text = "introducing date"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(35, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 2
        Label3.Text = "Basic price"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(35, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 3
        Label4.Text = "colors"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(35, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 4
        Label5.Text = "Facilities"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(35, 395)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 20)
        Label6.TabIndex = 5
        Label6.Text = "Engine type"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(35, 448)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 20)
        Label7.TabIndex = 6
        Label7.Text = "Milage"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(35, 504)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 20)
        Label8.TabIndex = 7
        Label8.Text = "Other details"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(238, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(238, 164)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 27)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(238, 215)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(216, 27)
        TextBox3.TabIndex = 11
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Single cylinder engine", "parallel twin engine", "V-twin engine", "Inline four engine", "Boxer engine"})
        ComboBox2.Location = New Point(236, 392)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(169, 28)
        ComboBox2.TabIndex = 13
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {" 45-50 Kmpl", " 50-55 Kmpl", " 55-60 Kmpl", " 60-65 Kmpl", " 65-70 Kmpl", " 70-80 Kmpl"})
        ComboBox3.Location = New Point(236, 445)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(169, 28)
        ComboBox3.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(539, 60)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(368, 413)
        DataGridView1.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(35, 607)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "New"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonHighlight
        Button2.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(154, 607)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonHighlight
        Button4.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(292, 607)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 20
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonHighlight
        Button5.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(579, 501)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 21
        Button5.Text = "List"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonHighlight
        Button6.Font = New Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(772, 501)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 22
        Button6.Text = "Close"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(236, 110)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(188, 27)
        DateTimePicker1.TabIndex = 23
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(238, 268)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(218, 96)
        RichTextBox1.TabIndex = 24
        RichTextBox1.Text = ""' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(236, 501)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(218, 93)
        RichTextBox2.TabIndex = 25
        RichTextBox2.Text = ""' 
        ' Bike_details_Form8_
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(951, 671)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Bike_details_Form8_"
        Text = "Bike_details_Form5"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
