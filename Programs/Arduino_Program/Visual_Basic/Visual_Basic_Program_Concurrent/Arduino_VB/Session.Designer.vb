<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class session
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(session))
        Me.REFlbl = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Sesiónlbl = New System.Windows.Forms.Label()
        Me.portlbl = New System.Windows.Forms.Label()
        Me.Subjectlbl = New System.Windows.Forms.Label()
        Me.Reinfbtn = New System.Windows.Forms.Button()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.Datport = New System.Windows.Forms.Label()
        Me.lblbrut = New System.Windows.Forms.Label()
        Me.lblses = New System.Windows.Forms.Label()
        Me.lblport = New System.Windows.Forms.Label()
        Me.lblsuj = New System.Windows.Forms.Label()
        Me.RespTlbl = New System.Windows.Forms.Label()
        Me.TimeTlbl = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.DelayMarker = New System.Windows.Forms.PictureBox()
        Me.REFlbl2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RespTlbl2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DelayMarker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REFlbl
        '
        Me.REFlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REFlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REFlbl.Cursor = System.Windows.Forms.Cursors.No
        Me.REFlbl.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFlbl.Location = New System.Drawing.Point(52, 402)
        Me.REFlbl.Name = "REFlbl"
        Me.REFlbl.Size = New System.Drawing.Size(216, 58)
        Me.REFlbl.TabIndex = 75
        Me.REFlbl.Text = "0"
        Me.REFlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(108, 460)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 24)
        Me.label3.TabIndex = 74
        Me.label3.Text = "Reinforcers"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sesiónlbl
        '
        Me.Sesiónlbl.AutoSize = True
        Me.Sesiónlbl.BackColor = System.Drawing.Color.White
        Me.Sesiónlbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sesiónlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sesiónlbl.Location = New System.Drawing.Point(537, 129)
        Me.Sesiónlbl.Name = "Sesiónlbl"
        Me.Sesiónlbl.Size = New System.Drawing.Size(91, 24)
        Me.Sesiónlbl.TabIndex = 72
        Me.Sesiónlbl.Text = "Session"
        '
        'portlbl
        '
        Me.portlbl.AutoSize = True
        Me.portlbl.BackColor = System.Drawing.Color.White
        Me.portlbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.portlbl.Location = New System.Drawing.Point(829, 130)
        Me.portlbl.Name = "portlbl"
        Me.portlbl.Size = New System.Drawing.Size(58, 24)
        Me.portlbl.TabIndex = 71
        Me.portlbl.Text = "COM"
        '
        'Subjectlbl
        '
        Me.Subjectlbl.AutoSize = True
        Me.Subjectlbl.BackColor = System.Drawing.Color.White
        Me.Subjectlbl.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subjectlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Subjectlbl.Location = New System.Drawing.Point(197, 130)
        Me.Subjectlbl.Name = "Subjectlbl"
        Me.Subjectlbl.Size = New System.Drawing.Size(86, 24)
        Me.Subjectlbl.TabIndex = 70
        Me.Subjectlbl.Text = "Subject"
        '
        'Reinfbtn
        '
        Me.Reinfbtn.BackColor = System.Drawing.Color.LightBlue
        Me.Reinfbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reinfbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reinfbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reinfbtn.Location = New System.Drawing.Point(237, 581)
        Me.Reinfbtn.Name = "Reinfbtn"
        Me.Reinfbtn.Size = New System.Drawing.Size(147, 71)
        Me.Reinfbtn.TabIndex = 68
        Me.Reinfbtn.Text = "DELIVER REINFORCEMENT"
        Me.Reinfbtn.UseVisualStyleBackColor = False
        '
        'btnfin
        '
        Me.btnfin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfin.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(536, 551)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(254, 126)
        Me.btnfin.TabIndex = 67
        Me.btnfin.Text = "CLOSE"
        Me.btnfin.UseVisualStyleBackColor = True
        '
        'Datport
        '
        Me.Datport.AutoSize = True
        Me.Datport.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Datport.Location = New System.Drawing.Point(858, 223)
        Me.Datport.Name = "Datport"
        Me.Datport.Size = New System.Drawing.Size(38, 40)
        Me.Datport.TabIndex = 66
        Me.Datport.Text = "0"
        Me.Datport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbrut
        '
        Me.lblbrut.AutoSize = True
        Me.lblbrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbrut.Location = New System.Drawing.Point(822, 281)
        Me.lblbrut.Name = "lblbrut"
        Me.lblbrut.Size = New System.Drawing.Size(97, 18)
        Me.lblbrut.TabIndex = 65
        Me.lblbrut.Text = " Data String"
        '
        'lblses
        '
        Me.lblses.AutoSize = True
        Me.lblses.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblses.Location = New System.Drawing.Point(417, 131)
        Me.lblses.Name = "lblses"
        Me.lblses.Size = New System.Drawing.Size(101, 23)
        Me.lblses.TabIndex = 64
        Me.lblses.Text = "Session"
        '
        'lblport
        '
        Me.lblport.AutoSize = True
        Me.lblport.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblport.Location = New System.Drawing.Point(705, 135)
        Me.lblport.Name = "lblport"
        Me.lblport.Size = New System.Drawing.Size(62, 23)
        Me.lblport.TabIndex = 63
        Me.lblport.Text = "Port"
        '
        'lblsuj
        '
        Me.lblsuj.AutoSize = True
        Me.lblsuj.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuj.Location = New System.Drawing.Point(82, 131)
        Me.lblsuj.Name = "lblsuj"
        Me.lblsuj.Size = New System.Drawing.Size(101, 23)
        Me.lblsuj.TabIndex = 62
        Me.lblsuj.Text = "Subject"
        '
        'RespTlbl
        '
        Me.RespTlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RespTlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RespTlbl.Cursor = System.Windows.Forms.Cursors.No
        Me.RespTlbl.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespTlbl.Location = New System.Drawing.Point(52, 247)
        Me.RespTlbl.Name = "RespTlbl"
        Me.RespTlbl.Size = New System.Drawing.Size(216, 58)
        Me.RespTlbl.TabIndex = 60
        Me.RespTlbl.Text = "0"
        Me.RespTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeTlbl
        '
        Me.TimeTlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeTlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeTlbl.Cursor = System.Windows.Forms.Cursors.No
        Me.TimeTlbl.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTlbl.Location = New System.Drawing.Point(610, 441)
        Me.TimeTlbl.Name = "TimeTlbl"
        Me.TimeTlbl.Size = New System.Drawing.Size(219, 58)
        Me.TimeTlbl.TabIndex = 59
        Me.TimeTlbl.Text = "0"
        Me.TimeTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(93, 305)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(151, 24)
        Me.label4.TabIndex = 57
        Me.label4.Text = "Total Responses"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(681, 499)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(91, 24)
        Me.label2.TabIndex = 54
        Me.label2.Text = "Total time"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.label10.ImageKey = "(ninguno)"
        Me.label10.Location = New System.Drawing.Point(298, 38)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(395, 56)
        Me.label10.TabIndex = 53
        Me.label10.Text = "Current Session"
        '
        'DelayMarker
        '
        Me.DelayMarker.BackColor = System.Drawing.Color.Red
        Me.DelayMarker.Location = New System.Drawing.Point(641, 223)
        Me.DelayMarker.Name = "DelayMarker"
        Me.DelayMarker.Size = New System.Drawing.Size(103, 82)
        Me.DelayMarker.TabIndex = 77
        Me.DelayMarker.TabStop = False
        '
        'REFlbl2
        '
        Me.REFlbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.REFlbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.REFlbl2.Cursor = System.Windows.Forms.Cursors.No
        Me.REFlbl2.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFlbl2.Location = New System.Drawing.Point(302, 402)
        Me.REFlbl2.Name = "REFlbl2"
        Me.REFlbl2.Size = New System.Drawing.Size(216, 58)
        Me.REFlbl2.TabIndex = 81
        Me.REFlbl2.Text = "0"
        Me.REFlbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 460)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Reinforcers"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RespTlbl2
        '
        Me.RespTlbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RespTlbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RespTlbl2.Cursor = System.Windows.Forms.Cursors.No
        Me.RespTlbl2.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespTlbl2.Location = New System.Drawing.Point(302, 247)
        Me.RespTlbl2.Name = "RespTlbl2"
        Me.RespTlbl2.Size = New System.Drawing.Size(216, 58)
        Me.RespTlbl2.TabIndex = 79
        Me.RespTlbl2.Text = "0"
        Me.RespTlbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 305)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 24)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Total Responses"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'session
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(984, 712)
        Me.Controls.Add(Me.REFlbl2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RespTlbl2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DelayMarker)
        Me.Controls.Add(Me.REFlbl)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Sesiónlbl)
        Me.Controls.Add(Me.portlbl)
        Me.Controls.Add(Me.Subjectlbl)
        Me.Controls.Add(Me.Reinfbtn)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.Datport)
        Me.Controls.Add(Me.lblbrut)
        Me.Controls.Add(Me.lblses)
        Me.Controls.Add(Me.lblport)
        Me.Controls.Add(Me.lblsuj)
        Me.Controls.Add(Me.RespTlbl)
        Me.Controls.Add(Me.TimeTlbl)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "session"
        Me.Text = "Session"
        CType(Me.DelayMarker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lblbrut As System.Windows.Forms.Label
    Private WithEvents lblses As System.Windows.Forms.Label
    Private WithEvents lblport As System.Windows.Forms.Label
    Private WithEvents lblsuj As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Public WithEvents REFlbl As System.Windows.Forms.Label
    Public WithEvents Sesiónlbl As System.Windows.Forms.Label
    Public WithEvents portlbl As System.Windows.Forms.Label
    Public WithEvents Subjectlbl As System.Windows.Forms.Label
    Public WithEvents Datport As System.Windows.Forms.Label
    Public WithEvents RespTlbl As System.Windows.Forms.Label
    Public WithEvents TimeTlbl As System.Windows.Forms.Label
    Public WithEvents Reinfbtn As System.Windows.Forms.Button
    Public WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents DelayMarker As System.Windows.Forms.PictureBox
    Public WithEvents REFlbl2 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents RespTlbl2 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
End Class
