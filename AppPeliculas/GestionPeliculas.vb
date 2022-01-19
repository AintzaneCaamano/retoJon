Public Class GestionPeliculas
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridViewPelis.CellContentClick

    End Sub

    Private Sub GestionPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EMPRESADataSet.Peliculas' Puede moverla o quitarla según sea necesario.
        Me.PeliculasTableAdapter.Fill(Me.EMPRESADataSet.Peliculas)
        'TODO: esta línea de código carga datos en la tabla 'EMPRESADataSet.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.Fill(Me.EMPRESADataSet.Facturas)
        'TODO: esta línea de código carga datos en la tabla 'EMPRESADataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.EMPRESADataSet.Clientes)
    End Sub

    Private Sub btnPelisDetalles_Click(sender As Object, e As EventArgs) Handles btnPelisDetalles.Click

    End Sub

    Private Sub btnPelisCrear_Click(sender As Object, e As EventArgs) Handles btnPelisCrear.Click

    End Sub

    Private Sub btnPelisModificar_Click(sender As Object, e As EventArgs) Handles btnPelisModificar.Click

    End Sub

    Private Sub btnPelisBaja_Click(sender As Object, e As EventArgs) Handles btnPelisBaja.Click

    End Sub
End Class