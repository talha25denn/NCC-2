<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSort
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
        Btn_8 = New Button()
        Btn_9 = New Button()
        Btn_10 = New Button()
        ListBox2 = New ListBox()
        SuspendLayout()
        ' 
        ' Btn_8
        ' 
        Btn_8.Location = New Point(75, 115)
        Btn_8.Name = "Btn_8"
        Btn_8.Size = New Size(260, 77)
        Btn_8.TabIndex = 0
        Btn_8.Text = "BubbleSort"
        Btn_8.UseVisualStyleBackColor = True
        ' 
        ' Btn_9
        ' 
        Btn_9.Location = New Point(71, 229)
        Btn_9.Name = "Btn_9"
        Btn_9.Size = New Size(264, 81)
        Btn_9.TabIndex = 1
        Btn_9.Text = "Insertion Sort"
        Btn_9.UseVisualStyleBackColor = True
        ' 
        ' Btn_10
        ' 
        Btn_10.Location = New Point(44, 586)
        Btn_10.Name = "Btn_10"
        Btn_10.Size = New Size(134, 50)
        Btn_10.TabIndex = 2
        Btn_10.Text = "Main Menu "
        Btn_10.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(499, 76)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(254, 524)
        ListBox2.TabIndex = 3
        ' 
        ' FrmSort
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 737)
        Controls.Add(ListBox2)
        Controls.Add(Btn_10)
        Controls.Add(Btn_9)
        Controls.Add(Btn_8)
        Name = "FrmSort"
        Text = "FrmSort"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_8 As Button
    Friend WithEvents Btn_9 As Button
    Friend WithEvents Btn_10 As Button
    Friend WithEvents ListBox2 As ListBox
End Class
