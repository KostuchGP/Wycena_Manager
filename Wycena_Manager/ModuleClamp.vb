Public Class ModuleClamp
    Public ClampArray = New Integer(3, 3) {
                                                {1, 2, 3, 0},
                                                {0, 1100, 1300, 2000},
                                                {1, 2, 3, 0},
                                                {0, 1, 0, 0}
    }
    Public Sub PrzeliczClamp(ByVal pyt2 As Integer, ByVal pyt3 As Integer, ByVal pyt4 As Integer, ByVal num2 As Integer, ByVal num3 As Integer, ByVal num4 As Integer)
        'PRZELICZNIKI Godzin modułu
        'Formuła godzin wariant


        ' Brakuje


        'PRZELICZNIKI SILOWNIK
        'Formuła ceny siłownika wariant*przelicznik
        If pyt2 = 0 Then
            Form1.LvwMain.Items(1).SubItems(1).Text = 0
            Form1.LvwMain.Items(1).SubItems(5).Text = 0
        Else
            Form1.LvwMain.Items(1).SubItems(1).Text = 1
            Form1.LvwMain.Items(1).SubItems(5).Text = (ClampArray(1, pyt2) * num2)
        End If
        'PRZELICZNIKI ZAWOR
        'Formuła ceny zaworu wariant*2,5% wartości siłownika
        If pyt2 = 0 Then
            Form1.LvwMain.Items(2).SubItems(1).Text = 0
            Form1.LvwMain.Items(2).SubItems(5).Text = 0
        Else
            Form1.LvwMain.Items(2).SubItems(1).Text = Form1.GetDoubleNullable(Form1.LvwMain.Items(1).SubItems(1).Text) * 2
            Form1.LvwMain.Items(2).SubItems(5).Text = (ClampArray(1, pyt2) * 0.025)
        End If
        'PRZELICZNIKI KOSC
        'Formuła ceny Kości Materiał: wariant*przelicznik*3%
        'Formuła ceny Kości Obróbka: wariant*przelicznik*20%
        'Formuła ceny Kości Kooperacja: wariant*przelicznik*2,8%
        Form1.LvwMain.Items(3).SubItems(1).Text = (ClampArray(2, pyt3))
        If pyt2 = 0 Then ' Czyli jak nie ma siłownika to średnia cena 1500 zł
            Form1.LvwMain.Items(3).SubItems(2).Text = (1500 * 0.03 * num3)
            Form1.LvwMain.Items(3).SubItems(3).Text = (1500 * 0.2 * num3)
            Form1.LvwMain.Items(3).SubItems(4).Text = (1500 * 0.028 * num3)
        Else
            Form1.LvwMain.Items(3).SubItems(2).Text = (ClampArray(1, pyt2) * 0.03 * num3)
            Form1.LvwMain.Items(3).SubItems(3).Text = (ClampArray(1, pyt2) * 0.2 * num3)
            Form1.LvwMain.Items(3).SubItems(4).Text = (ClampArray(1, pyt2) * 0.028 * num3)
        End If
        'PRZELICZNIKI SHIMOWANIE
        'Formuła ceny Shimowania stała 50 zł
        Form1.LvwMain.Items(4).SubItems(1).Text = (ClampArray(2, pyt3))
        Form1.LvwMain.Items(4).SubItems(2).Text = 50
        'PRZELICZNIKI KONSOLA
        'Formuła ceny Konsoli Materiał: wariant*przelicznik*6%
        'Formuła ceny Konsoli Obróbka: wariant*przelicznik*23%
        'Formuła ceny Konsoli Kooperacja: wariant*przelicznik*3%
        If pyt4 = 0 Then ' bez konsoli
            Form1.LvwMain.Items(5).SubItems(1).Text = 0
            Form1.LvwMain.Items(5).SubItems(2).Text = 0
            Form1.LvwMain.Items(5).SubItems(3).Text = 0
            Form1.LvwMain.Items(5).SubItems(4).Text = 0
        ElseIf pyt2 = 0 Then ' Czyli jak nie ma siłownika to średnia cena 300 zł, a ma być konsola
            Form1.LvwMain.Items(5).SubItems(1).Text = 1
            Form1.LvwMain.Items(5).SubItems(2).Text = (1500 * 0.06 * num4)
            Form1.LvwMain.Items(5).SubItems(3).Text = (1500 * 0.23 * num4)
            Form1.LvwMain.Items(5).SubItems(4).Text = (1500 * 0.03 * num4)
        Else
            Form1.LvwMain.Items(5).SubItems(1).Text = 1
            Form1.LvwMain.Items(5).SubItems(2).Text = (ClampArray(1, pyt2) * 0.06 * num4)
            Form1.LvwMain.Items(5).SubItems(3).Text = (ClampArray(1, pyt2) * 0.23 * num4)
            Form1.LvwMain.Items(5).SubItems(4).Text = (ClampArray(1, pyt2) * 0.03 * num4)
        End If
        'PRZELICZNIKI NORMALIA        
        'Formuła ceny Normaliów Materiał: wariant*%
        If pyt2 = 0 Then
            Form1.LvwMain.Items(6).SubItems(1).Text = 1
            Form1.LvwMain.Items(6).SubItems(7).Text = 50
        Else
            Form1.LvwMain.Items(6).SubItems(1).Text = 1
            Form1.LvwMain.Items(6).SubItems(7).Text = (ClampArray(1, pyt2) * 0.07 * num2)
        End If

    End Sub
End Class
