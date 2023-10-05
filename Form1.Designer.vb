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
        btnClose = New Button()
        btnAddItems = New Button()
        lBoxItems = New ListBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(368, 379)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnAddItems
        ' 
        btnAddItems.Location = New Point(368, 324)
        btnAddItems.Name = "btnAddItems"
        btnAddItems.Size = New Size(94, 29)
        btnAddItems.TabIndex = 0
        btnAddItems.Text = "Add Items"
        btnAddItems.UseVisualStyleBackColor = True
        ' 
        ' lBoxItems
        ' 
        lBoxItems.FormattingEnabled = True
        lBoxItems.ItemHeight = 20
        lBoxItems.Location = New Point(303, 64)
        lBoxItems.Name = "lBoxItems"
        lBoxItems.Size = New Size(223, 224)
        lBoxItems.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lBoxItems)
        Controls.Add(btnAddItems)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Sumation Of Numbers using For Next Loop"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddItems As Button
    Friend WithEvents lBoxItems As ListBox
End Class
