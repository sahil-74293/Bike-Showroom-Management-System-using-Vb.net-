<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        MenuStrip1 = New MenuStrip()
        CustomerDetailsToolStripMenuItem = New ToolStripMenuItem()
        BikeDetailsToolStripMenuItem = New ToolStripMenuItem()
        QuotationToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CustomerDetailsToolStripMenuItem, BikeDetailsToolStripMenuItem, QuotationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(998, 36)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' CustomerDetailsToolStripMenuItem
        ' 
        CustomerDetailsToolStripMenuItem.BackColor = SystemColors.AppWorkspace
        CustomerDetailsToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        CustomerDetailsToolStripMenuItem.Size = New Size(172, 32)
        CustomerDetailsToolStripMenuItem.Text = "Customer details"' 
        ' BikeDetailsToolStripMenuItem
        ' 
        BikeDetailsToolStripMenuItem.BackColor = SystemColors.GrayText
        BikeDetailsToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BikeDetailsToolStripMenuItem.Name = "BikeDetailsToolStripMenuItem"
        BikeDetailsToolStripMenuItem.Size = New Size(124, 32)
        BikeDetailsToolStripMenuItem.Text = "Bike details"' 
        ' QuotationToolStripMenuItem
        ' 
        QuotationToolStripMenuItem.BackColor = SystemColors.AppWorkspace
        QuotationToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        QuotationToolStripMenuItem.Size = New Size(116, 32)
        QuotationToolStripMenuItem.Text = "Quotation"' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.image_asset
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(998, 532)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Form3"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BikeDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As ToolStripMenuItem
End Class
