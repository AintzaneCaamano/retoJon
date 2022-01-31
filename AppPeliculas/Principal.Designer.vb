<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.BtnFormClientes = New System.Windows.Forms.Button()
        Me.BtnFormPeliculas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFormClientes
        '
        Me.BtnFormClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFormClientes.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormClientes.Location = New System.Drawing.Point(47, 39)
        Me.BtnFormClientes.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnFormClientes.Name = "BtnFormClientes"
        Me.BtnFormClientes.Size = New System.Drawing.Size(200, 60)
        Me.BtnFormClientes.TabIndex = 0
        Me.BtnFormClientes.Text = "Gestionar Clientes"
        Me.BtnFormClientes.UseVisualStyleBackColor = True
        '
        'BtnFormPeliculas
        '
        Me.BtnFormPeliculas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFormPeliculas.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormPeliculas.Location = New System.Drawing.Point(47, 129)
        Me.BtnFormPeliculas.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnFormPeliculas.Name = "BtnFormPeliculas"
        Me.BtnFormPeliculas.Size = New System.Drawing.Size(200, 60)
        Me.BtnFormPeliculas.TabIndex = 1
        Me.BtnFormPeliculas.Text = "Gestionar Películas"
        Me.BtnFormPeliculas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(47, 219)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(200, 60)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 321)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnFormPeliculas)
        Me.Controls.Add(Me.BtnFormClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Video Club"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFormClientes As Button
    Friend WithEvents BtnFormPeliculas As Button
    Friend WithEvents BtnSalir As Button
End Class
