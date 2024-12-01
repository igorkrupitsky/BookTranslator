Imports System.IO
Imports System.Net

Public Class Form1
    Dim oAppSetting As New AppSetting()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oAppSetting.LoadData()
        SetComboBox(cbAiService, oAppSetting.GetValue("AiService"))
        txtAnthropicApiKey.Text = oAppSetting.GetValue("AnthropicApiKey")
        txtOpenAIKey.Text = oAppSetting.GetValue("OpenAIKey")

        txtInputFile.Text = oAppSetting.GetValue("InputFile")
        txtOutputFile.Text = oAppSetting.GetValue("OutputFile")
        txtValidateFile.Text = oAppSetting.GetValue("ValidateFile")

        txtTranslateInstruct.Text = oAppSetting.GetValue("TranslateInstruct", txtTranslateInstruct.Text)
        txtValidateInstruct.Text = oAppSetting.GetValue("ValidateInstruct", txtValidateInstruct.Text)

        If cbAiService.SelectedIndex = -1 Then
            cbAiService.SelectedIndex = 0
        End If

        If txtAnthropicApiKey.Text <> "" Then
            txtAnthropicApiKey.PasswordChar = "*"
        End If

        If txtOpenAIKey.Text <> "" Then
            txtOpenAIKey.PasswordChar = "*"
        End If

        If txtInputFile.Text <> "" Then
            SetOutputFilePath()
            UpdateFileGrid()
        End If

        ToolTip1.AutoPopDelay = 32767
        ToolTip1.SetToolTip(btnTranslateAll, "This action will translate all paragraphs that were not translated yet.  " &
                                             "All translations will be saved at the end of this process.")
        ToolTip1.SetToolTip(btnRateAll, "This action will rate the translations of all paragraphs that were not rated yet." &
                                             "All ratings will be saved at the end of this process.")

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        oAppSetting.SetValue("AiService", GetComboBoxVal(cbAiService, "gpt-4o"))
        oAppSetting.SetValue("AnthropicApiKey", txtAnthropicApiKey.Text)
        oAppSetting.SetValue("OpenAIKey", txtOpenAIKey.Text)
        oAppSetting.SetValue("OutputFile", txtOutputFile.Text)
        oAppSetting.SetValue("InputFile", txtInputFile.Text)
        oAppSetting.SetValue("OutputFile", txtOutputFile.Text)
        oAppSetting.SetValue("ValidateFile", txtValidateFile.Text)
        oAppSetting.SetValue("TranslateInstruct", txtTranslateInstruct.Text)
        oAppSetting.SetValue("ValidateInstruct", txtValidateInstruct.Text)
        oAppSetting.SaveData()
    End Sub

    Private Function GetComboBoxVal(ByRef oComboBox As ComboBox, sDefaultValue As String) As String
        If oComboBox.SelectedIndex = -1 Then
            Return sDefaultValue
        End If

        Return oComboBox.Items(oComboBox.SelectedIndex)
    End Function

    Private Sub SetComboBox(ByRef oComboBox As ComboBox, sValue As String)
        For i As Integer = 0 To oComboBox.Items.Count - 1
            If oComboBox.Items(i) = sValue Then
                oComboBox.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btnApiKeyShow_Click(sender As Object, e As EventArgs) Handles btnApiKeyShow.Click
        If txtAnthropicApiKey.PasswordChar = "*" Then
            txtAnthropicApiKey.PasswordChar = ""
        Else
            txtAnthropicApiKey.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnOpenAIKeyShow_Click(sender As Object, e As EventArgs) Handles btnOpenAIKeyShow.Click
        If txtOpenAIKey.PasswordChar = "*" Then
            txtOpenAIKey.PasswordChar = ""
        Else
            txtOpenAIKey.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnInputFile_Click(sender As Object, e As EventArgs) Handles btnInputFile.Click
        OpenFileDialog1.FileName = txtInputFile.Text
        OpenFileDialog1.Title = "Open Text File"
        OpenFileDialog1.Filter = "TXT files|*.txt"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            txtInputFile.Text = OpenFileDialog1.FileName
        End If

        SetOutputFilePath()
        UpdateFileGrid()
    End Sub

    Sub SetOutputFilePath()
        Dim sFilePath As String = txtInputFile.Text
        If sFilePath <> "" Then
            Dim sFolderPath As String = IO.Path.GetDirectoryName(sFilePath)
            Dim sFileName As String = IO.Path.GetFileNameWithoutExtension(sFilePath)
            Dim sExtension As String = IO.Path.GetExtension(sFilePath)

            If txtOutputFile.Text = "" Then
                txtOutputFile.Text = IO.Path.Combine(sFolderPath, sFileName & "_Translate" & sExtension)
            End If

            If txtValidateFile.Text = "" Then
                txtValidateFile.Text = IO.Path.Combine(sFolderPath, sFileName & "_Validate" & sExtension)
            End If
        End If
    End Sub

    Private Sub btnOutputFile_Click(sender As Object, e As EventArgs) Handles btnOutputFile.Click
        OpenFileDialog1.FileName = txtOutputFile.Text
        OpenFileDialog1.Title = "Open Text File"
        OpenFileDialog1.Filter = "TXT files|*.txt"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            txtOutputFile.Text = OpenFileDialog1.FileName
        End If

        UpdateFileGrid()
    End Sub

    Private Sub btnValidateFile_Click(sender As Object, e As EventArgs) Handles btnValidateFile.Click
        OpenFileDialog1.FileName = txtValidateFile.Text
        OpenFileDialog1.Title = "Open Text File"
        OpenFileDialog1.Filter = "TXT files|*.txt"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            txtValidateFile.Text = OpenFileDialog1.FileName
        End If

        UpdateFileGrid()
    End Sub

    Private Sub UpdateFileGrid(Optional ByVal iProcessRow As Integer = 0)
        Dim sFilePath As String = txtInputFile.Text
        If sFilePath = "" OrElse IO.File.Exists(sFilePath) = False Then
            txtInputFile.Text = ""
            DataGridView1.DataSource = Nothing
            DataGridView1.Update()
            Exit Sub
        End If

        Dim iRowIndex As Integer = GetSelectedRowIndex()

        Dim oTable As Data.DataTable = GetDataTable()
        DataGridView1.DataSource = oTable
        DataGridView1.Update()

        If iRowIndex <> -1 And iRowIndex < DataGridView1.RowCount Then
            DataGridView1.MultiSelect = False
            DataGridView1.Rows(iRowIndex).Cells(0).Selected = True
        End If

        UpdateGridColors()
    End Sub



    Private Function GetDataTable() As Data.DataTable

        Dim sInputFilePath As String = txtInputFile.Text
        Dim iRows As Integer = GetFileRowsCount(sInputFilePath)
        Dim iMaxSize As Integer = iRows.ToString().Length

        Dim sOutputFilePath As String = txtOutputFile.Text
        Dim oTranslations As Hashtable = GetHastableFromFile(sOutputFilePath)

        Dim sValidateFilePath As String = txtValidateFile.Text
        Dim oRatings As Hashtable = GetHastableFromFile(sValidateFilePath)


        Dim oTable As New Data.DataTable
        oTable.Columns.Add(New Data.DataColumn("Name"))
        oTable.Columns.Add(New Data.DataColumn("Text"))
        oTable.Columns.Add(New Data.DataColumn("TextSize", System.Type.GetType("System.Int64")))

        oTable.Columns.Add(New Data.DataColumn("Translate"))
        oTable.Columns.Add(New Data.DataColumn("TranslateSize", System.Type.GetType("System.Int64")))
        oTable.Columns.Add(New Data.DataColumn("Ratio", System.Type.GetType("System.Double")))
        oTable.Columns.Add(New Data.DataColumn("Rate", System.Type.GetType("System.Int64")))

        Dim oStreamReader As System.IO.StreamReader = GetStreamReader(sInputFilePath)
        Dim iRow As Integer = 0
        Dim sLine As String = oStreamReader.ReadLine()
        Do Until sLine Is Nothing
            Dim oDataRow As DataRow = oTable.NewRow()
            iRow += 1

            Dim sName As String = Microsoft.VisualBasic.Right("000000" & iRow, iMaxSize)
            oDataRow("Name") = sName
            oDataRow("Text") = sLine
            oDataRow("TextSize") = sLine.Length

            Dim sTranslation As String = oTranslations(iRow) & ""
            If sTranslation <> "" Then
                oDataRow("Translate") = sTranslation
                oDataRow("TranslateSize") = sTranslation.Length
                oDataRow("Ratio") = Math.Round(CDbl(sLine.Length) / CDbl(sTranslation.Length), 2)
            End If

            Dim sRating As String = oRatings(iRow) & ""
            If sRating <> "" AndAlso IsNumeric(sRating) Then
                oDataRow("Rate") = sRating
            End If

            oTable.Rows.Add(oDataRow)
            sLine = oStreamReader.ReadLine()
        Loop

        oStreamReader.Close()
        Return oTable
    End Function

    Private Function GetHastableFromFile(ByVal sFilePath As String) As Hashtable
        Dim oRet As New Hashtable

        If sFilePath = "" OrElse IO.File.Exists(sFilePath) = False Then
            Return oRet
        End If

        Dim oStreamReader As System.IO.StreamReader = GetStreamReader(sFilePath)
        Dim iRow As Integer = 0
        Dim sLine As String = oStreamReader.ReadLine()
        Do Until sLine Is Nothing
            iRow += 1
            oRet(iRow) = sLine
            sLine = oStreamReader.ReadLine()
        Loop

        oStreamReader.Close()
        Return oRet
    End Function

    Function GetStreamReader(ByVal sFilePath As String) As IO.StreamReader
        Return New System.IO.StreamReader(sFilePath, System.Text.Encoding.Default)
    End Function

    Private Function GetFileRowsCount(ByVal sFilePath As String) As Integer
        Dim oStreamReader As System.IO.StreamReader = GetStreamReader(sFilePath)
        Dim sLine As String = oStreamReader.ReadLine()
        Dim iRow As Integer = 0

        Do Until sLine Is Nothing
            iRow += 1
            sLine = oStreamReader.ReadLine()
        Loop

        oStreamReader.Close()

        Return iRow
    End Function

    Function GetSelectedRowIndex()
        If DataGridView1.SelectedRows.Count > 0 Then
            Return DataGridView1.SelectedRows(0).Index
        ElseIf DataGridView1.SelectedCells.Count > 0 Then
            Return DataGridView1.SelectedCells(0).RowIndex
        End If
        Return -1
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        SetupLineText()
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        SetupLineText()
    End Sub

    Sub SetupLineText()
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex <> -1 Then
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iSelectedRowIndex)
            txtLine.Text = oRow.Cells("Text").Value & ""
            txtTranslate.Text = oRow.Cells("Translate").Value & ""
            txtRate.Text = oRow.Cells("Rate").Value & ""

            Me.Text = "Book Translator - " & oRow.Cells("Name").Value & ""
        Else
            Me.Text = "Book Translator"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveTextFile(txtOutputFile.Text, "Translate", System.Text.Encoding.UTF8)
        SaveTextFile(txtValidateFile.Text, "Rate", System.Text.Encoding.ASCII)
        MsgBox("Saved")
    End Sub

    Sub SaveTextFile(sFilePath As String, sColumn As String, oEncoding As System.Text.Encoding)

        Dim bFileCanBeSaved As Boolean = False
        For iRow As Integer = 0 To DataGridView1.RowCount - 1
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
            If oRow.IsNewRow = False AndAlso oRow.Cells(sColumn).Value & "" <> "" Then
                bFileCanBeSaved = True
            End If
        Next

        If bFileCanBeSaved = False Then
            Exit Sub
        End If

        'Sort
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        Dim sBackupFilePath As String = ""

        If System.IO.File.Exists(sFilePath) Then
            Dim sBackupFileName As String = IO.Path.GetFileNameWithoutExtension(sFilePath) & "_" & DateTime.Now.ToString("yyyyMM_ddHHmmss") & IO.Path.GetExtension(sFilePath)
            sBackupFilePath = IO.Path.Combine(IO.Path.GetDirectoryName(sFilePath), sBackupFileName)
            IO.File.Move(sFilePath, sBackupFilePath)
        End If


        Dim sw As New IO.StreamWriter(sFilePath, False, oEncoding)
        For iRow = 0 To DataGridView1.RowCount - 1
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
            If oRow.IsNewRow = False Then
                'Dim sName As String = oRow.Cells("Name").Value
                Dim sTranslate As String = Replace(oRow.Cells(sColumn).Value & "", vbCrLf, "")
                sw.WriteLine(sTranslate)
            End If
        Next

        sw.Close()

        If sBackupFilePath <> "" Then
            If chkBackupFile.Checked Then
                Dim sBackupFolder As String = IO.Path.Combine(IO.Path.GetDirectoryName(sFilePath), IO.Path.GetFileNameWithoutExtension(sFilePath) & "_backup")
                If IO.Directory.Exists(sBackupFolder) = False Then
                    IO.Directory.CreateDirectory(sBackupFolder)
                End If
                Dim sNewBackupFilePath = IO.Path.Combine(sBackupFolder, IO.Path.GetFileName(sBackupFilePath))
                IO.File.Move(sBackupFilePath, sNewBackupFilePath)
            Else
                IO.File.Delete(sBackupFilePath)
            End If
        End If
    End Sub

    Private Sub txtTranslate_TextChanged(sender As Object, e As EventArgs) Handles txtTranslate.TextChanged
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex <> -1 Then
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iSelectedRowIndex)
            oRow.Cells("Translate").Value = txtTranslate.Text
        End If
    End Sub

    Private Sub txtLine_TextChanged(sender As Object, e As EventArgs) Handles txtLine.TextChanged
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex <> -1 Then
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iSelectedRowIndex)
            oRow.Cells("Text").Value = txtLine.Text
        End If
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex <> -1 Then
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iSelectedRowIndex)
            If txtRate.Text = "" OrElse IsNumeric(txtRate.Text) = False Then
                oRow.Cells("Rate").Value = DBNull.Value
            Else
                oRow.Cells("Rate").Value = CInt(txtRate.Text)
            End If
        End If
    End Sub

    Private Sub btnTranslateAll_Click(sender As Object, e As EventArgs) Handles btnTranslateAll.Click
        Translate(-1)
    End Sub

    Private Sub btnTranslateLine_Click(sender As Object, e As EventArgs) Handles btnTranslateLine.Click
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex = -1 Then
            MsgBox("No line was selected")
        Else
            Translate(iSelectedRowIndex)
        End If
    End Sub

    Function ValidateKey() As Boolean
        Dim sAiService As String = GetComboBoxVal(cbAiService, "gpt-4o")
        If Microsoft.VisualBasic.Left(sAiService, 4) = "gpt-" Then
            If Trim(txtOpenAIKey.Text) = "" Then
                MsgBox("OpenAI Api Key is missing")
                Return False
            End If
        Else
            If Trim(txtAnthropicApiKey.Text) = "" Then
                MsgBox("Anthropic Api Key is missing")
                Return False
            End If
        End If

        Return True
    End Function

    Sub Translate(iSelectedRow As Integer)
        If ValidateKey() = False Then
            Exit Sub
        End If

        Dim sPrompt As String = txtTranslateInstruct.Text
        If sPrompt = "" Then
            MsgBox("Translate Instrucions missing")
            Exit Sub
        End If

        Dim bNeedToSaveFile As Boolean = False

        If iSelectedRow = -1 Then
            ProgresVisible(True)
            ProgressBar1.Maximum = DataGridView1.RowCount
        End If

        For iRow = 0 To DataGridView1.RowCount - 1
            If iSelectedRow = -1 OrElse iSelectedRow = iRow Then
                Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
                If oRow.IsNewRow = False Then
                    Dim sText As String = oRow.Cells("Text").Value
                    Dim sTranslate As String = oRow.Cells("Translate").Value & ""

                    If iSelectedRow = -1 Then
                        lbCount.Text = iRow & "/" & DataGridView1.RowCount
                        ProgressBar1.Value = iRow
                        My.Application.DoEvents()
                    End If

                    If Trim(sText) <> "" AndAlso (Trim(sTranslate) = "" Or iSelectedRow <> -1) Then

                        Dim sPrompt2 As String = Replace(sPrompt, "{Text}", sText)

                        Try
                            sTranslate = SendMsg(sPrompt2)
                        Catch ex As Exception
                            If iSelectedRow <> -1 Then
                                MsgBox("Error translating row " & (iRow) & ". " & ex.Message)
                            ElseIf MsgBox("Error translating row " & (iRow) & ". " & ex.Message & ". Continue processing?", vbYesNo) = vbNo Then
                                Exit For
                            End If
                        End Try

                        sTranslate = Replace(sTranslate, vbCrLf, "")
                        sTranslate = Replace(sTranslate, vbLf, "")
                        sTranslate = Replace(sTranslate, vbCr, "")

                        oRow.Cells("Translate").Value = sTranslate
                        oRow.Cells("Rate").Value = DBNull.Value

                        If iSelectedRow <> -1 Then
                            txtTranslate.Text = sTranslate
                            txtRate.Text = ""
                        End If

                        bNeedToSaveFile = True
                    End If
                End If
            End If
        Next

        If bNeedToSaveFile And iSelectedRow = -1 Then
            SaveTextFile(txtOutputFile.Text, "Translate", System.Text.Encoding.UTF8)
        End If

        ProgresVisible(False)
        UpdateGridColors()
    End Sub

    Sub ProgresVisible(bVisible As Boolean)
        lbCount.Visible = bVisible
        ProgressBar1.Visible = bVisible
    End Sub

    Private Sub btnRateAll_Click(sender As Object, e As EventArgs) Handles btnRateAll.Click
        Rate(-1)
    End Sub

    Private Sub btnRateLine_Click(sender As Object, e As EventArgs) Handles btnRateLine.Click
        Dim iSelectedRowIndex As Integer = GetSelectedRowIndex()
        If iSelectedRowIndex = -1 Then
            MsgBox("No line was selected")
        Else
            Rate(iSelectedRowIndex)
        End If
    End Sub

    Sub Rate(iSelectedRow As Integer)

        If ValidateKey() = False Then
            Exit Sub
        End If

        Dim sPrompt As String = txtValidateInstruct.Text
        If sPrompt = "" Then
            MsgBox("Validate Instrucions missing")
            Exit Sub
        End If

        Dim bNeedToSaveFile As Boolean = False

        If iSelectedRow = -1 Then
            ProgresVisible(True)
            ProgressBar1.Maximum = DataGridView1.RowCount
        End If

        For iRow = 0 To DataGridView1.RowCount - 1
            If iSelectedRow = -1 OrElse iSelectedRow = iRow Then
                Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
                If oRow.IsNewRow = False Then
                    Dim sText As String = oRow.Cells("Text").Value
                    Dim sTranslate As String = oRow.Cells("Translate").Value & ""
                    Dim sRate As String = oRow.Cells("Rate").Value & ""

                    If iSelectedRow = -1 Then
                        lbCount.Text = iRow & "/" & DataGridView1.RowCount
                        ProgressBar1.Value = iRow
                        My.Application.DoEvents()
                    End If

                    If Trim(sText) = "" Then
                        oRow.Cells("Rate").Value = 100

                    ElseIf Trim(sText) <> "" AndAlso Trim(sTranslate) <> "" AndAlso (Trim(sRate) = "" Or iSelectedRow <> -1) Then
                        Dim sPrompt2 As String = Replace(sPrompt, "{Text}", sText)
                        sPrompt2 = Replace(sPrompt2, "{Translation}", sTranslate)

                        Try
                            sRate = SendMsg(sPrompt2)
                        Catch ex As Exception

                            If iSelectedRow <> -1 Then
                                MsgBox("Error validating row " & (iRow) & ". " & ex.Message)
                            ElseIf MsgBox("Error validating row " & (iRow) & "." & ex.Message & ". Continue processing?", vbYesNo) = vbNo Then
                                Exit For
                            End If

                        End Try

                        If sRate <> "" AndAlso IsNumeric(sRate) Then
                            oRow.Cells("Rate").Value = CInt(sRate)
                            bNeedToSaveFile = True
                        End If

                        If iSelectedRow <> -1 Then
                            txtRate.Text = sRate
                        End If

                    End If
                End If
            End If
        Next

        If bNeedToSaveFile And iSelectedRow = -1 Then
            SaveTextFile(txtValidateFile.Text, "Rate", System.Text.Encoding.ASCII)
        End If

        ProgresVisible(False)
        UpdateGridColors()
    End Sub

    Function SendMsg(ByVal sQuestion As String) As String
        'gpt-4o, gpt-4o-mini, claude-3-5-sonnet-20240620
        Dim sAiService As String = GetComboBoxVal(cbAiService, "gpt-4o")

        If Microsoft.VisualBasic.Left(sAiService, 4) = "gpt-" Then
            Return SendOpenAiMsg(sAiService, sQuestion)
        Else
            Return SendAnthropicMsg(sQuestion)
        End If
    End Function

    Function SendAnthropicMsg(ByVal sQuestion As String) As String

        System.Net.ServicePointManager.SecurityProtocol =
           System.Net.SecurityProtocolType.Ssl3 Or
           System.Net.SecurityProtocolType.Tls12 Or
           System.Net.SecurityProtocolType.Tls11 Or
           System.Net.SecurityProtocolType.Tls


        Dim sModel As String = "claude-3-5-sonnet-20240620"
        Dim sUrl As String = "https://api.anthropic.com/v1/messages"

        Dim request As HttpWebRequest = WebRequest.Create(sUrl)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("x-api-key", txtAnthropicApiKey.Text)
        request.Headers.Add("anthropic-version", "2023-06-01")

        'https://docs.anthropic.com/en/api/messages
        'https://docs.anthropic.com/en/api/messages-examples

        Dim data As String = ""
        Dim iMaxTokens As Integer = 1024
        Dim dTemperature As Double = 0.7

        data = "{"
        data += """model"": """ & sModel & ""","
        data += """messages"": [{""role"":""user"", ""content"": """ & PadQuotes(sQuestion) & """}],"
        data += """system"": ""You are Claude, an AI assistant created by Anthropic to be helpful, harmless, and honest."","
        data += """max_tokens"": " & iMaxTokens & ","
        data += """temperature"": " & dTemperature
        data += "}"

        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(data)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim sJson As String = streamReader.ReadToEnd()
        'Return sJson

        Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
        Dim sResponse As String = oJson("content")(0)("text")

        Return sResponse
    End Function

    Function SendOpenAiMsg(ByVal sModel As String, ByVal sQuestion As String) As String

        System.Net.ServicePointManager.SecurityProtocol =
           System.Net.SecurityProtocolType.Ssl3 Or
           System.Net.SecurityProtocolType.Tls12 Or
           System.Net.SecurityProtocolType.Tls11 Or
           System.Net.SecurityProtocolType.Tls

        Dim sUrl As String = "https://api.openai.com/v1/chat/completions"

        Dim request As HttpWebRequest = WebRequest.Create(sUrl)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & txtOpenAIKey.Text)

        'https://platform.openai.com/docs/models
        'https://beta.openai.com/docs/api-reference/completions/create

        Dim data As String = "{" &
            " ""model"":""" & sModel & """," &
            " ""messages"": [{""role"":""user"", ""content"": """ & PadQuotes(sQuestion) & """}]" &
            "}"

        Using streamWriter As New IO.StreamWriter(request.GetRequestStream())
            streamWriter.Write(data)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As New IO.StreamReader(response.GetResponseStream())
        Dim sJson As String = streamReader.ReadToEnd()

        Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
        Return oJson("choices")(0)("message")("content")
    End Function

    Private Function PadQuotes(ByVal s As String) As String

        If s.IndexOf("\") <> -1 Then
            s = Replace(s, "\", "\\")
        End If

        If s.IndexOf(vbCrLf) <> -1 Then
            s = Replace(s, vbCrLf, "\n")
        End If

        If s.IndexOf(vbCr) <> -1 Then
            s = Replace(s, vbCr, "\r")
        End If

        If s.IndexOf(vbLf) <> -1 Then
            s = Replace(s, vbLf, "\f")
        End If

        If s.IndexOf(vbTab) <> -1 Then
            s = Replace(s, vbTab, "\t")
        End If

        If s.IndexOf("""") = -1 Then
            Return s
        Else
            Return Replace(s, """", "\""")
        End If
    End Function

    Dim sSelectedCell As String = ""

    Private Sub DataGridView1_CellClick(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        Dim iRowIndex As Integer = GetSelectedRowIndex()
        If iRowIndex = -1 Then
            sSelectedCell = ""
        Else
            sSelectedCell = DataGridView1.Rows(iRowIndex).Cells("Name").Value & ""
        End If
    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted

        If sSelectedCell <> "" Then

            DataGridView1.MultiSelect = False

            For iRow As Integer = 0 To DataGridView1.RowCount - 1
                Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
                If oRow.IsNewRow = False AndAlso oRow.Cells("Name").Value & "" = sSelectedCell Then
                    oRow.Cells(0).Selected = True
                End If
            Next

        End If

        UpdateGridColors()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        Dim sFilePath As String = txtInputFile.Text
        If sFilePath = "" Then
            Exit Sub
        End If

        Dim sFolderPath As String = IO.Path.GetDirectoryName(sFilePath)
        Dim sHtmlFilePath As String = Path.Combine(sFolderPath, "Report.htm")

        If IO.File.Exists(sHtmlFilePath) Then
            IO.File.Delete(sHtmlFilePath)
        End If

        Dim sw As New StreamWriter(sHtmlFilePath, False)
        sw.WriteLine("<html>")
        sw.WriteLine("<body>")
        sw.WriteLine("<table border=1>")
        sw.WriteLine("<tr>")
        sw.WriteLine("<th>Number</th>")
        sw.WriteLine("<th>Text</th>")
        sw.WriteLine("<th>Translation</th>")
        sw.WriteLine("<th>Ratio</th>")
        sw.WriteLine("<th>Rate</th>")
        ''sw.WriteLine("</tr>")

        'DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        For iRow = 0 To DataGridView1.RowCount - 1
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
            If oRow.IsNewRow = False Then

                Dim sName As String = oRow.Cells("Name").Value & ""
                Dim sText As String = oRow.Cells("Text").Value & ""
                Dim sTranslate As String = oRow.Cells("Translate").Value & ""
                Dim sRatio As String = oRow.Cells("Ratio").Value & ""
                Dim sRate As String = oRow.Cells("Rate").Value & ""
                Dim sRatioBg As String = ""
                Dim sRateBg As String = ""

                If sRatio <> "" Then
                    sRatioBg = GetRatioColor(sRatio).ToKnownColor.ToString()
                End If

                If sRate <> "" Then
                    sRateBg = GetRateColor(sRate).ToKnownColor.ToString()
                End If

                sw.WriteLine("<tr>")
                sw.WriteLine("<td>" & sName & "</td>")
                sw.WriteLine("<td>" & sText & "</td>")
                sw.WriteLine("<td>" & sTranslate & "</td>")
                sw.WriteLine("<td bgcolor='" & sRatioBg & "'>" & sRatio & "</td>")
                sw.WriteLine("<td bgcolor='" & sRateBg & "'>" & sRate & "</td>")
                sw.WriteLine("</tr>")
            End If
        Next

        sw.WriteLine("</table>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")
        sw.Close()

        Process.Start(sHtmlFilePath)

    End Sub

    Sub UpdateGridColors()
        For iRow = 0 To DataGridView1.RowCount - 1
            Dim oRow As DataGridViewRow = DataGridView1.Rows(iRow)
            If oRow.IsNewRow = False AndAlso oRow.Cells("Text").Value & "" <> "" Then

                If IsDBNull(oRow.Cells("Ratio").Value) = False Then
                    oRow.Cells("Ratio").Style.BackColor = GetRatioColor(oRow.Cells("Ratio").Value)
                End If

                If IsDBNull(oRow.Cells("Rate").Value) = False Then
                    oRow.Cells("Rate").Style.BackColor = GetRateColor(oRow.Cells("Rate").Value)
                End If

            End If
        Next
    End Sub

    Function GetRatioColor(ByVal iRatio As Double) As Color
        Select Case Math.Abs(iRatio - 1.0)
            Case > 2 : Return Color.Red
            Case > 3 : Return Color.LightSalmon
            Case > 1 : Return Color.LightCoral
            Case > 0.5 : Return Color.Moccasin
            Case > 0.4 : Return Color.LightGoldenrodYellow
            Case > 0.3 : Return Color.PaleGoldenrod
        End Select
        Return Color.White
    End Function

    Function GetRateColor(ByVal iRate As Integer) As Color
        Select Case iRate
            Case < 40 : Return Color.Red
            Case < 50 : Return Color.LightSalmon
            Case < 60 : Return Color.LightCoral
            Case < 70 : Return Color.Moccasin
            Case < 80 : Return Color.LightGoldenrodYellow
            Case < 90 : Return Color.PaleGoldenrod
        End Select
        Return Color.White
    End Function

End Class
