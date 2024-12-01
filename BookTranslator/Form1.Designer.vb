<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtOpenAIKey = New System.Windows.Forms.TextBox()
        Me.lblOpenAI = New System.Windows.Forms.Label()
        Me.txtTranslateInstruct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAiService = New System.Windows.Forms.ComboBox()
        Me.txtAnthropicApiKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnApiKeyShow = New System.Windows.Forms.Button()
        Me.btnOpenAIKeyShow = New System.Windows.Forms.Button()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInputFile = New System.Windows.Forms.Button()
        Me.btnOutputFile = New System.Windows.Forms.Button()
        Me.txtOutputFile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.txtTranslate = New System.Windows.Forms.TextBox()
        Me.btnTranslateAll = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkBackupFile = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnValidateFile = New System.Windows.Forms.Button()
        Me.txtValidateFile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValidateInstruct = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRateAll = New System.Windows.Forms.Button()
        Me.btnTranslateLine = New System.Windows.Forms.Button()
        Me.btnRateLine = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOpenAIKey
        '
        Me.txtOpenAIKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpenAIKey.Location = New System.Drawing.Point(162, 108)
        Me.txtOpenAIKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOpenAIKey.Multiline = True
        Me.txtOpenAIKey.Name = "txtOpenAIKey"
        Me.txtOpenAIKey.Size = New System.Drawing.Size(1507, 32)
        Me.txtOpenAIKey.TabIndex = 39
        '
        'lblOpenAI
        '
        Me.lblOpenAI.AutoSize = True
        Me.lblOpenAI.Location = New System.Drawing.Point(19, 104)
        Me.lblOpenAI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpenAI.Name = "lblOpenAI"
        Me.lblOpenAI.Size = New System.Drawing.Size(122, 20)
        Me.lblOpenAI.TabIndex = 38
        Me.lblOpenAI.Text = "OpenAI API key"
        '
        'txtTranslateInstruct
        '
        Me.txtTranslateInstruct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTranslateInstruct.Location = New System.Drawing.Point(162, 156)
        Me.txtTranslateInstruct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTranslateInstruct.Multiline = True
        Me.txtTranslateInstruct.Name = "txtTranslateInstruct"
        Me.txtTranslateInstruct.Size = New System.Drawing.Size(649, 187)
        Me.txtTranslateInstruct.TabIndex = 37
        Me.txtTranslateInstruct.Text = "Translate text below to Russian. Do not provide any comments. Provide output text" &
    " only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{Text}"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Instructions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "AI Service"
        '
        'cbAiService
        '
        Me.cbAiService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAiService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAiService.FormattingEnabled = True
        Me.cbAiService.Items.AddRange(New Object() {"gpt-4o", "gpt-4o-mini", "claude-3-5-sonnet-20240620"})
        Me.cbAiService.Location = New System.Drawing.Point(162, 12)
        Me.cbAiService.Name = "cbAiService"
        Me.cbAiService.Size = New System.Drawing.Size(1558, 28)
        Me.cbAiService.TabIndex = 34
        '
        'txtAnthropicApiKey
        '
        Me.txtAnthropicApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnthropicApiKey.Location = New System.Drawing.Point(162, 58)
        Me.txtAnthropicApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnthropicApiKey.Multiline = True
        Me.txtAnthropicApiKey.Name = "txtAnthropicApiKey"
        Me.txtAnthropicApiKey.Size = New System.Drawing.Size(1507, 32)
        Me.txtAnthropicApiKey.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Anthropic API key"
        '
        'btnApiKeyShow
        '
        Me.btnApiKeyShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApiKeyShow.Location = New System.Drawing.Point(1677, 58)
        Me.btnApiKeyShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApiKeyShow.Name = "btnApiKeyShow"
        Me.btnApiKeyShow.Size = New System.Drawing.Size(42, 35)
        Me.btnApiKeyShow.TabIndex = 49
        Me.btnApiKeyShow.Text = "*"
        Me.btnApiKeyShow.UseVisualStyleBackColor = True
        '
        'btnOpenAIKeyShow
        '
        Me.btnOpenAIKeyShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenAIKeyShow.Location = New System.Drawing.Point(1677, 108)
        Me.btnOpenAIKeyShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenAIKeyShow.Name = "btnOpenAIKeyShow"
        Me.btnOpenAIKeyShow.Size = New System.Drawing.Size(42, 35)
        Me.btnOpenAIKeyShow.TabIndex = 50
        Me.btnOpenAIKeyShow.Text = "*"
        Me.btnOpenAIKeyShow.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInputFile.Location = New System.Drawing.Point(162, 353)
        Me.txtInputFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.Size = New System.Drawing.Size(1507, 26)
        Me.txtInputFile.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 359)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Input File Path"
        '
        'btnInputFile
        '
        Me.btnInputFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInputFile.Location = New System.Drawing.Point(1677, 349)
        Me.btnInputFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInputFile.Name = "btnInputFile"
        Me.btnInputFile.Size = New System.Drawing.Size(42, 35)
        Me.btnInputFile.TabIndex = 53
        Me.btnInputFile.Text = "..."
        Me.btnInputFile.UseVisualStyleBackColor = True
        '
        'btnOutputFile
        '
        Me.btnOutputFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutputFile.Location = New System.Drawing.Point(1677, 387)
        Me.btnOutputFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOutputFile.Name = "btnOutputFile"
        Me.btnOutputFile.Size = New System.Drawing.Size(42, 35)
        Me.btnOutputFile.TabIndex = 56
        Me.btnOutputFile.Text = "..."
        Me.btnOutputFile.UseVisualStyleBackColor = True
        '
        'txtOutputFile
        '
        Me.txtOutputFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputFile.Location = New System.Drawing.Point(162, 391)
        Me.txtOutputFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutputFile.Name = "txtOutputFile"
        Me.txtOutputFile.Size = New System.Drawing.Size(1507, 26)
        Me.txtOutputFile.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 397)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Output File Path"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 533)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1154, 366)
        Me.DataGridView1.TabIndex = 57
        '
        'txtLine
        '
        Me.txtLine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine.Location = New System.Drawing.Point(3, 3)
        Me.txtLine.Multiline = True
        Me.txtLine.Name = "txtLine"
        Me.txtLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLine.Size = New System.Drawing.Size(547, 177)
        Me.txtLine.TabIndex = 58
        '
        'txtTranslate
        '
        Me.txtTranslate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTranslate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranslate.Location = New System.Drawing.Point(3, 3)
        Me.txtTranslate.Multiline = True
        Me.txtTranslate.Name = "txtTranslate"
        Me.txtTranslate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTranslate.Size = New System.Drawing.Size(548, 173)
        Me.txtTranslate.TabIndex = 59
        '
        'btnTranslateAll
        '
        Me.btnTranslateAll.Location = New System.Drawing.Point(161, 474)
        Me.btnTranslateAll.Name = "btnTranslateAll"
        Me.btnTranslateAll.Size = New System.Drawing.Size(129, 48)
        Me.btnTranslateAll.TabIndex = 60
        Me.btnTranslateAll.Text = "Translate All"
        Me.btnTranslateAll.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1160, 533)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtLine)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTranslate)
        Me.SplitContainer1.Size = New System.Drawing.Size(559, 366)
        Me.SplitContainer1.SplitterDistance = 183
        Me.SplitContainer1.TabIndex = 61
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'chkBackupFile
        '
        Me.chkBackupFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBackupFile.AutoSize = True
        Me.chkBackupFile.Checked = True
        Me.chkBackupFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBackupFile.Location = New System.Drawing.Point(1387, 495)
        Me.chkBackupFile.Name = "chkBackupFile"
        Me.chkBackupFile.Size = New System.Drawing.Size(143, 24)
        Me.chkBackupFile.TabIndex = 62
        Me.chkBackupFile.Text = "Backup text file"
        Me.chkBackupFile.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(1536, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 37)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "Save Text File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnValidateFile
        '
        Me.btnValidateFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValidateFile.Location = New System.Drawing.Point(1677, 423)
        Me.btnValidateFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnValidateFile.Name = "btnValidateFile"
        Me.btnValidateFile.Size = New System.Drawing.Size(42, 35)
        Me.btnValidateFile.TabIndex = 66
        Me.btnValidateFile.Text = "..."
        Me.btnValidateFile.UseVisualStyleBackColor = True
        '
        'txtValidateFile
        '
        Me.txtValidateFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValidateFile.Location = New System.Drawing.Point(162, 427)
        Me.txtValidateFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValidateFile.Name = "txtValidateFile"
        Me.txtValidateFile.Size = New System.Drawing.Size(1507, 26)
        Me.txtValidateFile.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 433)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Validate File Path"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Translate"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(839, 159)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Validate"
        '
        'txtValidateInstruct
        '
        Me.txtValidateInstruct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValidateInstruct.Location = New System.Drawing.Point(937, 153)
        Me.txtValidateInstruct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValidateInstruct.Multiline = True
        Me.txtValidateInstruct.Name = "txtValidateInstruct"
        Me.txtValidateInstruct.Size = New System.Drawing.Size(782, 186)
        Me.txtValidateInstruct.TabIndex = 69
        Me.txtValidateInstruct.Text = "Rate the below English-to-Russian translation on scale from 1 to 100. Do not prov" &
    "ide any comments. Provide output number only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "English: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{Text}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Russian:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{T" &
    "ranslation}"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(839, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Instructions"
        '
        'btnRateAll
        '
        Me.btnRateAll.Location = New System.Drawing.Point(465, 474)
        Me.btnRateAll.Name = "btnRateAll"
        Me.btnRateAll.Size = New System.Drawing.Size(124, 48)
        Me.btnRateAll.TabIndex = 71
        Me.btnRateAll.Text = "Rate All"
        Me.btnRateAll.UseVisualStyleBackColor = True
        '
        'btnTranslateLine
        '
        Me.btnTranslateLine.Location = New System.Drawing.Point(305, 474)
        Me.btnTranslateLine.Name = "btnTranslateLine"
        Me.btnTranslateLine.Size = New System.Drawing.Size(135, 48)
        Me.btnTranslateLine.TabIndex = 72
        Me.btnTranslateLine.Text = "Translate Line"
        Me.btnTranslateLine.UseVisualStyleBackColor = True
        '
        'btnRateLine
        '
        Me.btnRateLine.Location = New System.Drawing.Point(595, 474)
        Me.btnRateLine.Name = "btnRateLine"
        Me.btnRateLine.Size = New System.Drawing.Size(136, 48)
        Me.btnRateLine.TabIndex = 73
        Me.btnRateLine.Text = "Rate Line"
        Me.btnRateLine.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(161, 458)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1509, 10)
        Me.ProgressBar1.TabIndex = 74
        Me.ProgressBar1.Visible = False
        '
        'lbCount
        '
        Me.lbCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCount.AutoSize = True
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCount.Location = New System.Drawing.Point(1016, 488)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(31, 32)
        Me.lbCount.TabIndex = 75
        Me.lbCount.Text = "0"
        Me.lbCount.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(1160, 499)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(68, 26)
        Me.txtRate.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1108, 502)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Rate"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(770, 474)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(136, 48)
        Me.btnReport.TabIndex = 78
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(911, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 48)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1732, 911)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRateLine)
        Me.Controls.Add(Me.btnTranslateLine)
        Me.Controls.Add(Me.btnRateAll)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtValidateInstruct)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnValidateFile)
        Me.Controls.Add(Me.txtValidateFile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkBackupFile)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnTranslateAll)
        Me.Controls.Add(Me.btnOutputFile)
        Me.Controls.Add(Me.txtOutputFile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnInputFile)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnOpenAIKeyShow)
        Me.Controls.Add(Me.btnApiKeyShow)
        Me.Controls.Add(Me.txtOpenAIKey)
        Me.Controls.Add(Me.lblOpenAI)
        Me.Controls.Add(Me.txtTranslateInstruct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAiService)
        Me.Controls.Add(Me.txtAnthropicApiKey)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Book Translator"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOpenAIKey As TextBox
    Friend WithEvents lblOpenAI As Label
    Friend WithEvents txtTranslateInstruct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAiService As ComboBox
    Friend WithEvents txtAnthropicApiKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnApiKeyShow As Button
    Friend WithEvents btnOpenAIKeyShow As Button
    Friend WithEvents txtInputFile As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnInputFile As Button
    Friend WithEvents btnOutputFile As Button
    Friend WithEvents txtOutputFile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtLine As TextBox
    Friend WithEvents txtTranslate As TextBox
    Friend WithEvents btnTranslateAll As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkBackupFile As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnValidateFile As Button
    Friend WithEvents txtValidateFile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValidateInstruct As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRateAll As Button
    Friend WithEvents btnTranslateLine As Button
    Friend WithEvents btnRateLine As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbCount As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents Button1 As Button
End Class
