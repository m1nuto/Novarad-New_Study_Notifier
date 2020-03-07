<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudyNotifier
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStudyNotifier))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtMRN = New System.Windows.Forms.TextBox
        Me.BtnToggle = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCopyMRN = New System.Windows.Forms.Button
        Me.BtnTop = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'TxtMRN
        '
        Me.TxtMRN.BackColor = System.Drawing.Color.Black
        Me.TxtMRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtMRN.Location = New System.Drawing.Point(86, 43)
        Me.TxtMRN.Name = "TxtMRN"
        Me.TxtMRN.Size = New System.Drawing.Size(166, 20)
        Me.TxtMRN.TabIndex = 0
        '
        'BtnToggle
        '
        Me.BtnToggle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToggle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnToggle.Location = New System.Drawing.Point(12, 6)
        Me.BtnToggle.Name = "BtnToggle"
        Me.BtnToggle.Size = New System.Drawing.Size(68, 31)
        Me.BtnToggle.TabIndex = 1
        Me.BtnToggle.Text = "Stop"
        Me.BtnToggle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recent MRN"
        '
        'BtnCopyMRN
        '
        Me.BtnCopyMRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopyMRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCopyMRN.Location = New System.Drawing.Point(184, 6)
        Me.BtnCopyMRN.Name = "BtnCopyMRN"
        Me.BtnCopyMRN.Size = New System.Drawing.Size(68, 31)
        Me.BtnCopyMRN.TabIndex = 3
        Me.BtnCopyMRN.Text = "Copy MRN"
        Me.BtnCopyMRN.UseVisualStyleBackColor = True
        '
        'BtnTop
        '
        Me.BtnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTop.Location = New System.Drawing.Point(98, 6)
        Me.BtnTop.Name = "BtnTop"
        Me.BtnTop.Size = New System.Drawing.Size(68, 31)
        Me.BtnTop.TabIndex = 4
        Me.BtnTop.Text = "Not Top"
        Me.BtnTop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(264, 71)
        Me.Controls.Add(Me.BtnTop)
        Me.Controls.Add(Me.BtnCopyMRN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnToggle)
        Me.Controls.Add(Me.TxtMRN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "New Case Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TxtMRN As System.Windows.Forms.TextBox
    Friend WithEvents BtnToggle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCopyMRN As System.Windows.Forms.Button
    Friend WithEvents BtnTop As System.Windows.Forms.Button

End Class
