Public Class index

    Private Sub ctCrear_Click(sender As Object, e As EventArgs) Handles ctCrear.Click
        ' Crear una instancia del formulario Update
        Dim frm As New Form1()

        ' Mostrar el formulario Update
        frm.Show()

        ' (Opcional) Ocultar el formulario actual
        Me.Hide()
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        ' Crear una instancia del formulario Update
        Dim frm As New update()

        ' Mostrar el formulario Update
        frm.Show()

        ' (Opcional) Ocultar el formulario actual
        Me.Hide()
    End Sub
End Class