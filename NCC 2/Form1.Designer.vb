<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Lbl_1 = New Label()
        Btn_1 = New Button()
        Btn_2 = New Button()
        SuspendLayout()
        ' 
        ' Lbl_1
        ' 
        Lbl_1.AutoSize = True
        Lbl_1.Font = New Font("Bradley Hand ITC", 40F)
        Lbl_1.ForeColor = SystemColors.ControlDarkDark
        Lbl_1.Location = New Point(101, 106)
        Lbl_1.Name = "Lbl_1"
        Lbl_1.Size = New Size(766, 84)
        Lbl_1.TabIndex = 0
        Lbl_1.Text = "Welcome to my First Page"
        ' 
        ' Btn_1
        ' 
        Btn_1.BackColor = SystemColors.InfoText
        Btn_1.Font = New Font("Sitka Subheading", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btn_1.ForeColor = SystemColors.MenuHighlight
        Btn_1.Location = New Point(101, 316)
        Btn_1.Name = "Btn_1"
        Btn_1.Size = New Size(251, 77)
        Btn_1.TabIndex = 1
        Btn_1.Text = "Sorting"
        Btn_1.UseVisualStyleBackColor = False
        ' 
        ' Btn_2
        ' 
        Btn_2.BackColor = SystemColors.ActiveCaptionText
        Btn_2.Font = New Font("Sitka Subheading", 19.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Btn_2.ForeColor = Color.Crimson
        Btn_2.Location = New Point(98, 422)
        Btn_2.Name = "Btn_2"
        Btn_2.Size = New Size(254, 77)
        Btn_2.TabIndex = 2
        Btn_2.Text = "Searching"
        Btn_2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(969, 637)
        Controls.Add(Btn_2)
        Controls.Add(Btn_1)
        Controls.Add(Lbl_1)
        Font = New Font("Segoe UI", 8F)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_1 As Label
    Friend WithEvents Btn_1 As Button
    Friend WithEvents Btn_2 As Button

End Class
