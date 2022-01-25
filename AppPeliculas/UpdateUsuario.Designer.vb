<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateUsuario
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextApellido1 = New System.Windows.Forms.TextBox()
        Me.LblApellido1 = New System.Windows.Forms.Label()
        Me.TextApellido2 = New System.Windows.Forms.TextBox()
        Me.LblApellido2 = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TextCP = New System.Windows.Forms.TextBox()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.UpdatePassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.ComboProvincia = New System.Windows.Forms.ComboBox()
        Me.UpdatePasswordCheck = New System.Windows.Forms.CheckBox()
        Me.UpdatePasswordTest = New System.Windows.Forms.TextBox()
        Me.LblPasswordTest = New System.Windows.Forms.Label()
        Me.UpdatePasswordGroup = New System.Windows.Forms.GroupBox()
        Me.ComboMunicipio = New System.Windows.Forms.ComboBox()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.BtnUpdateUsuario = New System.Windows.Forms.Button()
        Me.UpdatePasswordGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(13, 13)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(50, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre: "
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(97, 10)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextNombre.TabIndex = 1
        '
        'TextApellido1
        '
        Me.TextApellido1.Location = New System.Drawing.Point(97, 36)
        Me.TextApellido1.Name = "TextApellido1"
        Me.TextApellido1.Size = New System.Drawing.Size(100, 20)
        Me.TextApellido1.TabIndex = 3
        '
        'LblApellido1
        '
        Me.LblApellido1.AutoSize = True
        Me.LblApellido1.Location = New System.Drawing.Point(13, 39)
        Me.LblApellido1.Name = "LblApellido1"
        Me.LblApellido1.Size = New System.Drawing.Size(68, 13)
        Me.LblApellido1.TabIndex = 2
        Me.LblApellido1.Text = "1er Apellido: "
        '
        'TextApellido2
        '
        Me.TextApellido2.Location = New System.Drawing.Point(97, 62)
        Me.TextApellido2.Name = "TextApellido2"
        Me.TextApellido2.Size = New System.Drawing.Size(100, 20)
        Me.TextApellido2.TabIndex = 5
        '
        'LblApellido2
        '
        Me.LblApellido2.AutoSize = True
        Me.LblApellido2.Location = New System.Drawing.Point(13, 65)
        Me.LblApellido2.Name = "LblApellido2"
        Me.LblApellido2.Size = New System.Drawing.Size(71, 13)
        Me.LblApellido2.TabIndex = 4
        Me.LblApellido2.Text = "2do Apellido: "
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(97, 88)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(200, 20)
        Me.TextDireccion.TabIndex = 7
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(13, 91)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(58, 13)
        Me.LblDireccion.TabIndex = 6
        Me.LblDireccion.Text = "Dirección: "
        '
        'TextCP
        '
        Me.TextCP.Location = New System.Drawing.Point(97, 114)
        Me.TextCP.Name = "TextCP"
        Me.TextCP.Size = New System.Drawing.Size(50, 20)
        Me.TextCP.TabIndex = 9
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(13, 117)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(78, 13)
        Me.LblCP.TabIndex = 8
        Me.LblCP.Text = "Código Postal: "
        '
        'UpdatePassword
        '
        Me.UpdatePassword.Location = New System.Drawing.Point(131, 19)
        Me.UpdatePassword.Name = "UpdatePassword"
        Me.UpdatePassword.Size = New System.Drawing.Size(150, 20)
        Me.UpdatePassword.TabIndex = 11
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(12, 22)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(67, 13)
        Me.LblPassword.TabIndex = 10
        Me.LblPassword.Text = "Contraseña: "
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(13, 143)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(57, 13)
        Me.LblProvincia.TabIndex = 12
        Me.LblProvincia.Text = "Provincia: "
        '
        'ComboProvincia
        '
        Me.ComboProvincia.FormattingEnabled = True
        Me.ComboProvincia.Location = New System.Drawing.Point(97, 140)
        Me.ComboProvincia.Name = "ComboProvincia"
        Me.ComboProvincia.Size = New System.Drawing.Size(150, 21)
        Me.ComboProvincia.TabIndex = 13
        '
        'UpdatePasswordCheck
        '
        Me.UpdatePasswordCheck.AutoSize = True
        Me.UpdatePasswordCheck.Location = New System.Drawing.Point(16, 194)
        Me.UpdatePasswordCheck.Name = "UpdatePasswordCheck"
        Me.UpdatePasswordCheck.Size = New System.Drawing.Size(120, 17)
        Me.UpdatePasswordCheck.TabIndex = 14
        Me.UpdatePasswordCheck.Text = "Cambiar contraseña"
        Me.UpdatePasswordCheck.UseVisualStyleBackColor = True
        '
        'UpdatePasswordTest
        '
        Me.UpdatePasswordTest.Location = New System.Drawing.Point(131, 45)
        Me.UpdatePasswordTest.Name = "UpdatePasswordTest"
        Me.UpdatePasswordTest.Size = New System.Drawing.Size(150, 20)
        Me.UpdatePasswordTest.TabIndex = 16
        '
        'LblPasswordTest
        '
        Me.LblPasswordTest.AutoSize = True
        Me.LblPasswordTest.Location = New System.Drawing.Point(12, 48)
        Me.LblPasswordTest.Name = "LblPasswordTest"
        Me.LblPasswordTest.Size = New System.Drawing.Size(113, 13)
        Me.LblPasswordTest.TabIndex = 15
        Me.LblPasswordTest.Text = "Confirmar contraseña: "
        '
        'UpdatePasswordGroup
        '
        Me.UpdatePasswordGroup.Controls.Add(Me.UpdatePasswordTest)
        Me.UpdatePasswordGroup.Controls.Add(Me.LblPassword)
        Me.UpdatePasswordGroup.Controls.Add(Me.LblPasswordTest)
        Me.UpdatePasswordGroup.Controls.Add(Me.UpdatePassword)
        Me.UpdatePasswordGroup.Location = New System.Drawing.Point(16, 217)
        Me.UpdatePasswordGroup.Name = "UpdatePasswordGroup"
        Me.UpdatePasswordGroup.Size = New System.Drawing.Size(300, 83)
        Me.UpdatePasswordGroup.TabIndex = 17
        Me.UpdatePasswordGroup.TabStop = False
        Me.UpdatePasswordGroup.Visible = False
        '
        'ComboMunicipio
        '
        Me.ComboMunicipio.FormattingEnabled = True
        Me.ComboMunicipio.Location = New System.Drawing.Point(97, 167)
        Me.ComboMunicipio.Name = "ComboMunicipio"
        Me.ComboMunicipio.Size = New System.Drawing.Size(150, 21)
        Me.ComboMunicipio.TabIndex = 19
        '
        'LblMunicipio
        '
        Me.LblMunicipio.AutoSize = True
        Me.LblMunicipio.Location = New System.Drawing.Point(13, 170)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(58, 13)
        Me.LblMunicipio.TabIndex = 18
        Me.LblMunicipio.Text = "Municipio: "
        '
        'BtnUpdateUsuario
        '
        Me.BtnUpdateUsuario.AutoSize = True
        Me.BtnUpdateUsuario.Location = New System.Drawing.Point(97, 326)
        Me.BtnUpdateUsuario.Name = "BtnUpdateUsuario"
        Me.BtnUpdateUsuario.Size = New System.Drawing.Size(121, 23)
        Me.BtnUpdateUsuario.TabIndex = 20
        Me.BtnUpdateUsuario.Text = "Actualizar Información"
        Me.BtnUpdateUsuario.UseVisualStyleBackColor = True
        '
        'UpdateUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 361)
        Me.Controls.Add(Me.BtnUpdateUsuario)
        Me.Controls.Add(Me.ComboMunicipio)
        Me.Controls.Add(Me.LblMunicipio)
        Me.Controls.Add(Me.UpdatePasswordGroup)
        Me.Controls.Add(Me.UpdatePasswordCheck)
        Me.Controls.Add(Me.ComboProvincia)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.TextCP)
        Me.Controls.Add(Me.LblCP)
        Me.Controls.Add(Me.TextDireccion)
        Me.Controls.Add(Me.LblDireccion)
        Me.Controls.Add(Me.TextApellido2)
        Me.Controls.Add(Me.LblApellido2)
        Me.Controls.Add(Me.TextApellido1)
        Me.Controls.Add(Me.LblApellido1)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UpdateUsuario"
        Me.Text = "Modificar Usuario"
        Me.UpdatePasswordGroup.ResumeLayout(False)
        Me.UpdatePasswordGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextApellido1 As TextBox
    Friend WithEvents LblApellido1 As Label
    Friend WithEvents TextApellido2 As TextBox
    Friend WithEvents LblApellido2 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TextCP As TextBox
    Friend WithEvents LblCP As Label
    Friend WithEvents UpdatePassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents ComboProvincia As ComboBox
    Friend WithEvents UpdatePasswordCheck As CheckBox
    Friend WithEvents UpdatePasswordTest As TextBox
    Friend WithEvents LblPasswordTest As Label
    Friend WithEvents UpdatePasswordGroup As GroupBox
    Friend WithEvents ComboMunicipio As ComboBox
    Friend WithEvents LblMunicipio As Label
    Friend WithEvents BtnUpdateUsuario As Button
End Class
