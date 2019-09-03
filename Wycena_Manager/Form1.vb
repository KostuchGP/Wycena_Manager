Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
#Const ProfileColRng = "$L:$L"

Public Class Form1
    Public ver As String = "1.1"
    Public excelSheets As Excel.Sheets
    Dim CalObj As Calculation = New Calculation()
    Dim StyleNaglowekModulu As Excel.Style

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main()
        'Tego co jest nie powinno byc
        ComBoxPyt1.SelectedIndex = 0
        ComBoxPyt2.SelectedIndex = 1
        ComBoxPyt3.SelectedIndex = 0
        ComBoxPyt4.SelectedIndex = 0
        'Poniżej zestaw rzeczy jakie zostaną wypełnione ogólnie, później to trzeba zamienić na rzeczy jakie są dla 

        Dim item1 As ListViewItem = New ListViewItem("Nazwa modułu", 0)
        item1.SubItems.Add("Szt.")
        For i = 1 To 9
            item1.SubItems.Add("0")
        Next
        For i = 10 To 13
            item1.SubItems.Add("")
        Next
        Dim item2 As ListViewItem = New ListViewItem("Siłownik", 0)
        item2.SubItems.Add("Szt.")
        For i = 1 To 9
            item2.SubItems.Add("0")
        Next
        For i = 10 To 13
            item2.SubItems.Add("")
        Next
        Dim item3 As ListViewItem = New ListViewItem("Zawór", 0)
        item3.SubItems.Add("Szt.")
        For i = 1 To 9
            item3.SubItems.Add("0")
        Next
        For i = 10 To 13
            item3.SubItems.Add("")
        Next
        Dim item4 As ListViewItem = New ListViewItem("Kość", 0)
        item4.SubItems.Add("Szt.")
        For i = 1 To 9
            item4.SubItems.Add("0")
        Next
        For i = 10 To 13
            item4.SubItems.Add("")
        Next
        Dim item5 As ListViewItem = New ListViewItem("Shimowanie", 0)
        item5.SubItems.Add("Szt.")
        For i = 1 To 9
            item5.SubItems.Add("0")
        Next
        For i = 10 To 13
            item5.SubItems.Add("")
        Next
        Dim item6 As ListViewItem = New ListViewItem("Konsola", 0)
        item6.SubItems.Add("Szt.")
        For i = 1 To 9
            item6.SubItems.Add("0")
        Next
        For i = 10 To 13
            item6.SubItems.Add("")
        Next
        Dim item7 As ListViewItem = New ListViewItem("Normalia", 0)
        item7.SubItems.Add("Szt.")
        For i = 1 To 9
            item7.SubItems.Add("0")
        Next
        For i = 10 To 13
            item7.SubItems.Add("")
        Next

        LvwMain.Columns.Add("Nazwa", 100, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Ilość", 40, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Materiał", 65, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Obróbka", 65, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Kooperacja", 85, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Pneumatyka", 90, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Pneumatyka EUR", 120, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Normalia", 70, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Normalia EUR", 100, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Automatyka", 90, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Automatyka EUR", 115, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Automatyka godz", 120, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godz projekt", 95, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godz montaż wyjazd", 140, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godz montaż SDA", 125, HorizontalAlignment.Left)

        LvwMain.Items.AddRange(New ListViewItem() {item1, item2, item3, item4, item5, item6, item7})

        ' TWORZENIE LISTY ZESTAWIENIE MODULOW

        LvwZestawienie.Columns.Add("Nr", 30, HorizontalAlignment.Left)
        LvwZestawienie.Columns.Add("Nazwa modułu", 140, HorizontalAlignment.Left)
        LvwZestawienie.Columns.Add("Ilość", 40, HorizontalAlignment.Left)
        LvwZestawienie.Columns.Add("Cena [szt.]", 100, HorizontalAlignment.Left)

        LvwZestawienie.Items.AddRange(New ListViewItem() {item1, item2, item3, item4, item5, item6, item7})

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        LvwMain.Clear()
        Form1_Load(e, e)
        ComBoxPyt1.SelectedIndex = -1
        ComBoxPyt2.SelectedIndex = -1
        ComBoxPyt3.SelectedIndex = -1
        ComBoxPyt4.SelectedIndex = -1
        NumberPyt2.Value = "1"
        NumberPyt3.Value = "1"
        NumberPyt4.Value = "1"
        txtNM.Clear()
    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim money As Double = 12.34
        Dim euro As String = money.ToString("c", New Globalization.CultureInfo("fr-FR", False))
        MsgBox(euro)
    End Sub

    Public Sub BtnPrzelicz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrzelicz.Click

        If ComBoxPyt1.SelectedIndex = -1 Then
            GoTo Line1
            'ElseIf txtNM.Text = Nothing Then
            'GoTo Line1
        ElseIf ComBoxPyt2.SelectedIndex = -1 Then
            GoTo Line1
        ElseIf ComBoxPyt3.SelectedIndex = -1 Then
            GoTo Line1
        ElseIf ComBoxPyt4.SelectedIndex = -1 Then
