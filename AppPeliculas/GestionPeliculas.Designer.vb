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
        Me.components = New System.ComponentModel.Container()
        Me.gridViewPelis = New System.Windows.Forms.DataGridView()
        Me.EMPRESADataSet = New AppPeliculas.EMPRESADataSet()
        Me.EMPRESADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New AppPeliculas.EMPRESADataSetTableAdapters.ClientesTableAdapter()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasTableAdapter = New AppPeliculas.EMPRESADataSetTableAdapters.FacturasTableAdapter()
        Me.PeliculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeliculasTableAdapter = New AppPeliculas.EMPRESADataSetTableAdapters.PeliculasTableAdapter()
        Me.btnPelisDetalles = New System.Windows.Forms.Button()
        Me.btnPelisModificar = New System.Windows.Forms.Button()
        Me.btnPelisBaja = New System.Windows.Forms.Button()
        Me.btnPelisCrear = New System.Windows.Forms.Button()
        Me.Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anyo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Director = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaDataSet1 = New AppPeliculas.EMPRESADataSet()
        CType(Me.gridViewPelis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPRESADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridViewPelis
        '
        Me.gridViewPelis.AllowDrop = True
        Me.gridViewPelis.AllowUserToAddRows = False
        Me.gridViewPelis.AllowUserToDeleteRows = False
        Me.gridViewPelis.AllowUserToOrderColumns = True
        Me.gridViewPelis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridViewPelis.AutoGenerateColumns = False
        Me.gridViewPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridViewPelis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Titulo, Me.Anyo, Me.Director, Me.CodGenero})
        Me.gridViewPelis.DataSource = Me.PeliculasBindingSource
        Me.gridViewPelis.Location = New System.Drawing.Point(12, 12)
        Me.gridViewPelis.Name = "gridViewPelis"
        Me.gridViewPelis.Size = New System.Drawing.Size(776, 333)
        Me.gridViewPelis.TabIndex = 0
        '
        'EMPRESADataSet
        '
        Me.EMPRESADataSet.DataSetName = "EMPRESADataSet"
        Me.EMPRESADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPRESADataSetBindingSource
        '
        Me.EMPRESADataSetBindingSource.DataSource = Me.EMPRESADataSet
        Me.EMPRESADataSetBindingSource.Position = 0
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.EMPRESADataSetBindingSource
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.EMPRESADataSetBindingSource
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'PeliculasBindingSource
        '
        Me.PeliculasBindingSource.DataMember = "Peliculas"
        Me.PeliculasBindingSource.DataSource = Me.EMPRESADataSetBindingSource
        '
        'PeliculasTableAdapter
        '
        Me.PeliculasTableAdapter.ClearBeforeFill = True
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
        'Titulo
        '
        Me.Titulo.DataPropertyName = "Titulo"
        Me.Titulo.HeaderText = "Titulo"
        Me.Titulo.Name = "Titulo"
        '
        'Anyo
        '
        Me.Anyo.DataPropertyName = "Anyo"
        Me.Anyo.HeaderText = "Anyo"
        Me.Anyo.Name = "Anyo"
        '
        'Director
        '
        Me.Director.DataPropertyName = "Director"
        Me.Director.HeaderText = "Director"
        Me.Director.Name = "Director"
        '
        'CodGenero
        '
        Me.CodGenero.DataPropertyName = "CodGenero"
        Me.CodGenero.HeaderText = "CodGenero"
        Me.CodGenero.Name = "CodGenero"
        '
        'EmpresaDataSet1
        '
        Me.EmpresaDataSet1.DataSetName = "EMPRESADataSet"
        Me.EmpresaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GestionPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPelisCrear)
        Me.Controls.Add(Me.btnPelisBaja)
        Me.Controls.Add(Me.btnPelisModificar)
        Me.Controls.Add(Me.btnPelisDetalles)
        Me.Controls.Add(Me.gridViewPelis)
        Me.Name = "GestionPeliculas"
        Me.Text = "GestionPeliculas"
        CType(Me.gridViewPelis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPRESADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeliculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridViewPelis As DataGridView
    Friend WithEvents EMPRESADataSetBindingSource As BindingSource
    Friend WithEvents EMPRESADataSet As EMPRESADataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As EMPRESADataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasTableAdapter As EMPRESADataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents PeliculasBindingSource As BindingSource
    Friend WithEvents PeliculasTableAdapter As EMPRESADataSetTableAdapters.PeliculasTableAdapter
    Friend WithEvents btnPelisDetalles As Button
    Friend WithEvents btnPelisModificar As Button
    Friend WithEvents btnPelisBaja As Button
    Friend WithEvents btnPelisCrear As Button
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents Anyo As DataGridViewTextBoxColumn
    Friend WithEvents Director As DataGridViewTextBoxColumn
    Friend WithEvents CodGenero As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataSet1 As EMPRESADataSet
End Class
