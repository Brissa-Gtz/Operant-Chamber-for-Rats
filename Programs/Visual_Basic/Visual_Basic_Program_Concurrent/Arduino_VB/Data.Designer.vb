<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data))
        Me.label11 = New System.Windows.Forms.Label()
        Me.Port_CBox = New System.Windows.Forms.ComboBox()
        Me.Continue1btn = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Value_Box = New System.Windows.Forms.TextBox()
        Me.Reinforcers_Maxbox = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Schedule_Box = New System.Windows.Forms.ComboBox()
        Me.Session_Box = New System.Windows.Forms.TextBox()
        Me.Session_Time_Maxbox = New System.Windows.Forms.TextBox()
        Me.Subject_Box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Delay_Box = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Iterations_Box = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Iterations_Box_2 = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Delay_Box_2 = New System.Windows.Forms.TextBox()
        Me.Value_Box_2 = New System.Windows.Forms.TextBox()
        Me.Schedule_Box_2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(79, 416)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(62, 24)
        Me.label11.TabIndex = 38
        Me.label11.Text = "PORT"
        '
        'Port_CBox
        '
        Me.Port_CBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Port_CBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Port_CBox.ForeColor = System.Drawing.Color.Black
        Me.Port_CBox.FormattingEnabled = True
        Me.Port_CBox.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.Port_CBox.Location = New System.Drawing.Point(195, 413)
        Me.Port_CBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Port_CBox.Name = "Port_CBox"
        Me.Port_CBox.Size = New System.Drawing.Size(213, 27)
        Me.Port_CBox.TabIndex = 24
        '
        'Continue1btn
        '
        Me.Continue1btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Continue1btn.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Continue1btn.Location = New System.Drawing.Point(881, 488)
        Me.Continue1btn.Name = "Continue1btn"
        Me.Continue1btn.Size = New System.Drawing.Size(267, 168)
        Me.Continue1btn.TabIndex = 31
        Me.Continue1btn.Text = "CONTINUE"
        Me.Continue1btn.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.Lime
        Me.label10.ImageKey = "(ninguno)"
        Me.label10.Location = New System.Drawing.Point(200, -81)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(562, 55)
        Me.label10.TabIndex = 35
        Me.label10.Text = "Bienvenido al RATUINO"
        '
        'Value_Box
        '
        Me.Value_Box.BackColor = System.Drawing.Color.White
        Me.Value_Box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Value_Box.ForeColor = System.Drawing.Color.Black
        Me.Value_Box.Location = New System.Drawing.Point(747, 268)
        Me.Value_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Value_Box.Name = "Value_Box"
        Me.Value_Box.Size = New System.Drawing.Size(233, 26)
        Me.Value_Box.TabIndex = 28
        Me.Value_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reinforcers_Maxbox
        '
        Me.Reinforcers_Maxbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Reinforcers_Maxbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reinforcers_Maxbox.ForeColor = System.Drawing.Color.Black
        Me.Reinforcers_Maxbox.Location = New System.Drawing.Point(327, 581)
        Me.Reinforcers_Maxbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Reinforcers_Maxbox.Name = "Reinforcers_Maxbox"
        Me.Reinforcers_Maxbox.Size = New System.Drawing.Size(176, 26)
        Me.Reinforcers_Maxbox.TabIndex = 26
        Me.Reinforcers_Maxbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Courier New", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(796, 95)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(411, 34)
        Me.label9.TabIndex = 32
        Me.label9.Text = "REINFORCEMENT DELIVERY"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Courier New", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(66, 509)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(213, 34)
        Me.label8.TabIndex = 31
        Me.label8.Text = "END SESSION"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Courier New", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(179, 142)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(231, 34)
        Me.label7.TabIndex = 30
        Me.label7.Text = "SESSION DATA"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(79, 337)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(92, 24)
        Me.label6.TabIndex = 29
        Me.label6.Text = "SESSION"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(567, 217)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(111, 24)
        Me.label5.TabIndex = 28
        Me.label5.Text = "SCHEDULE"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(606, 267)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 24)
        Me.label2.TabIndex = 27
        Me.label2.Text = "VALUE"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(79, 255)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(94, 24)
        Me.label1.TabIndex = 26
        Me.label1.Text = "SUBJECT"
        '
        'Schedule_Box
        '
        Me.Schedule_Box.BackColor = System.Drawing.Color.White
        Me.Schedule_Box.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schedule_Box.ForeColor = System.Drawing.Color.Black
        Me.Schedule_Box.FormattingEnabled = True
        Me.Schedule_Box.Items.AddRange(New Object() {"FIXED RATIO", "VARIABLE RATIO", "FIXED INTERVAL", "VARIABLE INTERVAL", "FREE SESION"})
        Me.Schedule_Box.Location = New System.Drawing.Point(747, 212)
        Me.Schedule_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Schedule_Box.Name = "Schedule_Box"
        Me.Schedule_Box.Size = New System.Drawing.Size(233, 26)
        Me.Schedule_Box.TabIndex = 27
        '
        'Session_Box
        '
        Me.Session_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Session_Box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Session_Box.ForeColor = System.Drawing.Color.Black
        Me.Session_Box.Location = New System.Drawing.Point(195, 336)
        Me.Session_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Session_Box.Name = "Session_Box"
        Me.Session_Box.Size = New System.Drawing.Size(213, 26)
        Me.Session_Box.TabIndex = 23
        Me.Session_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Session_Time_Maxbox
        '
        Me.Session_Time_Maxbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Session_Time_Maxbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Session_Time_Maxbox.ForeColor = System.Drawing.Color.Black
        Me.Session_Time_Maxbox.Location = New System.Drawing.Point(74, 581)
        Me.Session_Time_Maxbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Session_Time_Maxbox.Name = "Session_Time_Maxbox"
        Me.Session_Time_Maxbox.Size = New System.Drawing.Size(176, 26)
        Me.Session_Time_Maxbox.TabIndex = 25
        Me.Session_Time_Maxbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Subject_Box
        '
        Me.Subject_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Subject_Box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_Box.ForeColor = System.Drawing.Color.Black
        Me.Subject_Box.Location = New System.Drawing.Point(195, 249)
        Me.Subject_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Subject_Box.Name = "Subject_Box"
        Me.Subject_Box.Size = New System.Drawing.Size(213, 26)
        Me.Subject_Box.TabIndex = 22
        Me.Subject_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.ImageKey = "(ninguno)"
        Me.Label3.Location = New System.Drawing.Point(308, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(513, 56)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Arduino_VB Interface"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(341, 612)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(145, 24)
        Me.label4.TabIndex = 41
        Me.label4.Text = "REINFORCERS"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(136, 612)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "TIME"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(564, 411)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 24)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "DELAY (ms)"
        Me.Label13.Visible = False
        '
        'Delay_Box
        '
        Me.Delay_Box.BackColor = System.Drawing.Color.White
        Me.Delay_Box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delay_Box.ForeColor = System.Drawing.Color.Black
        Me.Delay_Box.Location = New System.Drawing.Point(746, 412)
        Me.Delay_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Delay_Box.Name = "Delay_Box"
        Me.Delay_Box.Size = New System.Drawing.Size(233, 26)
        Me.Delay_Box.TabIndex = 30
        Me.Delay_Box.Text = "0"
        Me.Delay_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Delay_Box.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(747, 318)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(212, 17)
        Me.CheckBox2.TabIndex = 47
        Me.CheckBox2.Text = "Specify iterations for variable schedules"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(564, 362)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 24)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "ITERATIONS"
        Me.Label14.Visible = False
        '
        'Iterations_Box
        '
        Me.Iterations_Box.BackColor = System.Drawing.Color.White
        Me.Iterations_Box.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iterations_Box.ForeColor = System.Drawing.Color.Black
        Me.Iterations_Box.Location = New System.Drawing.Point(746, 363)
        Me.Iterations_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.Iterations_Box.Name = "Iterations_Box"
        Me.Iterations_Box.Size = New System.Drawing.Size(233, 26)
        Me.Iterations_Box.TabIndex = 29
        Me.Iterations_Box.Text = "0"
        Me.Iterations_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Iterations_Box.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1295, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(108, 26)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(798, 154)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 24)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "SCHEDULE 1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1058, 154)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 24)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "SCHEDULE 2"
        '
        'Iterations_Box_2
        '
        Me.Iterations_Box_2.BackColor = System.Drawing.Color.White
        Me.Iterations_Box_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iterations_Box_2.ForeColor = System.Drawing.Color.Black
        Me.Iterations_Box_2.Location = New System.Drawing.Point(1006, 363)
        Me.Iterations_Box_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Iterations_Box_2.Name = "Iterations_Box_2"
        Me.Iterations_Box_2.Size = New System.Drawing.Size(233, 26)
        Me.Iterations_Box_2.TabIndex = 54
        Me.Iterations_Box_2.Text = "0"
        Me.Iterations_Box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Iterations_Box_2.Visible = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(1007, 318)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(212, 17)
        Me.CheckBox4.TabIndex = 56
        Me.CheckBox4.Text = "Specify iterations for variable schedules"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Delay_Box_2
        '
        Me.Delay_Box_2.BackColor = System.Drawing.Color.White
        Me.Delay_Box_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delay_Box_2.ForeColor = System.Drawing.Color.Black
        Me.Delay_Box_2.Location = New System.Drawing.Point(1006, 412)
        Me.Delay_Box_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Delay_Box_2.Name = "Delay_Box_2"
        Me.Delay_Box_2.Size = New System.Drawing.Size(233, 26)
        Me.Delay_Box_2.TabIndex = 55
        Me.Delay_Box_2.Text = "0"
        Me.Delay_Box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Delay_Box_2.Visible = False
        '
        'Value_Box_2
        '
        Me.Value_Box_2.BackColor = System.Drawing.Color.White
        Me.Value_Box_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Value_Box_2.ForeColor = System.Drawing.Color.Black
        Me.Value_Box_2.Location = New System.Drawing.Point(1007, 268)
        Me.Value_Box_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Value_Box_2.Name = "Value_Box_2"
        Me.Value_Box_2.Size = New System.Drawing.Size(233, 26)
        Me.Value_Box_2.TabIndex = 53
        Me.Value_Box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Schedule_Box_2
        '
        Me.Schedule_Box_2.BackColor = System.Drawing.Color.White
        Me.Schedule_Box_2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Schedule_Box_2.ForeColor = System.Drawing.Color.Black
        Me.Schedule_Box_2.FormattingEnabled = True
        Me.Schedule_Box_2.Items.AddRange(New Object() {"FIXED RATIO", "VARIABLE RATIO", "FIXED INTERVAL", "VARIABLE INTERVAL", "FREE SESION"})
        Me.Schedule_Box_2.Location = New System.Drawing.Point(1007, 212)
        Me.Schedule_Box_2.Margin = New System.Windows.Forms.Padding(4)
        Me.Schedule_Box_2.Name = "Schedule_Box_2"
        Me.Schedule_Box_2.Size = New System.Drawing.Size(233, 26)
        Me.Schedule_Box_2.TabIndex = 52
        '
        'Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1295, 712)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Iterations_Box_2)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.Delay_Box_2)
        Me.Controls.Add(Me.Value_Box_2)
        Me.Controls.Add(Me.Schedule_Box_2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Iterations_Box)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Delay_Box)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Port_CBox)
        Me.Controls.Add(Me.Continue1btn)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Value_Box)
        Me.Controls.Add(Me.Reinforcers_Maxbox)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Schedule_Box)
        Me.Controls.Add(Me.Session_Box)
        Me.Controls.Add(Me.Session_Time_Maxbox)
        Me.Controls.Add(Me.Subject_Box)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents Continue1btn As System.Windows.Forms.Button
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Session_Box As System.Windows.Forms.TextBox
    Public WithEvents Port_CBox As System.Windows.Forms.ComboBox
    Public WithEvents Value_Box As System.Windows.Forms.TextBox
    Public WithEvents Reinforcers_Maxbox As System.Windows.Forms.TextBox
    Public WithEvents Schedule_Box As System.Windows.Forms.ComboBox
    Public WithEvents Session_Time_Maxbox As System.Windows.Forms.TextBox
    Public WithEvents Subject_Box As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Delay_Box As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Iterations_Box As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Iterations_Box_2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Private WithEvents Delay_Box_2 As System.Windows.Forms.TextBox
    Public WithEvents Value_Box_2 As System.Windows.Forms.TextBox
    Public WithEvents Schedule_Box_2 As System.Windows.Forms.ComboBox

End Class
