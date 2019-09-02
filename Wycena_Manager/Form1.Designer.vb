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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LbNM = New System.Windows.Forms.Label()
        Me.txtNM = New System.Windows.Forms.TextBox()
        Me.LbPyt1 = New System.Windows.Forms.Label()
        Me.LbPyt2 = New System.Windows.Forms.Label()
        Me.ComBoxPyt2 = New System.Windows.Forms.ComboBox()
        Me.ComBoxPyt1 = New System.Windows.Forms.ComboBox()
        Me.LbPyt3 = New System.Windows.Forms.Label()
        Me.ComBoxPyt3 = New System.Windows.Forms.ComboBox()
        Me.LbPyt4 = New System.Windows.Forms.Label()
        Me.ComBoxPyt4 = New System.Windows.Forms.ComboBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.NumberPyt2 = New System.Windows.Forms.NumericUpDown()
        Me.BtnPrzelicz = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumberPyt4 = New System.Windows.Forms.NumericUpDown()
        Me.NumberPyt3 = New System.Windows.Forms.NumericUpDown()
        Me.LbPrzelicznik = New System.Windows.Forms.Label()
        Me.LvwMain = New System.Windows.Forms.ListView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbSuma = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvolvedInProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.NumberPyt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumberPyt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberPyt3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbNM
        '
        Me.LbNM.BackColor = System.Drawing.Color.White
        Me.LbNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbNM.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNM.Location = New System.Drawing.Point(6, 20)
        Me.LbNM.Name = "LbNM"
        Me.LbNM.Size = New System.Drawing.Size(314, 26)
        Me.LbNM.TabIndex = 1
        Me.LbNM.Text = "Nazwa modułu:"
        '
        'txtNM
        '
        Me.txtNM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNM.Location = New System.Drawing.Point(326, 22)
        Me.txtNM.Name = "txtNM"
        Me.txtNM.Size = New System.Drawing.Size(237, 26)
        Me.txtNM.TabIndex = 3
        '
        'LbPyt1
        '
        Me.LbPyt1.BackColor = System.Drawing.Color.White
        Me.LbPyt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPyt1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPyt1.Location = New System.Drawing.Point(6, 56)
        Me.LbPyt1.Name = "LbPyt1"
        Me.LbPyt1.Size = New System.Drawing.Size(314, 26)
        Me.LbPyt1.TabIndex = 4
        Me.LbPyt1.Text = "Rodzaj modułu"
        '
        'LbPyt2
        '
        Me.LbPyt2.BackColor = System.Drawing.Color.White
        Me.LbPyt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPyt2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPyt2.Location = New System.Drawing.Point(6, 92)
        Me.LbPyt2.Name = "LbPyt2"
        Me.LbPyt2.Size = New System.Drawing.Size(314, 26)
        Me.LbPyt2.TabIndex = 6
        Me.LbPyt2.Text = "Rozmiar siłownika"
        '
        'ComBoxPyt2
        '
        Me.ComBoxPyt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt2.Items.AddRange(New Object() {"Brak", "Mały [40]", "Średni [50-63]", "Duży [80]"})
        Me.ComBoxPyt2.Location = New System.Drawing.Point(326, 94)
        Me.ComBoxPyt2.Name = "ComBoxPyt2"
        Me.ComBoxPyt2.Size = New System.Drawing.Size(237, 24)
        Me.ComBoxPyt2.TabIndex = 10
        Me.ComBoxPyt2.Tag = ""
        '
        'ComBoxPyt1
        '
        Me.ComBoxPyt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt1.Items.AddRange(New Object() {"Moduł poz. z siłownikiem obr.", "Moduł pozycjonowania", "Moduł zabudowy"})
        Me.ComBoxPyt1.Location = New System.Drawing.Point(326, 58)
        Me.ComBoxPyt1.Name = "ComBoxPyt1"
        Me.ComBoxPyt1.Size = New System.Drawing.Size(237, 24)
        Me.ComBoxPyt1.TabIndex = 11
        Me.ComBoxPyt1.Tag = ""
        '
        'LbPyt3
        '
        Me.LbPyt3.BackColor = System.Drawing.Color.White
        Me.LbPyt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPyt3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPyt3.Location = New System.Drawing.Point(6, 125)
        Me.LbPyt3.Name = "LbPyt3"
        Me.LbPyt3.Size = New System.Drawing.Size(314, 26)
        Me.LbPyt3.TabIndex = 12
        Me.LbPyt3.Text = "Ilość kierunków pozycjonowania"
        '
        'ComBoxPyt3
        '
        Me.ComBoxPyt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt3.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComBoxPyt3.Location = New System.Drawing.Point(326, 127)
        Me.ComBoxPyt3.Name = "ComBoxPyt3"
        Me.ComBoxPyt3.Size = New System.Drawing.Size(237, 24)
        Me.ComBoxPyt3.TabIndex = 13
        Me.ComBoxPyt3.Tag = ""
        '
        'LbPyt4
        '
        Me.LbPyt4.BackColor = System.Drawing.Color.White
        Me.LbPyt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPyt4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPyt4.Location = New System.Drawing.Point(6, 160)
        Me.LbPyt4.Name = "LbPyt4"
        Me.LbPyt4.Size = New System.Drawing.Size(314, 26)
        Me.LbPyt4.TabIndex = 14
        Me.LbPyt4.Text = "Konsola, gł mocowanie?"
        '
        'ComBoxPyt4
        '
        Me.ComBoxPyt4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt4.Items.AddRange(New Object() {"Nie", "Tak"})
        Me.ComBoxPyt4.Location = New System.Drawing.Point(326, 162)
        Me.ComBoxPyt4.Name = "ComBoxPyt4"
        Me.ComBoxPyt4.Size = New System.Drawing.Size(237, 24)
        Me.ComBoxPyt4.TabIndex = 15
        Me.ComBoxPyt4.Tag = ""
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(806, 31)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(95, 44)
        Me.BtnClear.TabIndex = 16
        Me.BtnClear.Text = "Czyść"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'NumberPyt2
        '
        Me.NumberPyt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberPyt2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumberPyt2.InterceptArrowKeys = False
        Me.NumberPyt2.Location = New System.Drawing.Point(6, 88)
        Me.NumberPyt2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumberPyt2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberPyt2.Name = "NumberPyt2"
        Me.NumberPyt2.Size = New System.Drawing.Size(90, 22)
        Me.NumberPyt2.TabIndex = 17
        Me.NumberPyt2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnPrzelicz
        '
        Me.BtnPrzelicz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnPrzelicz.Location = New System.Drawing.Point(699, 31)
        Me.BtnPrzelicz.Name = "BtnPrzelicz"
        Me.BtnPrzelicz.Size = New System.Drawing.Size(101, 44)
        Me.BtnPrzelicz.TabIndex = 18
        Me.BtnPrzelicz.Text = "Przelicz"
        Me.BtnPrzelicz.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbNM)
        Me.GroupBox1.Controls.Add(Me.txtNM)
        Me.GroupBox1.Controls.Add(Me.LbPyt1)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt2)
        Me.GroupBox1.Controls.Add(Me.LbPyt2)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt4)
        Me.GroupBox1.Controls.Add(Me.LbPyt4)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt1)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt3)
        Me.GroupBox1.Controls.Add(Me.LbPyt3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 193)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dane wejściowe"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumberPyt4)
        Me.GroupBox2.Controls.Add(Me.NumberPyt3)
        Me.GroupBox2.Controls.Add(Me.NumberPyt2)
        Me.GroupBox2.Controls.Add(Me.LbPrzelicznik)
        Me.GroupBox2.Location = New System.Drawing.Point(589, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 192)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Przeliczniki"
        '
        'NumberPyt4
        '
        Me.NumberPyt4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberPyt4.InterceptArrowKeys = False
        Me.NumberPyt4.Location = New System.Drawing.Point(6, 155)
        Me.NumberPyt4.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumberPyt4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberPyt4.Name = "NumberPyt4"
        Me.NumberPyt4.Size = New System.Drawing.Size(90, 22)
        Me.NumberPyt4.TabIndex = 19
        Me.NumberPyt4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumberPyt3
        '
        Me.NumberPyt3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberPyt3.InterceptArrowKeys = False
        Me.NumberPyt3.Location = New System.Drawing.Point(6, 121)
        Me.NumberPyt3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumberPyt3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberPyt3.Name = "NumberPyt3"
        Me.NumberPyt3.Size = New System.Drawing.Size(90, 22)
        Me.NumberPyt3.TabIndex = 18
        Me.NumberPyt3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LbPrzelicznik
        '
        Me.LbPrzelicznik.BackColor = System.Drawing.Color.White
        Me.LbPrzelicznik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbPrzelicznik.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPrzelicznik.Location = New System.Drawing.Point(6, 57)
        Me.LbPrzelicznik.Name = "LbPrzelicznik"
        Me.LbPrzelicznik.Size = New System.Drawing.Size(90, 26)
        Me.LbPrzelicznik.TabIndex = 16
        Me.LbPrzelicznik.Text = "Mnożniki:"
        '
        'LvwMain
        '
        Me.LvwMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvwMain.Location = New System.Drawing.Point(18, 238)
        Me.LvwMain.MultiSelect = False
        Me.LvwMain.Name = "LvwMain"
        Me.LvwMain.Size = New System.Drawing.Size(1452, 255)
        Me.LvwMain.TabIndex = 22
        Me.LvwMain.UseCompatibleStateImageBehavior = False
        Me.LvwMain.View = System.Windows.Forms.View.Details
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1375, 187)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 44)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Zamknij"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExport.Location = New System.Drawing.Point(800, 177)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 40)
        Me.btnExport.TabIndex = 24
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'txtSuma
        '
        Me.txtSuma.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSuma.Location = New System.Drawing.Point(700, 113)
        Me.txtSuma.Multiline = True
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(201, 58)
        Me.txtSuma.TabIndex = 25
        Me.txtSuma.Tag = ""
        '
        'LbSuma
        '
        Me.LbSuma.BackColor = System.Drawing.Color.White
        Me.LbSuma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSuma.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LbSuma.Location = New System.Drawing.Point(700, 78)
        Me.LbSuma.Name = "LbSuma"
        Me.LbSuma.Size = New System.Drawing.Size(79, 26)
        Me.LbSuma.TabIndex = 26
        Me.LbSuma.Text = "SUMA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1482, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.EvolvedInProgressToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'EvolvedInProgressToolStripMenuItem
        '
        Me.EvolvedInProgressToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.EvolvedInProgressToolStripMenuItem.Name = "EvolvedInProgressToolStripMenuItem"
        Me.EvolvedInProgressToolStripMenuItem.Size = New System.Drawing.Size(233, 24)
        Me.EvolvedInProgressToolStripMenuItem.Text = "Evolved - Not provided"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(907, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 196)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "FOTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(699, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 44)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1482, 505)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbSuma)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LvwMain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnPrzelicz)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1500, 800)
        Me.MinimumSize = New System.Drawing.Size(1330, 550)
        Me.Name = "Form1"
        Me.Text = "Wycena_Manager_V1"
        CType(Me.NumberPyt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.NumberPyt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberPyt3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbNM As System.Windows.Forms.Label
    Friend WithEvents txtNM As System.Windows.Forms.TextBox
    Friend WithEvents LbPyt1 As System.Windows.Forms.Label
    Friend WithEvents LbPyt2 As System.Windows.Forms.Label
    Friend WithEvents ComBoxPyt2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComBoxPyt1 As System.Windows.Forms.ComboBox
    Friend WithEvents LbPyt3 As System.Windows.Forms.Label
    Friend WithEvents ComBoxPyt3 As System.Windows.Forms.ComboBox
    Friend WithEvents LbPyt4 As System.Windows.Forms.Label
    Friend WithEvents ComBoxPyt4 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents NumberPyt2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnPrzelicz As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumberPyt4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumberPyt3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LbPrzelicznik As System.Windows.Forms.Label
    Friend WithEvents LvwMain As System.Windows.Forms.ListView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents txtSuma As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LbSuma As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvolvedInProgressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
