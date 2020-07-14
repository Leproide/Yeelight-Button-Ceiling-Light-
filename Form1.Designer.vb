<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_onoff = New System.Windows.Forms.Button()
        Me.btn_day = New System.Windows.Forms.Button()
        Me.btn_night = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_onoff
        '
        Me.btn_onoff.Location = New System.Drawing.Point(12, 12)
        Me.btn_onoff.Name = "btn_onoff"
        Me.btn_onoff.Size = New System.Drawing.Size(75, 23)
        Me.btn_onoff.TabIndex = 0
        Me.btn_onoff.Text = "ON/OFF"
        Me.btn_onoff.UseVisualStyleBackColor = True
        '
        'btn_day
        '
        Me.btn_day.Location = New System.Drawing.Point(93, 12)
        Me.btn_day.Name = "btn_day"
        Me.btn_day.Size = New System.Drawing.Size(75, 23)
        Me.btn_day.TabIndex = 1
        Me.btn_day.Text = "DAY"
        Me.btn_day.UseVisualStyleBackColor = True
        '
        'btn_night
        '
        Me.btn_night.Location = New System.Drawing.Point(174, 12)
        Me.btn_night.Name = "btn_night"
        Me.btn_night.Size = New System.Drawing.Size(75, 23)
        Me.btn_night.TabIndex = 2
        Me.btn_night.Text = "NIGHT"
        Me.btn_night.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(12, 41)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(118, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "INSERIRE IP"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(136, 41)
        Me.TrackBar2.Maximum = 6500
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(118, 45)
        Me.TrackBar2.TabIndex = 5
        Me.TrackBar2.Value = 6500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 88)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.btn_night)
        Me.Controls.Add(Me.btn_day)
        Me.Controls.Add(Me.btn_onoff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeelight_Button"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_onoff As Button
    Friend WithEvents btn_day As Button
    Friend WithEvents btn_night As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar2 As TrackBar
End Class
