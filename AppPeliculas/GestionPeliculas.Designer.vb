<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionPeliculas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPelisDetalles = New System.Windows.Forms.Button()
        Me.btnPelisModificar = New System.Windows.Forms.Button()
        Me.btnPelisBaja = New System.Windows.Forms.Button()
        Me.btnPelisCrear = New System.Windows.Forms.Button()
        Me.gridViewPelis = New System.Windows.Forms.DataGridView()
        CType(Me.gridViewPelis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPelisDetalles
        '
        Me.btnPelisDetalles.Location = New System.Drawing.Point(13, 352)
        Me.btnPelisDetalles.Name = "btnPelisDetalles"
        Me.btnPelisDetalles.Size = New System.Drawing.Size(122, 23)
        Me.btnPelisDetalles.TabIndex = 1
        Me.btnPelisDetalles.Text = "Ver detalles"
        Me.btnPelisDetalles.UseVisualStyleBackColor = True
        '
        'btnPelisModificar
        '
        Me.btnPelisModificar.Location = New System.Drawing.Point(270, 351)
        Me.btnPelisModificar.Name = "btnPelisModificar"
        Me.btnPelisModificar.Size = New System.Drawing.Size(122, 23)
        Me.btnPelisModificar.TabIndex = 2
        Me.btnPelisModificar.Text = "Modificar pelicula"
        Me.btnPelisModificar.UseVisualStyleBackColor = True
        '
        'btnPelisBaja
        '
        Me.btnPelisBaja.Location = New System.Drawing.Point(398, 351)
        Me.btnPelisBaja.Name = "btnPelisBaja"
        Me.btnPelisBaja.Size = New System.Drawing.Size(123, 23)
        Me.btnPelisBaja.TabIndex = 3
        Me.btnPelisBaja.Text = "Dar de baja"
        Me.btnPelisBaja.UseVisualStyleBackColor = True
        '
        'btnPelisCrear
        '
        Me.btnPelisCrear.Location = New System.Drawing.Point(141, 351)
        Me.btnPelisCrear.Name = "btnPelisCrear"
        Me.btnPelisCrear.Size = New System.Drawing.Size(123, 23)
        Me.btnPelisCrear.TabIndex = 4
        Me.btnPelisCrear.Text = "Crear Pelicula"
        Me.btnPelisCrear.UseVisualStyleBackColor = True
        '
        'gridViewPelis
        '
        Me.gridViewPelis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridViewPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewPelis.Location = New System.Drawing.Point(13, 13)
        Me.gridViewPelis.Name = "gridViewPelis"
        Me.gridViewPelis.Size = New System.Drawing.Size(775, 332)
        Me.gridViewPelis.TabIndex = 5
        '
        'GestionPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 390)
        Me.Controls.Add(Me.gridViewPelis)
        Me.Controls.Add(Me.btnPelisCrear)
        Me.Controls.Add(Me.btnPelisBaja)
        Me.Controls.Add(Me.btnPelisModificar)
        Me.Controls.Add(Me.btnPelisDetalles)
        Me.Name = "GestionPeliculas"
        Me.Text = "GestionPeliculas"
        CType(Me.gridViewPelis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPelisDetalles As Button
    Friend WithEvents btnPelisModificar As Button
    Friend WithEvents btnPelisBaja As Button
    Friend WithEvents btnPelisCrear As Button
    Friend WithEvents gridViewPelis As DataGridView
End Class
