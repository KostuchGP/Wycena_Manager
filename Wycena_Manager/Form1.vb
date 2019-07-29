﻿Imports System.Globalization
Imports Microsoft.Office.Interop
#Const ProfileColRng = "$L:$L"

Public Class Form1

    Public excelSheets As Excel.Sheets
    Dim CalObj As Calculation = New Calculation()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main()
        'Tego co jest nie powinno byc
        ComBoxPyt1.SelectedIndex = 0
        ComBoxPyt2.SelectedIndex = 1
        ComBoxPyt3.SelectedIndex = 0
        ComBoxPyt4.SelectedIndex = 0
        'Poniżej zestaw rzeczy jakie zostaną wypełnione ogólnie, później to trzeba zamienić na rzeczy jakie są dla 
        Dim item1 As ListViewItem = New ListViewItem("Siłownik", 0)
        item1.SubItems.Add("Szt.")
        For i = 1 To 6
            item1.SubItems.Add("-")
        Next
        For i = 7 To 9
            item1.SubItems.Add("")
        Next
        Dim item2 As ListViewItem = New ListViewItem("Zawór", 0)
        item2.SubItems.Add("Szt.")
        For i = 1 To 6
            item2.SubItems.Add("-")
        Next
        For i = 7 To 9
            item2.SubItems.Add("")
        Next
        Dim item3 As ListViewItem = New ListViewItem("Kość", 0)
        item3.SubItems.Add("Szt.")
        For i = 1 To 6
            item3.SubItems.Add("-")
        Next
        For i = 7 To 9
            item3.SubItems.Add("")
        Next
        Dim item4 As ListViewItem = New ListViewItem("Podkładki", 0)
        item4.SubItems.Add("Szt.")
        For i = 1 To 6
            item4.SubItems.Add("-")
        Next
        For i = 7 To 9
            item4.SubItems.Add("")
        Next
        Dim item5 As ListViewItem = New ListViewItem("Konsola", 0)
        item5.SubItems.Add("Szt.")
        For i = 1 To 6
            item5.SubItems.Add("-")
        Next
        For i = 7 To 9
            item5.SubItems.Add("")
        Next
        Dim item6 As ListViewItem = New ListViewItem("Coś6", 0)
        item6.SubItems.Add("Szt.")
        For i = 1 To 6
            item6.SubItems.Add("-")
        Next
        For i = 7 To 9
            item6.SubItems.Add("")
        Next
        Dim item7 As ListViewItem = New ListViewItem("Coś7", 0)
        item7.SubItems.Add("Szt.")
        For i = 1 To 6
            item7.SubItems.Add("-")
        Next
        For i = 7 To 9
            item7.SubItems.Add("")
        Next

        LvwMain.Columns.Add("Nazwa", 200, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Ilość", 60, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Materiał", 70, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Obróbka", 70, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Kooperacja", 90, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Pneumatyka", 90, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Pneumatyka EUR", 120, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Normalia", 70, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Normalia EUR", 100, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godziny projektowe", 130, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godziny montażowe", 135, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Godziny wyjazdowe", 130, HorizontalAlignment.Left)
        LvwMain.Columns.Add("Suma", 60, HorizontalAlignment.Left)

        LvwMain.Items.AddRange(New ListViewItem() {item1, item2, item3, item4, item5, item6, item7})

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        ComBoxPyt1.SelectedIndex = -1
        ComBoxPyt2.SelectedIndex = -1
        ComBoxPyt3.SelectedIndex = -1
        ComBoxPyt4.SelectedIndex = -1
        NumberPyt2.Value = "1"
        NumberPyt3.Value = "1"
        NumberPyt4.Value = "1"
        txtNM.Clear()
    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        Dim money As Double = 12.34
        Dim euro As String = money.ToString("c", New Globalization.CultureInfo("fr-FR", False))
        MsgBox(euro)
    End Sub

    Private Sub BtnPrzelicz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrzelicz.Click

        If ComBoxPyt1.SelectedIndex = -1 Then
            GoTo Line1
        ElseIf ComBoxPyt2.SelectedIndex = -1 Then
            GoTo Line1
        ElseIf ComBoxPyt3.SelectedIndex = -1 Then
            GoTo Line1
        ElseIf ComBoxPyt4.SelectedIndex = -1 Then
Line1:      MsgBox("Proszę uzupełnij wszystkie pola")
            Exit Sub
        Else
            'Jeżeli wszystko jest uzupełnione to przejdzie do liczenia modułu klampienia
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


        'excelRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Activate()
        'Dim intNewRow As Int32 = excelApp.ActiveCell.Row + 1
        Dim intNewRow As Int32 = myreccnt
        Dim strNewCellAddress As String = "B" & intNewRow
        excelSheet.Range(strNewCellAddress).Value = "siemano"
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
End Class
