<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionPeliculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStripContainer3.LeftToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionUsuariosToolStripMenuItem, Me.GestionPeliculasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(126, 175)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionPeliculasToolStripMenuItem
        '
        Me.GestionPeliculasToolStripMenuItem.Checked = True
        Me.GestionPeliculasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GestionPeliculasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.CatalogoProveedoresToolStripMenuItem})
        Me.GestionPeliculasToolStripMenuItem.Name = "GestionPeliculasToolStripMenuItem"
        Me.GestionPeliculasToolStripMenuItem.Size = New System.Drawing.Size(119, 19)
        Me.GestionPeliculasToolStripMenuItem.Text = "Peliculas"
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 19)
        Me.GestionUsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(119, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(800, 425)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripContainer2.Location = New System.Drawing.Point(8, 8)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(150, 175)
        Me.ToolStripContainer2.TabIndex = 2
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(24, 175)
        '
        'ToolStripContainer3.LeftToolStripPanel
        '
        Me.ToolStripContainer3.LeftToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer3.Location = New System.Drawing.Point(8, 8)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(150, 175)
        Me.ToolStripContainer3.TabIndex = 3
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CatalogoToolStripMenuItem.Text = "NuestroCatalogo"
        '
        'CatalogoProveedoresToolStripMenuItem
        '
        Me.CatalogoProveedoresToolStripMenuItem.Name = "CatalogoProveedoresToolStripMenuItem"
        Me.CatalogoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CatalogoProveedoresToolStripMenuItem.Text = "CatalogoProveedores"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStripContainer3)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStripContainer3.LeftToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.LeftToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionPeliculasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents ToolStripContainer3 As ToolStripContainer
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoProveedoresToolStripMenuItem As ToolStripMenuItem
End Class
