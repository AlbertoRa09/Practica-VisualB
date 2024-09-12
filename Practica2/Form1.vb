Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer
        Dim L As Integer
        Dim H As Integer
        Dim Res As Integer

        A = Ancho1.Text
        L = Largo1.Text
        H = Altura1.Text
        Res = L * A * H
        Resultado.Text = Res
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As Integer
        Dim B As Integer

        ' Convertir los textos ingresados en los cuadros A1 y B2 a enteros
        A = Convert.ToInt32(A1.Text)
        B = Convert.ToInt32(B2.Text)

        ' Calcular A^2 - B^2
        Dim resultado As Integer = (A * A) - (B * B)
        Dim alt As String = "(" & A.ToString() & " - " & B.ToString() & ")^2"

        ' Mostrar el resultado en el cuadro de texto resultado2
        resultado2.Text = resultado.ToString()
        Alter.Text = alt

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mayor, menor, altura, resultado As Decimal


        mayor = Val(Bma.Text)
        menor = Val(Bme.Text)
        altura = Val(H.Text)
        resultado = Val(res1.Text)
        resultado = (mayor + menor) / altura
        res1.Text = resultado


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim va, vb, resul As Decimal

        va = Val(A.Text)
        vb = Val(B.Text)

        resul = (va * va) + (2 * va * vb) + (vb * vb)

        res2.Text = resul




    End Sub
End Class
