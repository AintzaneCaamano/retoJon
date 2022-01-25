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
        Me.components = New System.ComponentModel.Container()
        Me.BtnFormUsuarios = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnFormPeliculas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFormUsuarios
        '
        Me.BtnFormUsuarios.AutoSize = True
        Me.BtnFormUsuarios.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormUsuarios.Location = New System.Drawing.Point(63, 60)
        Me.BtnFormUsuarios.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnFormUsuarios.Name = "BtnFormUsuarios"
        Me.BtnFormUsuarios.Size = New System.Drawing.Size(200, 50)
        Me.BtnFormUsuarios.TabIndex = 0
        Me.BtnFormUsuarios.Text = "Gestionar Clientes"
        Me.BtnFormUsuarios.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnFormPeliculas
        '
        Me.BtnFormPeliculas.AutoSize = True
        Me.BtnFormPeliculas.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormPeliculas.Location = New System.Drawing.Point(63, 150)
        Me.BtnFormPeliculas.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnFormPeliculas.Name = "BtnFormPeliculas"
        Me.BtnFormPeliculas.Size = New System.Drawing.Size(201, 50)
        Me.BtnFormPeliculas.TabIndex = 1
        Me.BtnFormPeliculas.Text = "Gestionar Películas"
        Me.BtnFormPeliculas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(63, 240)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(20)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(200, 50)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 361)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnFormPeliculas)
        Me.Controls.Add(Me.BtnFormUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Principal"
        Me.Text = "Video Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFormUsuarios As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BtnFormPeliculas As Button
    Friend WithEvents BtnSalir As Button
End Class
