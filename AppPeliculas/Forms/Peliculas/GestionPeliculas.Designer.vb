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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonFiltrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnGuardarCsv = New System.Windows.Forms.Button()
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
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(665, 351)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar en JSON"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\Users\in2dam-b\Desktop"
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.ButtonFiltrar.Location = New System.Drawing.Point(287, 434)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(123, 23)
        Me.ButtonFiltrar.TabIndex = 7
        Me.ButtonFiltrar.Text = "Filtrar"
        Me.ButtonFiltrar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 407)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(139, 407)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 434)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 434)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'btnGuardarCsv
        '
        Me.btnGuardarCsv.Location = New System.Drawing.Point(665, 380)
        Me.btnGuardarCsv.Name = "btnGuardarCsv"
        Me.btnGuardarCsv.Size = New System.Drawing.Size(123, 23)
        Me.btnGuardarCsv.TabIndex = 12
        Me.btnGuardarCsv.Text = "Guardar en CSV"
        Me.btnGuardarCsv.UseVisualStyleBackColor = True
        '
        'GestionPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.btnGuardarCsv)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonFiltrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.gridViewPelis)
        Me.Controls.Add(Me.btnPelisCrear)
        Me.Controls.Add(Me.btnPelisBaja)
        Me.Controls.Add(Me.btnPelisModificar)
        Me.Controls.Add(Me.btnPelisDetalles)
        Me.Name = "GestionPeliculas"
        Me.Text = "GestionPeliculas"
        CType(Me.gridViewPelis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPelisDetalles As Button
    Friend WithEvents btnPelisModificar As Button
    Friend WithEvents btnPelisBaja As Button
    Friend WithEvents btnPelisCrear As Button
    Friend WithEvents gridViewPelis As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonFiltrar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnGuardarCsv As Button
End Class
