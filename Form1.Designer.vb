﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.lb_tot = New System.Windows.Forms.Label()
        Me.lbl_2_pk = New System.Windows.Forms.Label()
        Me.lbl_5_pk = New System.Windows.Forms.Label()
        Me.lbl_12_pk = New System.Windows.Forms.Label()
        Me.TxtTotQuant = New System.Windows.Forms.TextBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.Txt2Pack = New System.Windows.Forms.TextBox()
        Me.Txt5Pack = New System.Windows.Forms.TextBox()
        Me.Txt12Pack = New System.Windows.Forms.TextBox()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_tot
        '
        Me.lb_tot.AutoSize = True
        Me.lb_tot.Location = New System.Drawing.Point(37, 173)
        Me.lb_tot.Name = "lb_tot"
        Me.lb_tot.Size = New System.Drawing.Size(39, 13)
        Me.lb_tot.TabIndex = 21
        Me.lb_tot.Text = "Totals:"
        '
        'lbl_2_pk
        '
        Me.lbl_2_pk.AutoSize = True
        Me.lbl_2_pk.Location = New System.Drawing.Point(37, 129)
        Me.lbl_2_pk.Name = "lbl_2_pk"
        Me.lbl_2_pk.Size = New System.Drawing.Size(44, 13)
        Me.lbl_2_pk.TabIndex = 20
        Me.lbl_2_pk.Text = "2 Pack:"
        '
        'lbl_5_pk
        '
        Me.lbl_5_pk.AutoSize = True
        Me.lbl_5_pk.Location = New System.Drawing.Point(37, 85)
        Me.lbl_5_pk.Name = "lbl_5_pk"
        Me.lbl_5_pk.Size = New System.Drawing.Size(44, 13)
        Me.lbl_5_pk.TabIndex = 19
        Me.lbl_5_pk.Text = "5 Pack:"
        '
        'lbl_12_pk
        '
        Me.lbl_12_pk.AutoSize = True
        Me.lbl_12_pk.Location = New System.Drawing.Point(37, 38)
        Me.lbl_12_pk.Name = "lbl_12_pk"
        Me.lbl_12_pk.Size = New System.Drawing.Size(50, 13)
        Me.lbl_12_pk.TabIndex = 18
        Me.lbl_12_pk.Text = "12 Pack:"
        '
        'TxtTotQuant
        '
        Me.TxtTotQuant.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TxtTotQuant.Location = New System.Drawing.Point(263, 171)
        Me.TxtTotQuant.Name = "TxtTotQuant"
        Me.TxtTotQuant.ReadOnly = True
        Me.TxtTotQuant.Size = New System.Drawing.Size(66, 20)
        Me.TxtTotQuant.TabIndex = 17
        '
        'TxtTot
        '
        Me.TxtTot.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTot.Location = New System.Drawing.Point(108, 170)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.ReadOnly = True
        Me.TxtTot.Size = New System.Drawing.Size(88, 20)
        Me.TxtTot.TabIndex = 16
        '
        'Txt2Pack
        '
        Me.Txt2Pack.Location = New System.Drawing.Point(108, 126)
        Me.Txt2Pack.Name = "Txt2Pack"
        Me.Txt2Pack.Size = New System.Drawing.Size(79, 20)
        Me.Txt2Pack.TabIndex = 15
        '
        'Txt5Pack
        '
        Me.Txt5Pack.Location = New System.Drawing.Point(108, 82)
        Me.Txt5Pack.Name = "Txt5Pack"
        Me.Txt5Pack.Size = New System.Drawing.Size(79, 20)
        Me.Txt5Pack.TabIndex = 14
        '
        'Txt12Pack
        '
        Me.Txt12Pack.AcceptsReturn = True
        Me.Txt12Pack.AccessibleRole = System.Windows.Forms.AccessibleRole.HotkeyField
        Me.Txt12Pack.Location = New System.Drawing.Point(108, 38)
        Me.Txt12Pack.Name = "Txt12Pack"
        Me.Txt12Pack.Size = New System.Drawing.Size(79, 20)
        Me.Txt12Pack.TabIndex = 13
        '
        'BtnExt
        '
        Me.BtnExt.BackColor = System.Drawing.Color.LightCoral
        Me.BtnExt.Location = New System.Drawing.Point(221, 216)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(107, 43)
        Me.BtnExt.TabIndex = 12
        Me.BtnExt.Text = "Exit"
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCalc.Location = New System.Drawing.Point(33, 216)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(107, 43)
        Me.BtnCalc.TabIndex = 11
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Quantity:"
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.BtnExt
        Me.ClientSize = New System.Drawing.Size(352, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_tot)
        Me.Controls.Add(Me.lbl_2_pk)
        Me.Controls.Add(Me.lbl_5_pk)
        Me.Controls.Add(Me.lbl_12_pk)
        Me.Controls.Add(Me.TxtTotQuant)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.Txt2Pack)
        Me.Controls.Add(Me.Txt5Pack)
        Me.Controls.Add(Me.Txt12Pack)
        Me.Controls.Add(Me.BtnExt)
        Me.Controls.Add(Me.BtnCalc)
        Me.Name = "FrmMain"
        Me.Text = "Chopkins Toys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_tot As Label
    Friend WithEvents lbl_2_pk As Label
    Friend WithEvents lbl_5_pk As Label
    Friend WithEvents lbl_12_pk As Label
    Friend WithEvents TxtTotQuant As TextBox
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents Txt2Pack As TextBox
    Friend WithEvents Txt5Pack As TextBox
    Friend WithEvents Txt12Pack As TextBox
    Friend WithEvents BtnExt As Button
    Friend WithEvents BtnCalc As Button
    Friend WithEvents Label1 As Label
End Class
