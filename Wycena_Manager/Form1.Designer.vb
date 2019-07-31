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
        Me.NMLabel = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.LvwMain = New System.Windows.Forms.ListView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumberPyt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumberPyt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberPyt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NMLabel
        '
        Me.NMLabel.BackColor = System.Drawing.Color.White
        Me.NMLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NMLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMLabel.Location = New System.Drawing.Point(6, 20)
        Me.NMLabel.Name = "NMLabel"
        Me.NMLabel.Size = New System.Drawing.Size(314, 26)
        Me.NMLabel.TabIndex = 1
        Me.NMLabel.Text = "Nazwa modułu:"
        '
        'txtNM
        '
        Me.txtNM.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNM.Location = New System.Drawing.Point(326, 22)
        Me.txtNM.Name = "txtNM"
        Me.txtNM.Size = New System.Drawing.Size(181, 26)
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
        Me.ComBoxPyt2.Size = New System.Drawing.Size(188, 24)
        Me.ComBoxPyt2.TabIndex = 10
        Me.ComBoxPyt2.Tag = ""
        '
        'ComBoxPyt1
        '
        Me.ComBoxPyt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPyt1.Items.AddRange(New Object() {"Moduł klampienia", "Moduł pozycjonowania", "Moduł zabudowy"})
        Me.ComBoxPyt1.Location = New System.Drawing.Point(326, 58)
        Me.ComBoxPyt1.Name = "ComBoxPyt1"
        Me.ComBoxPyt1.Size = New System.Drawing.Size(188, 24)
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
        Me.ComBoxPyt3.Size = New System.Drawing.Size(188, 24)
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
        Me.ComBoxPyt4.Size = New System.Drawing.Size(188, 24)
        Me.ComBoxPyt4.TabIndex = 15
        Me.ComBoxPyt4.Tag = ""
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(780, 20)
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
        Me.NumberPyt2.Location = New System.Drawing.Point(6, 95)
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
        Me.BtnPrzelicz.Location = New System.Drawing.Point(673, 20)
        Me.BtnPrzelicz.Name = "BtnPrzelicz"
        Me.BtnPrzelicz.Size = New System.Drawing.Size(101, 44)
        Me.BtnPrzelicz.TabIndex = 18
        Me.BtnPrzelicz.Text = "Przelicz"
        Me.BtnPrzelicz.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NMLabel)
        Me.GroupBox1.Controls.Add(Me.txtNM)
        Me.GroupBox1.Controls.Add(Me.LbPyt1)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt2)
        Me.GroupBox1.Controls.Add(Me.LbPyt2)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt4)
        Me.GroupBox1.Controls.Add(Me.LbPyt4)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt1)
        Me.GroupBox1.Controls.Add(Me.ComBoxPyt3)
        Me.GroupBox1.Controls.Add(Me.LbPyt3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 200)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dane wejściowe"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumberPyt4)
        Me.GroupBox2.Controls.Add(Me.NumberPyt3)
        Me.GroupBox2.Controls.Add(Me.NumberPyt2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(538, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 199)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Przeliczniki"
        '
        'NumberPyt4
        '
        Me.NumberPyt4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberPyt4.InterceptArrowKeys = False
        Me.NumberPyt4.Location = New System.Drawing.Point(6, 162)
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
        Me.NumberPyt3.Location = New System.Drawing.Point(6, 128)
        Me.NumberPyt3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumberPyt3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberPyt3.Name = "NumberPyt3"
        Me.NumberPyt3.Size = New System.Drawing.Size(90, 22)
        Me.NumberPyt3.TabIndex = 18
        Me.NumberPyt3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Przelicznik"
        '
        'BtnTest
        '
        Me.BtnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnTest.Location = New System.Drawing.Point(674, 180)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(100, 40)
        Me.BtnTest.TabIndex = 21
        Me.BtnTest.Text = "Test"
        Me.BtnTest.UseVisualStyleBackColor = True
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
        Me.BtnClose.Location = New System.Drawing.Point(965, 181)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 44)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Zamknij"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnExport.Location = New System.Drawing.Point(780, 180)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 40)
        Me.btnExport.TabIndex = 24
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Wycena_Manager2.My.Resources.Resources.banda
        Me.PictureBox1.Location = New System.Drawing.Point(164, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 505)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LvwMain)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnPrzelicz)
        Me.Controls.Add(Me.BtnClear)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NMLabel As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents LvwMain As System.Windows.Forms.ListView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
