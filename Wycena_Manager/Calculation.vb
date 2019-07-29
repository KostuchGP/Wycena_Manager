Imports System.Windows.Forms
Public Class Calculation

    Dim ModuleClampObj As ModuleClamp = New ModuleClamp()


    '{ Pytania od 1 do 4
    '       {Moduł klampienia, Moduł pozycjonowania, Moduł zabudowy, -},
    '       {Brak, Mały, Średni, Duży},
    '       {1, 2, 3, -},
    '       {Nie, Tak, -, -}
    '}                                     }

    Public Sub Przelicz(ByVal pyt1 As Integer, ByVal pyt2 As Integer, ByVal pyt3 As Integer, ByVal pyt4 As Integer, ByVal num2 As Integer, ByVal num3 As Integer, ByVal num4 As Integer)
        If pyt1 = 0 Then
            ModuleClampObj.PrzeliczClamp(pyt2, pyt3, pyt4, num2, num3, num4)
        ElseIf pyt1 = 1 Then
            'stworzenie przeliczenia modułu2
        ElseIf pyt1 = 2 Then
            'stworzenie przeliczenia modułu3
        End If

    End Sub
End Class
