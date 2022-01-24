<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GridUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnDetalles = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        CType(Me.GridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridUsuarios
        '
        Me.GridUsuarios.AllowUserToAddRows = False
        Me.GridUsuarios.AllowUserToDeleteRows = False
        Me.GridUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.GridUsuarios.Name = "GridUsuarios"
        Me.GridUsuarios.ReadOnly = True
        Me.GridUsuarios.Size = New System.Drawing.Size(527, 214)
        Me.GridUsuarios.TabIndex = 0
        '
        'BtnDetalles
        '
        Me.BtnDetalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDetalles.Location = New System.Drawing.Point(12, 239)
        Me.BtnDetalles.Name = "BtnDetalles"
        Me.BtnDetalles.Size = New System.Drawing.Size(75, 23)
        Me.BtnDetalles.TabIndex = 1
        Me.BtnDetalles.Text = "Detalles"
        Me.BtnDetalles.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnModificar.Location = New System.Drawing.Point(93, 239)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBaja
        '
        Me.BtnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnBaja.Location = New System.Drawing.Point(174, 239)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 3
        Me.BtnBaja.Text = "Dar de Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRegistrar.AutoSize = True
        Me.BtnRegistrar.Location = New System.Drawing.Point(255, 239)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(82, 23)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "Añadir Cliente"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 274)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnBaja)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnDetalles)
        Me.Controls.Add(Me.GridUsuarios)
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        CType(Me.GridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridUsuarios As DataGridView
    Friend WithEvents BtnDetalles As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnBaja As Button
    Friend WithEvents BtnRegistrar As Button
End Class
