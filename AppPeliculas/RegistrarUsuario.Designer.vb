<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
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
        Me.BtnUpdateUsuario = New System.Windows.Forms.Button()
        Me.ComboMunicipio = New System.Windows.Forms.ComboBox()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.UpdatePasswordGroup = New System.Windows.Forms.GroupBox()
        Me.UpdatePasswordTest = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblPasswordTest = New System.Windows.Forms.Label()
        Me.UpdatePassword = New System.Windows.Forms.TextBox()
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
        Me.UpdatePasswordGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdateUsuario
        '
        Me.BtnUpdateUsuario.AutoSize = True
        Me.BtnUpdateUsuario.Location = New System.Drawing.Point(96, 326)
        Me.BtnUpdateUsuario.Name = "BtnUpdateUsuario"
        Me.BtnUpdateUsuario.Size = New System.Drawing.Size(121, 23)
        Me.BtnUpdateUsuario.TabIndex = 37
        Me.BtnUpdateUsuario.Text = "Registrar"
        Me.BtnUpdateUsuario.UseVisualStyleBackColor = True
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
        'UpdatePasswordGroup
        '
        Me.UpdatePasswordGroup.Controls.Add(Me.UpdatePasswordTest)
        Me.UpdatePasswordGroup.Controls.Add(Me.LblPassword)
        Me.UpdatePasswordGroup.Controls.Add(Me.LblPasswordTest)
        Me.UpdatePasswordGroup.Controls.Add(Me.UpdatePassword)
        Me.UpdatePasswordGroup.Location = New System.Drawing.Point(15, 217)
        Me.UpdatePasswordGroup.Name = "UpdatePasswordGroup"
        Me.UpdatePasswordGroup.Size = New System.Drawing.Size(300, 83)
        Me.UpdatePasswordGroup.TabIndex = 34
        Me.UpdatePasswordGroup.TabStop = False
        Me.UpdatePasswordGroup.Visible = False
        '
        'UpdatePasswordTest
        '
        Me.UpdatePasswordTest.Location = New System.Drawing.Point(131, 45)
        Me.UpdatePasswordTest.Name = "UpdatePasswordTest"
        Me.UpdatePasswordTest.Size = New System.Drawing.Size(150, 20)
        Me.UpdatePasswordTest.TabIndex = 16
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
        'UpdatePassword
        '
        Me.UpdatePassword.Location = New System.Drawing.Point(131, 19)
        Me.UpdatePassword.Name = "UpdatePassword"
        Me.UpdatePassword.Size = New System.Drawing.Size(150, 20)
        Me.UpdatePassword.TabIndex = 11
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
        Me.Controls.Add(Me.BtnUpdateUsuario)
        Me.Controls.Add(Me.ComboMunicipio)
        Me.Controls.Add(Me.LblMunicipio)
        Me.Controls.Add(Me.UpdatePasswordGroup)
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
        Me.Text = "RegistrarUsuario"
        Me.UpdatePasswordGroup.ResumeLayout(False)
        Me.UpdatePasswordGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdateUsuario As Button
    Friend WithEvents ComboMunicipio As ComboBox
    Friend WithEvents LblMunicipio As Label
    Friend WithEvents UpdatePasswordGroup As GroupBox
    Friend WithEvents UpdatePasswordTest As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblPasswordTest As Label
    Friend WithEvents UpdatePassword As TextBox
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
