<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LokiwizFR
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BT_DESIMLOCK = New System.Windows.Forms.Button()
        Me.BT_SIMLOCK = New System.Windows.Forms.Button()
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        Me.BT_SCID = New System.Windows.Forms.Button()
        Me.LZ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_DESIMLOCK
        '
        Me.BT_DESIMLOCK.Location = New System.Drawing.Point(12, 72)
        Me.BT_DESIMLOCK.Name = "BT_DESIMLOCK"
        Me.BT_DESIMLOCK.Size = New System.Drawing.Size(93, 62)
        Me.BT_DESIMLOCK.TabIndex = 0
        Me.BT_DESIMLOCK.Text = "Desimlocker le Mobile"
        Me.BT_DESIMLOCK.UseVisualStyleBackColor = True
        '
        'BT_SIMLOCK
        '
        Me.BT_SIMLOCK.Location = New System.Drawing.Point(121, 72)
        Me.BT_SIMLOCK.Name = "BT_SIMLOCK"
        Me.BT_SIMLOCK.Size = New System.Drawing.Size(96, 62)
        Me.BT_SIMLOCK.TabIndex = 1
        Me.BT_SIMLOCK.Text = "Simlocker le mobile"
        Me.BT_SIMLOCK.UseVisualStyleBackColor = True
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Location = New System.Drawing.Point(251, 151)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.BT_CLOSE.TabIndex = 2
        Me.BT_CLOSE.Text = "Quitter"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'BT_SCID
        '
        Me.BT_SCID.Location = New System.Drawing.Point(233, 72)
        Me.BT_SCID.Name = "BT_SCID"
        Me.BT_SCID.Size = New System.Drawing.Size(93, 62)
        Me.BT_SCID.TabIndex = 3
        Me.BT_SCID.Text = "CID Unlock le mobile (SuperCID)"
        Me.BT_SCID.UseVisualStyleBackColor = True
        '
        'LZ
        '
        Me.LZ.AutoSize = True
        Me.LZ.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LZ.Location = New System.Drawing.Point(92, 9)
        Me.LZ.Name = "LZ"
        Me.LZ.Size = New System.Drawing.Size(115, 27)
        Me.LZ.TabIndex = 4
        Me.LZ.Text = "Lokiwiz 0.3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "By VPARRES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Appareils compatibles : SPV M3000, QTECK 9100 et HTC Wizard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(9, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Un très grand merci à : XDA-developpers," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SPV-developpers,""itsme"" et Machinagod"
        '
        'LokiwizFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 186)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LZ)
        Me.Controls.Add(Me.BT_SCID)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Controls.Add(Me.BT_SIMLOCK)
        Me.Controls.Add(Me.BT_DESIMLOCK)
        Me.Name = "LokiwizFR"
        Me.Text = ".mUn. Lokiwiz 0.3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_DESIMLOCK As System.Windows.Forms.Button
    Friend WithEvents BT_SIMLOCK As System.Windows.Forms.Button
    Friend WithEvents BT_CLOSE As System.Windows.Forms.Button
    Friend WithEvents BT_SCID As System.Windows.Forms.Button
    Friend WithEvents LZ As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
