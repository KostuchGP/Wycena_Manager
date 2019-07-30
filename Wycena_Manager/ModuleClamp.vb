Public Class ModuleClamp
    '{ Odpowiedzi od 1 do 4
    '       {1, 2, 3, 0},
    '       {120 zł, 150 zł, 300 zł, 0},
    '       {1, 2, 3, -},
    '       {Nie, Tak, -, -}
    '}
    Public ClampArray = New Integer(3, 3) {
                                                {1, 2, 3, 0},
                                                {0, 1100, 1300, 2000},
                                                {1, 2, 3, 0},
                                                {0, 1, 0, 0}
    }
    Public Sub PrzeliczClamp(ByVal pyt2 As Integer, ByVal pyt3 As Integer, ByVal pyt4 As Integer, ByVal num2 As Integer, ByVal num3 As Integer, ByVal num4 As Integer)
        'Formuła ceny siłownika wariant*przelicznik \ PRZELICZNIKI SILOWNIK
        If pyt2 = 0 Then
            Form1.LvwMain.Items(0).SubItems(1).Text = 0
        Else
            Form1.LvwMain.Items(0).SubItems(1).Text = 1
            Form1.LvwMain.Items(0).SubItems(5).Text = (ClampArray(1, pyt2) * num2)
        End If
        'Formuła ceny zaworu wariant*2,5% wartości zaworu do siłownika | PRZELICZNIKI ZAWOR
        If pyt2 = 0 Then
            Form1.LvwMain.Items(1).SubItems(1).Text = 0
        Else
            Form1.LvwMain.Items(1).SubItems(1).Text = Form1.GetDoubleNullable(Form1.LvwMain.Items(0).SubItems(1).Text) * 2
            Form1.LvwMain.Items(1).SubItems(5).Text = (ClampArray(1, pyt2) * 0.025)
        End If
        'PRZELICZNIKI KOSC
        'Formuła ceny Kości Materiał: wariant*przelicznik*3%
        'Formuła ceny Kości Obróbka: wariant*przelicznik*9,2%
        'Formuła ceny Kości Kooperacja: wariant*przelicznik*15%
        Form1.LvwMain.Items(2).SubItems(1).Text = (ClampArray(2, pyt3))
        Form1.LvwMain.Items(2).SubItems(2).Text = (ClampArray(1, pyt2) * 0.03 * num3)
        Form1.LvwMain.Items(2).SubItems(2).Text = (ClampArray(1, pyt2) * 0.09 * num3)



        'Formuła ceny Shimowania stała 50 zł | PRZELICZNIKI SHIMOWANIE
        Form1.LvwMain.Items(3).SubItems(1).Text = (ClampArray(2, pyt3))
        Form1.LvwMain.Items(3).SubItems(2).Text = 50

        'Formuła ceny Konsoli wariant*przelicznik*25% | PRZELICZNIKI KONSOLA

        If pyt4 = 0 Then
            Form1.LvwMain.Items(4).SubItems(1).Text = 0
        Else
            Form1.LvwMain.Items(4).SubItems(1).Text = (ClampArray(1, pyt2))
            Form1.LvwMain.Items(4).SubItems(2).Text = (ClampArray(1, pyt2) * num4)

        End If

    End Sub
End Class
