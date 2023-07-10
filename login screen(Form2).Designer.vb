<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(221, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 37)
        Label1.TabIndex = 0
        Label1.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(221, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 37)
        Label2.TabIndex = 1
        Label2.Text = "Password"' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(179, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 45)
        Button1.TabIndex = 2
        Button1.Text = "login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(517, 365)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 45)
        Button2.TabIndex = 3
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Location = New Point(446, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Info
        TextBox2.Location = New Point(446, 188)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(221, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 35)
        Label3.TabIndex = 6
        Label3.Text = "User Type"' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.Info
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"admin", "employee"})
        ComboBox1.Location = New Point(446, 274)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.HD_wallpaper_brickwork_texture_brick_background_grunge_brick_texture_brick_wall_texture_brown_bricks
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(804, 472)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
