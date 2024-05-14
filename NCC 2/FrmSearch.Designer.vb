<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        ListBox1 = New ListBox()
        Btn_3 = New Button()
        TextBox1 = New TextBox()
        Btn_5 = New Button()
        Btn_6 = New Button()
        Btn_7 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(126, 49)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(254, 304)
        ListBox1.TabIndex = 0
        ' 
        ' Btn_3
        ' 
        Btn_3.Location = New Point(538, 49)
        Btn_3.Name = "Btn_3"
        Btn_3.Size = New Size(151, 192)
        Btn_3.TabIndex = 1
        Btn_3.Text = "Data from external file"
        Btn_3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20F)
        TextBox1.Location = New Point(468, 301)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(378, 52)
        TextBox1.TabIndex = 3
        ' 
        ' Btn_5
        ' 
        Btn_5.Location = New Point(396, 544)
        Btn_5.Name = "Btn_5"
        Btn_5.Size = New Size(323, 71)
        Btn_5.TabIndex = 5
        Btn_5.Text = "Linear Search from user data "
        Btn_5.UseVisualStyleBackColor = True
        ' 
        ' Btn_6
        ' 
        Btn_6.Location = New Point(395, 427)
        Btn_6.Name = "Btn_6"
        Btn_6.Size = New Size(324, 73)
        Btn_6.TabIndex = 6
        Btn_6.Text = "Binary Search from User Data"
        Btn_6.UseVisualStyleBackColor = True
        ' 
        ' Btn_7
        ' 
        Btn_7.Location = New Point(12, 563)
        Btn_7.Name = "Btn_7"
        Btn_7.Size = New Size(129, 52)
        Btn_7.TabIndex = 7
        Btn_7.Text = "Main Menu"
        Btn_7.UseVisualStyleBackColor = True
        ' 
        ' FrmSearch
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 642)
        Controls.Add(Btn_7)
        Controls.Add(Btn_6)
        Controls.Add(Btn_5)
        Controls.Add(TextBox1)
        Controls.Add(Btn_3)
        Controls.Add(ListBox1)
        Name = "FrmSearch"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn_3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_5 As Button
    Friend WithEvents Btn_6 As Button
    Friend WithEvents Btn_7 As Button
End Class
