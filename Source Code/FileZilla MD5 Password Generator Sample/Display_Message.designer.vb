<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Message
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display_Message))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Message_Textbox = New System.Windows.Forms.TextBox
        Me.Countdown_Label = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Message_Textbox
        '
        Me.Message_Textbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Message_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Message_Textbox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Message_Textbox.Location = New System.Drawing.Point(12, 12)
        Me.Message_Textbox.Multiline = True
        Me.Message_Textbox.Name = "Message_Textbox"
        Me.Message_Textbox.ReadOnly = True
        Me.Message_Textbox.Size = New System.Drawing.Size(268, 205)
        Me.Message_Textbox.TabIndex = 0
        '
        'Countdown_Label
        '
        Me.Countdown_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Countdown_Label.AutoSize = True
        Me.Countdown_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Countdown_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Countdown_Label.Location = New System.Drawing.Point(168, 220)
        Me.Countdown_Label.Name = "Countdown_Label"
        Me.Countdown_Label.Size = New System.Drawing.Size(111, 13)
        Me.Countdown_Label.TabIndex = 1
        Me.Countdown_Label.Text = "Closing in 10 Seconds"
        '
        'Display_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(292, 242)
        Me.Controls.Add(Me.Countdown_Label)
        Me.Controls.Add(Me.Message_Textbox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Display_Message"
        Me.Text = "Application Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Countdown_Label As System.Windows.Forms.Label
    Friend WithEvents Message_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
