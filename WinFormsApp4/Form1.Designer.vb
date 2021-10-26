<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Caminho = New System.Windows.Forms.Label()
        Me.TextPath = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TextUri = New System.Windows.Forms.TextBox()
        Me.lblUri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Caminho
        '
        Me.Caminho.AutoSize = True
        Me.Caminho.Location = New System.Drawing.Point(12, 65)
        Me.Caminho.Name = "Caminho"
        Me.Caminho.Size = New System.Drawing.Size(56, 15)
        Me.Caminho.TabIndex = 0
        Me.Caminho.Text = "Diretorio:"
        '
        'TextPath
        '
        Me.TextPath.Location = New System.Drawing.Point(12, 83)
        Me.TextPath.Name = "TextPath"
        Me.TextPath.Size = New System.Drawing.Size(776, 23)
        Me.TextPath.TabIndex = 1
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(337, 262)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(123, 78)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'TextUri
        '
        Me.TextUri.Location = New System.Drawing.Point(12, 146)
        Me.TextUri.Name = "TextUri"
        Me.TextUri.Size = New System.Drawing.Size(776, 23)
        Me.TextUri.TabIndex = 4
        '
        'lblUri
        '
        Me.lblUri.AutoSize = True
        Me.lblUri.Location = New System.Drawing.Point(12, 128)
        Me.lblUri.Name = "lblUri"
        Me.lblUri.Size = New System.Drawing.Size(28, 15)
        Me.lblUri.TabIndex = 3
        Me.lblUri.Text = "URI:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextUri)
        Me.Controls.Add(Me.lblUri)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TextPath)
        Me.Controls.Add(Me.Caminho)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Caminho As Label
    Friend WithEvents TextPath As TextBox
    Friend WithEvents BtnOk As Button
    Friend WithEvents TextUri As TextBox
    Friend WithEvents lblUri As Label
End Class
