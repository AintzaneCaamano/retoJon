<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Me.BtnRegistrarUsuario = New System.Windows.Forms.Button()
        Me.ComboMunicipio = New System.Windows.Forms.ComboBox()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.PasswordGroup = New System.Windows.Forms.GroupBox()
        Me.PasswordTest = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblPasswordTest = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ComboProvincia = New System.Windows.Forms.ComboBox()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.TextCP = New System.Windows.Forms.TextBox()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.TextApellido2 = New System.Windows.Forms.TextBox()
        Me.LblApellido2 = New System.Windows.Forms.Label()
        Me.TextApellido1 = New System.Windows.Forms.TextBox()
        Me.LblApellido1 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PasswordGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRegistrarUsuario
        '
        Me.BtnRegistrarUsuario.AutoSize = True
        Me.BtnRegistrarUsuario.Location = New System.Drawing.Point(96, 326)
        Me.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario"
        Me.BtnRegistrarUsuario.Size = New System.Drawing.Size(121, 23)
        Me.BtnRegistrarUsuario.TabIndex = 37
        Me.BtnRegistrarUsuario.Text = "Registrar"
        Me.BtnRegistrarUsuario.UseVisualStyleBackColor = True
        '
        'ComboMunicipio
        '
        Me.ComboMunicipio.FormattingEnabled = True
        Me.ComboMunicipio.Location = New System.Drawing.Point(96, 167)
        Me.ComboMunicipio.Name = "ComboMunicipio"
        Me.ComboMunicipio.Size = New System.Drawing.Size(150, 21)
        Me.ComboMunicipio.TabIndex = 36
        '
        'LblMunicipio
        '
        Me.LblMunicipio.AutoSize = True
        Me.LblMunicipio.Location = New System.Drawing.Point(12, 170)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(58, 13)
        Me.LblMunicipio.TabIndex = 35
        Me.LblMunicipio.Text = "Municipio: "
        '
        'PasswordGroup
        '
        Me.PasswordGroup.Controls.Add(Me.PasswordTest)
        Me.PasswordGroup.Controls.Add(Me.LblPassword)
        Me.PasswordGroup.Controls.Add(Me.LblPasswordTest)
        Me.PasswordGroup.Controls.Add(Me.Password)
        Me.PasswordGroup.Location = New System.Drawing.Point(15, 217)
        Me.PasswordGroup.Name = "PasswordGroup"
        Me.PasswordGroup.Size = New System.Drawing.Size(300, 83)
        Me.PasswordGroup.TabIndex = 34
        Me.PasswordGroup.TabStop = False
        '
        'PasswordTest
        '
        Me.PasswordTest.Location = New System.Drawing.Point(131, 45)
        Me.PasswordTest.Name = "PasswordTest"
        Me.PasswordTest.Size = New System.Drawing.Size(150, 20)
        Me.PasswordTest.TabIndex = 16
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
        'LblPasswordTest
        '
        Me.LblPasswordTest.AutoSize = True
        Me.LblPasswordTest.Location = New System.Drawing.Point(12, 48)
        Me.LblPasswordTest.Name = "LblPasswordTest"
        Me.LblPasswordTest.Size = New System.Drawing.Size(113, 13)
        Me.LblPasswordTest.TabIndex = 15
        Me.LblPasswordTest.Text = "Confirmar contraseña: "
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(131, 19)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(150, 20)
        Me.Password.TabIndex = 11
        '
        'ComboProvincia
        '
        Me.ComboProvincia.FormattingEnabled = True
        Me.ComboProvincia.Location = New System.Drawing.Point(96, 140)
        Me.ComboProvincia.Name = "ComboProvincia"
        Me.ComboProvincia.Size = New System.Drawing.Size(150, 21)
        Me.ComboProvincia.TabIndex = 32
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(12, 143)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(57, 13)
        Me.LblProvincia.TabIndex = 31
        Me.LblProvincia.Text = "Provincia: "
        '
        'TextCP
        '
        Me.TextCP.Location = New System.Drawing.Point(96, 114)
        Me.TextCP.Name = "TextCP"
        Me.TextCP.Size = New System.Drawing.Size(50, 20)
        Me.TextCP.TabIndex = 30
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(12, 117)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(78, 13)
        Me.LblCP.TabIndex = 29
        Me.LblCP.Text = "Código Postal: "
        '
        'TextDireccion
        '
        Me.TextDireccion.Location = New System.Drawing.Point(96, 88)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(200, 20)
        Me.TextDireccion.TabIndex = 28
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(12, 91)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(58, 13)
        Me.LblDireccion.TabIndex = 27
        Me.LblDireccion.Text = "Dirección: "
        '
        'TextApellido2
        '
        Me.TextApellido2.Location = New System.Drawing.Point(96, 62)
        Me.TextApellido2.Name = "TextApellido2"
        Me.TextApellido2.Size = New System.Drawing.Size(100, 20)
        Me.TextApellido2.TabIndex = 26
        '
        'LblApellido2
        '
        Me.LblApellido2.AutoSize = True
        Me.LblApellido2.Location = New System.Drawing.Point(12, 65)
        Me.LblApellido2.Name = "LblApellido2"
        Me.LblApellido2.Size = New System.Drawing.Size(71, 13)
        Me.LblApellido2.TabIndex = 25
        Me.LblApellido2.Text = "2do Apellido: "
        '
        'TextApellido1
        '
        Me.TextApellido1.Location = New System.Drawing.Point(96, 36)
        Me.TextApellido1.Name = "TextApellido1"
        Me.TextApellido1.Size = New System.Drawing.Size(100, 20)
        Me.TextApellido1.TabIndex = 24
        '
        'LblApellido1
        '
        Me.LblApellido1.AutoSize = True
        Me.LblApellido1.Location = New System.Drawing.Point(12, 39)
        Me.LblApellido1.Name = "LblApellido1"
        Me.LblApellido1.Size = New System.Drawing.Size(68, 13)
        Me.LblApellido1.TabIndex = 23
        Me.LblApellido1.Text = "1er Apellido: "
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(96, 10)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextNombre.TabIndex = 22
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(12, 13)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(50, 13)
        Me.LblNombre.TabIndex = 21
        Me.LblNombre.Text = "Nombre: "
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 361)
        Me.Controls.Add(Me.BtnRegistrarUsuario)
        Me.Controls.Add(Me.ComboMunicipio)
        Me.Controls.Add(Me.LblMunicipio)
        Me.Controls.Add(Me.PasswordGroup)
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
        Me.Name = "RegistrarUsuario"
        Me.Text = "Registrar Usuario"
        Me.PasswordGroup.ResumeLayout(False)
        Me.PasswordGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrarUsuario As Button
    Friend WithEvents ComboMunicipio As ComboBox
    Friend WithEvents LblMunicipio As Label
    Friend WithEvents PasswordGroup As GroupBox
    Friend WithEvents PasswordTest As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblPasswordTest As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents ComboProvincia As ComboBox
    Friend WithEvents LblProvincia As Label
    Friend WithEvents TextCP As TextBox
    Friend WithEvents LblCP As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents TextApellido2 As TextBox
    Friend WithEvents LblApellido2 As Label
    Friend WithEvents TextApellido1 As TextBox
    Friend WithEvents LblApellido1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents LblNombre As Label
End Class
