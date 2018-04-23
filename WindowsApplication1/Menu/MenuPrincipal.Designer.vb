<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDePersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDePermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneracionMasivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDePersonasToolStripMenuItem, Me.MantenimientoDeUsuariosToolStripMenuItem, Me.MantenimientoDeRolesToolStripMenuItem, Me.MantenimientoDePermisosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(142, 25)
        Me.MenuToolStripMenuItem.Text = "Editar y Permisos"
        '
        'MantenimientoDePersonasToolStripMenuItem
        '
        Me.MantenimientoDePersonasToolStripMenuItem.Name = "MantenimientoDePersonasToolStripMenuItem"
        Me.MantenimientoDePersonasToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.MantenimientoDePersonasToolStripMenuItem.Text = "Mantenimiento de Personas"
        '
        'MantenimientoDeUsuariosToolStripMenuItem
        '
        Me.MantenimientoDeUsuariosToolStripMenuItem.Name = "MantenimientoDeUsuariosToolStripMenuItem"
        Me.MantenimientoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.MantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de usuarios"
        '
        'MantenimientoDeRolesToolStripMenuItem
        '
        Me.MantenimientoDeRolesToolStripMenuItem.Name = "MantenimientoDeRolesToolStripMenuItem"
        Me.MantenimientoDeRolesToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.MantenimientoDeRolesToolStripMenuItem.Text = "Mantenimiento de Roles"
        '
        'MantenimientoDePermisosToolStripMenuItem
        '
        Me.MantenimientoDePermisosToolStripMenuItem.Name = "MantenimientoDePermisosToolStripMenuItem"
        Me.MantenimientoDePermisosToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.MantenimientoDePermisosToolStripMenuItem.Text = "Mantenimiento de Permisos"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(275, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.GestionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionesToolStripMenuItem
        '
        Me.GestionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneracionMasivaToolStripMenuItem, Me.MantenimientoDeCuentasToolStripMenuItem, Me.ArchivoToolStripMenuItem})
        Me.GestionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionesToolStripMenuItem.Name = "GestionesToolStripMenuItem"
        Me.GestionesToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.GestionesToolStripMenuItem.Text = "Gestiones"
        '
        'GeneracionMasivaToolStripMenuItem
        '
        Me.GeneracionMasivaToolStripMenuItem.Name = "GeneracionMasivaToolStripMenuItem"
        Me.GeneracionMasivaToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.GeneracionMasivaToolStripMenuItem.Text = "Reportes"
        '
        'MantenimientoDeCuentasToolStripMenuItem
        '
        Me.MantenimientoDeCuentasToolStripMenuItem.Name = "MantenimientoDeCuentasToolStripMenuItem"
        Me.MantenimientoDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.MantenimientoDeCuentasToolStripMenuItem.Text = "Mantenimiento de Cuentas"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(267, 26)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(628, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(558, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usuario"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeRolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoDePersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MantenimientoDePermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneracionMasivaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeCuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
