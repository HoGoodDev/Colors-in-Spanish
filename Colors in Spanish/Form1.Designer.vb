<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.lblSpanish = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBlue
        '
        Me.btnBlue.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlue.Location = New System.Drawing.Point(38, 54)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(130, 39)
        Me.btnBlue.TabIndex = 0
        Me.btnBlue.Text = "&Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(38, 327)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.Location = New System.Drawing.Point(38, 224)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(130, 39)
        Me.btnRed.TabIndex = 2
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnGreen
        '
        Me.btnGreen.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreen.Location = New System.Drawing.Point(38, 137)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(130, 39)
        Me.btnGreen.TabIndex = 3
        Me.btnGreen.Text = "&Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'lblSpanish
        '
        Me.lblSpanish.AutoSize = True
        Me.lblSpanish.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpanish.Location = New System.Drawing.Point(457, 180)
        Me.lblSpanish.Name = "lblSpanish"
        Me.lblSpanish.Size = New System.Drawing.Size(0, 37)
        Me.lblSpanish.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSpanish)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBlue)
        Me.Name = "frmMain"
        Me.Text = "H.Goodwill-Colors in Spanish"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBlue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents lblSpanish As Label
End Class
