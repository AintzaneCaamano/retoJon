Public Class Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub OpenMenuOption(sender As Object, e As EventArgs) Handles BtnFormClientes.Click, BtnFormPeliculas.Click, BtnSalir.Click
        Dim selectedForm As Form = Nothing

        Dim caller As String = CType(sender, Button).Name

        Select Case caller
            Case "BtnFormClientes"
                selectedForm = New GestionClientes()
            Case "BtnFormPeliculas"
                selectedForm = New GestionPeliculas()
            Case "BtnSalir"
                Me.Dispose()
        End Select

        If Not IsNothing(selectedForm) Then
            Me.Hide()
            selectedForm.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ta bueno
        If e.CloseReason = 3 Then
            e.Cancel = True
            MessageBox.Show("(╯°□°)╯ Cierra con el botón del menú que para algo está")
        End If
    End Sub
End Class
