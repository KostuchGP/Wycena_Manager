Public Class ModuleClamp
    '{ Odpowiedzi od 1 do 4
    '       {1, 2, 3, 0},
    '       {120 zł, 150 zł, 300 zł, 0},
    '       {1, 2, 3, -},
    '       {Nie, Tak, -, -}
    '}
    Public ClampArray = New Integer(3, 3) {
                                                {1, 2, 3, 0},
                                                {0, 120, 150, 300},
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
        'Formuła ceny zaworu wariant*przelicznik*25% wartości zaworu do siłownika | PRZELICZNIKI ZAWOR
        If pyt2 = 0 Then
            Form1.LvwMain.Items(1).SubItems(1).Text = 0
        Else
            Form1.LvwMain.Items(1).SubItems(1).Text = Form1.GetDoubleNullable(Form1.LvwMain.Items(0).SubItems(1).Text) * 2
            Form1.LvwMain.Items(1).SubItems(5).Text = (ClampArray(1, pyt2) * num2 * 0.25 / num2)
        End If
        'Formuła ceny Kości wariant*przelicznik | PRZELICZNIKI KOSC
        Form1.LvwMain.Items(2).SubItems(2).Text = (ClampArray(1, pyt2) * num2)
        'Formuła ceny Shimowania wariant*przelicznik | PRZELICZNIKI SHIMOWANIE
        Form1.LvwMain.Items(3).SubItems(2).Text = (ClampArray(1, pyt2) * num2)
        'Formuła ceny Konsoli wariant*przelicznik | PRZELICZNIKI KONSOLA

        If pyt4 = 0 Then
            Form1.LvwMain.Items(4).SubItems(1).Text = 0
        Else
            Form1.LvwMain.Items(4).SubItems(1).Text = (ClampArray(1, pyt2) * num2)
        End If

    End Sub
End Class