Line1:      MsgBox("Proszę uzupełnij wszystkie pola")
            Exit Sub
        Else
            'Jeżeli wszystko jest uzupełnione to przejdzie do liczenia modułu klampienia
            LvwMain.Items(0).Text = txtNM.Text
            LvwMain.Items(0).SubItems(1).Text = 1
            CalObj.Przelicz(ComBoxPyt1.SelectedIndex, ComBoxPyt2.SelectedIndex, ComBoxPyt3.SelectedIndex, ComBoxPyt4.SelectedIndex, NumberPyt2.Value, NumberPyt3.Value, NumberPyt4.Value)

        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Dim oServ As Object
        Dim cProc As Object
        Dim oProc As Object

        oServ = GetObject("winmgmts:")
        cProc = oServ.ExecQuery("Select * from Win32_Process")

        For Each oProc In cProc

            'Rename EXCEL.EXE in the line below with the process that you need to Terminate. 
            'NOTE: It is 'case sensitive

            If oProc.Name = "EXCEL.EXE" Then
                oProc.Terminate()
            End If
        Next
        Me.Close()
    End Sub




    Public Shared Function GetDouble(ByVal doublestring As String) As Double
        Dim retval As Double
        Dim sep As String = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        Double.TryParse(Replace(Replace(doublestring, ".", sep), ",", sep), retval)
        Return retval
    End Function

    ' NULLABLE VERSION:
    Public Shared Function GetDoubleNullable(ByVal doublestring As String) As Double?
        Dim retval As Double
        Dim sep As String = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

        If Double.TryParse(Replace(Replace(doublestring, ".", sep), ",", sep), retval) Then
            Return retval
        Else
            Return Nothing
        End If
    End Function

    Public Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim excelApp As Excel.Application = New Excel.Application()
        Dim excelBook As Excel.Workbook
        Dim strPath As String = "C:\Wzor.xlsm"
        excelBook = excelApp.Workbooks.Open(strPath, 0, False, 5, _
            System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, _
            True, False, System.Reflection.Missing.Value, False)
        excelSheets = excelBook.Sheets
        Dim excelSheet As Excel.Worksheet = excelSheets(1)

        '  Style ktory bedzie nadany
        '  StyleNaglowekModulu = excelSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
        '  StyleNaglowekModulu.Font.Bold = True
        '  StyleNaglowekModulu.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)



        'StyleNaglowekModulu.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

        'StyleNaglowekModulu.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)



        Dim excelRange As Excel.Range = excelSheet.UsedRange

        ' With excelSheet
        ' Dim lastRow = .Cells(.Rows.Count, "B").End(xlUp).Row
        'MsgBox(lastRow)
        'End With

        Dim myreccnt As Long

        myreccnt = GetFilteredPivotRowCount("KALKULACJA", "B:B")

        '  With excelSheet
        'Dim Ndt = excelRange("B:B").Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeConstants).Count
        '   Debug.Print(Ndt)
        '    End With
        'Stary kod do wstawiania wartosci w konkretne komórki do Excel'a
        'excelRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Activate()
        'Dim intNewRow As Int32 = excelApp.ActiveCell.Row + 1
        '  Dim intNewRow As Int32 = myreccnt
        '  Dim strNewCellAddress As String = "B" & intNewRow
        ' excelSheet.Range(strNewCellAddress).Value = "siemano"
        ' excelSheet.Range("C8").Value = "1"
        ' excelSheet.Range("D8").Value = "100"
        'excelSheet.Range("M8").Value = "50"
        ' Kod na dodawanie nazw kolumn do excela
        '   For i = 0 To LvwMain.Columns.Count - 1
        'excelSheet.Cells(10, i + 1 + 1) = LvwMain.Columns(i).Text
        'excelSheet.Columns.AutoFit()
        'excelSheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        'excelSheet.Columns.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        'Next

        For i = 0 To LvwMain.Items.Count - 1
            For j = 0 To LvwMain.Items(i).SubItems.Count - 1
                excelSheet.Cells(i + myreccnt, j + 2) = LvwMain.Items(i).SubItems(j).Text

                If i = 0 And j = 0 Then
                    'Nadanie wartosci komórce stylu
                    'excelSheet.Cells(i + myreccnt, j + 2).Style = "NewStyle"
                    'excelSheet.Range(i + myreccnt, j + 2).Font.Bold = "Bold"
                    excelSheet.Range("B" & myreccnt).Font.Bold = True
                    excelSheet.Range("B" & myreccnt).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
                End If
                'excelSheet.Columns.AutoFit()
                'excelSheet.Columns.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                'excelSheet.Columns.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
            Next
        Next

        'txtSuma.Text = excelSheet.Cells(5 + myreccnt, 7 + 2).value
        txtSuma.Text = excelSheet.Range("P4").Value

        excelBook.Save()
        excelBook.Close()
        excelApp.Quit()

        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If
    End Sub

    Function GetFilteredPivotRowCount(ByVal sheetname As String, ByVal cntrange As String) As Long

        Dim reccnt As Long

        reccnt = excelSheets(sheetname).Range(cntrange).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible).SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeConstants).Count + 1

        GetFilteredPivotRowCount = reccnt
        'MsgBox(GetFilteredPivotRowCount)

    End Function

    Private Sub LvwMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvwMain.SelectedIndexChanged

    End Sub

    Private Sub DfgdfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeToolStripMenuItem.Click

    End Sub

    Private Sub EvolvedInProgressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvolvedInProgressToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Product: Wycena Manager" & Chr(10) & "File version: " & ver & Chr(10) & "Contact person: Grzegorz Pawezowski", MsgBoxStyle.Information, "About")
    End Sub

    Private Function Suma(ByVal suma1 As Integer) As Integer
        Dim suma2 As Integer
        For i = 0 To Me.LvwMain.Items.Count - 1
        Next
        Return suma2
    End Function


End Class
