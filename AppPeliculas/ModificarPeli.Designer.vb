﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPeli
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
        Me.ComboBoxGeneros = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TextBtxtBoxDirector = New System.Windows.Forms.TextBox()
        Me.txtBoxPrecio = New System.Windows.Forms.TextBox()
        Me.txtBoxPais = New System.Windows.Forms.TextBox()
        Me.txtBoxProductora = New System.Windows.Forms.TextBox()
        Me.txtBoxAnyo = New System.Windows.Forms.TextBox()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblProductora = New System.Windows.Forms.Label()
        Me.lblAnyo = New System.Windows.Forms.Label()
        Me.txtBoxDuracion = New System.Windows.Forms.TextBox()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtBoxTitulo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBoxGeneros
        '
        Me.ComboBoxGeneros.FormattingEnabled = True
        Me.ComboBoxGeneros.Location = New System.Drawing.Point(109, 247)
        Me.ComboBoxGeneros.Name = "ComboBoxGeneros"
        Me.ComboBoxGeneros.Size = New System.Drawing.Size(294, 21)
        Me.ComboBoxGeneros.TabIndex = 34
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(33, 315)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(370, 23)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Dar de Alta"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TextBtxtBoxDirector
        '
        Me.TextBtxtBoxDirector.Location = New System.Drawing.Point(109, 210)
        Me.TextBtxtBoxDirector.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.TextBtxtBoxDirector.Name = "TextBtxtBoxDirector"
        Me.TextBtxtBoxDirector.Size = New System.Drawing.Size(294, 20)
        Me.TextBtxtBoxDirector.TabIndex = 32
        '
        'txtBoxPrecio
        '
        Me.txtBoxPrecio.Location = New System.Drawing.Point(109, 179)
        Me.txtBoxPrecio.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtBoxPrecio.Name = "txtBoxPrecio"
        Me.txtBoxPrecio.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxPrecio.TabIndex = 31
        '
        'txtBoxPais
        '
        Me.txtBoxPais.Location = New System.Drawing.Point(109, 148)
        Me.txtBoxPais.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtBoxPais.Name = "txtBoxPais"
        Me.txtBoxPais.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxPais.TabIndex = 30
        '
        'txtBoxProductora
        '
        Me.txtBoxProductora.Location = New System.Drawing.Point(109, 117)
        Me.txtBoxProductora.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtBoxProductora.Name = "txtBoxProductora"
        Me.txtBoxProductora.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxProductora.TabIndex = 29
        '
        'txtBoxAnyo
        '
        Me.txtBoxAnyo.Location = New System.Drawing.Point(109, 86)
        Me.txtBoxAnyo.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.txtBoxAnyo.Name = "txtBoxAnyo"
        Me.txtBoxAnyo.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxAnyo.TabIndex = 28
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(30, 255)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 27
        Me.lblGenero.Text = "Genero"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Location = New System.Drawing.Point(30, 222)
        Me.lblDirector.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(44, 13)
        Me.lblDirector.TabIndex = 26
        Me.lblDirector.Text = "Director"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(30, 189)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 25
        Me.lblPrecio.Text = "Precio"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(30, 156)
        Me.lblPais.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(27, 13)
        Me.lblPais.TabIndex = 24
        Me.lblPais.Text = "Pais"
        '
        'lblProductora
        '
        Me.lblProductora.AutoSize = True
        Me.lblProductora.Location = New System.Drawing.Point(30, 123)
        Me.lblProductora.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblProductora.Name = "lblProductora"
        Me.lblProductora.Size = New System.Drawing.Size(59, 13)
        Me.lblProductora.TabIndex = 23
        Me.lblProductora.Text = "Productora"
        '
        'lblAnyo
        '
        Me.lblAnyo.AutoSize = True
        Me.lblAnyo.Location = New System.Drawing.Point(30, 90)
        Me.lblAnyo.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblAnyo.Name = "lblAnyo"
        Me.lblAnyo.Size = New System.Drawing.Size(26, 13)
        Me.lblAnyo.TabIndex = 22
        Me.lblAnyo.Text = "Año"
        '
        'txtBoxDuracion
        '
        Me.txtBoxDuracion.Location = New System.Drawing.Point(109, 55)
        Me.txtBoxDuracion.Margin = New System.Windows.Forms.Padding(100, 8, 3, 3)
        Me.txtBoxDuracion.Name = "txtBoxDuracion"
        Me.txtBoxDuracion.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxDuracion.TabIndex = 21
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(30, 57)
        Me.lblDuracion.Margin = New System.Windows.Forms.Padding(10, 20, 3, 0)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(50, 13)
        Me.lblDuracion.TabIndex = 20
        Me.lblDuracion.Text = "Duracion"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(30, 24)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lblTitulo.TabIndex = 19
        Me.lblTitulo.Text = "Titulo"
        '
        'txtBoxTitulo
        '
        Me.txtBoxTitulo.Location = New System.Drawing.Point(109, 24)
        Me.txtBoxTitulo.Margin = New System.Windows.Forms.Padding(100, 10, 3, 3)
        Me.txtBoxTitulo.MaxLength = 255
        Me.txtBoxTitulo.Name = "txtBoxTitulo"
        Me.txtBoxTitulo.Size = New System.Drawing.Size(294, 20)
        Me.txtBoxTitulo.TabIndex = 18
        '
        'ModificarPeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBoxGeneros)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TextBtxtBoxDirector)
        Me.Controls.Add(Me.txtBoxPrecio)
        Me.Controls.Add(Me.txtBoxPais)
        Me.Controls.Add(Me.txtBoxProductora)
        Me.Controls.Add(Me.txtBoxAnyo)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblProductora)
        Me.Controls.Add(Me.lblAnyo)
        Me.Controls.Add(Me.txtBoxDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtBoxTitulo)
        Me.Name = "ModificarPeli"
        Me.Text = "ModificarPeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxGeneros As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TextBtxtBoxDirector As TextBox
    Friend WithEvents txtBoxPrecio As TextBox
    Friend WithEvents txtBoxPais As TextBox
    Friend WithEvents txtBoxProductora As TextBox
    Friend WithEvents txtBoxAnyo As TextBox
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblDirector As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblProductora As Label
    Friend WithEvents lblAnyo As Label
    Friend WithEvents txtBoxDuracion As TextBox
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtBoxTitulo As TextBox
End Class
