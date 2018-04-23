<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNvoRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNvoRol))
        Me.TabPageEliminar = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPageEditar = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnActualizarEditar = New System.Windows.Forms.Button()
        Me.txbDescripcionEditar = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txbNombreEditar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPageAgregar = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.GroupBoxNvoRol = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabPageEliminar.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageEditar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBoxNvoRol.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageEliminar
        '
        Me.TabPageEliminar.Controls.Add(Me.Button8)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox6)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox3)
        Me.TabPageEliminar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEliminar.Name = "TabPageEliminar"
        Me.TabPageEliminar.Size = New System.Drawing.Size(761, 410)
        Me.TabPageEliminar.TabIndex = 2
        Me.TabPageEliminar.Text = "Eliminar"
        Me.TabPageEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(324, 122)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(393, 128)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Eliminar Rol"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(53, 54)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 30)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Refrescar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(209, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 30)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Roles"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(6, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 238)
        Me.ListBox1.TabIndex = 0
        '
        'TabPageEditar
        '
        Me.TabPageEditar.Controls.Add(Me.Button7)
        Me.TabPageEditar.Controls.Add(Me.GroupBox2)
        Me.TabPageEditar.Controls.Add(Me.GroupBox1)
        Me.TabPageEditar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEditar.Name = "TabPageEditar"
        Me.TabPageEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEditar.Size = New System.Drawing.Size(761, 410)
        Me.TabPageEditar.TabIndex = 1
        Me.TabPageEditar.Text = "Editar"
        Me.TabPageEditar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Roles"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(6, 22)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(220, 238)
        Me.ListBox2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnActualizarEditar)
        Me.GroupBox1.Controls.Add(Me.txbDescripcionEditar)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txbNombreEditar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(321, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 257)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Rol"
        '
        'btnActualizarEditar
        '
        Me.btnActualizarEditar.Enabled = False
        Me.btnActualizarEditar.Location = New System.Drawing.Point(218, 170)
        Me.btnActualizarEditar.Name = "btnActualizarEditar"
        Me.btnActualizarEditar.Size = New System.Drawing.Size(102, 30)
        Me.btnActualizarEditar.TabIndex = 2
        Me.btnActualizarEditar.Text = "Actualizar"
        Me.btnActualizarEditar.UseVisualStyleBackColor = True
        '
        'txbDescripcionEditar
        '
        Me.txbDescripcionEditar.Enabled = False
        Me.txbDescripcionEditar.Location = New System.Drawing.Point(163, 91)
        Me.txbDescripcionEditar.Multiline = True
        Me.txbDescripcionEditar.Name = "txbDescripcionEditar"
        Me.txbDescripcionEditar.Size = New System.Drawing.Size(178, 50)
        Me.txbDescripcionEditar.TabIndex = 12
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(77, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 30)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txbNombreEditar
        '
        Me.txbNombreEditar.Enabled = False
        Me.txbNombreEditar.Location = New System.Drawing.Point(163, 46)
        Me.txbNombreEditar.Name = "txbNombreEditar"
        Me.txbNombreEditar.Size = New System.Drawing.Size(178, 24)
        Me.txbNombreEditar.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'TabPageAgregar
        '
        Me.TabPageAgregar.Controls.Add(Me.Button6)
        Me.TabPageAgregar.Controls.Add(Me.GroupBox4)
        Me.TabPageAgregar.Controls.Add(Me.GroupBoxNvoRol)
        Me.TabPageAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageAgregar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageAgregar.Name = "TabPageAgregar"
        Me.TabPageAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAgregar.Size = New System.Drawing.Size(761, 410)
        Me.TabPageAgregar.TabIndex = 0
        Me.TabPageAgregar.Text = "Agregar"
        Me.TabPageAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado De Roles"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 18
        Me.ListBox3.Location = New System.Drawing.Point(6, 21)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(220, 238)
        Me.ListBox3.TabIndex = 9
        '
        'GroupBoxNvoRol
        '
        Me.GroupBoxNvoRol.Controls.Add(Me.Button1)
        Me.GroupBoxNvoRol.Controls.Add(Me.txbDescripcion)
        Me.GroupBoxNvoRol.Controls.Add(Me.Label2)
        Me.GroupBoxNvoRol.Controls.Add(Me.txbNombre)
        Me.GroupBoxNvoRol.Controls.Add(Me.Label1)
        Me.GroupBoxNvoRol.Controls.Add(Me.Button2)
        Me.GroupBoxNvoRol.Location = New System.Drawing.Point(321, 44)
        Me.GroupBoxNvoRol.Name = "GroupBoxNvoRol"
        Me.GroupBoxNvoRol.Size = New System.Drawing.Size(393, 257)
        Me.GroupBoxNvoRol.TabIndex = 8
        Me.GroupBoxNvoRol.TabStop = False
        Me.GroupBoxNvoRol.Text = "Nuevo Rol"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txbDescripcion
        '
        Me.txbDescripcion.Location = New System.Drawing.Point(149, 93)
        Me.txbDescripcion.Multiline = True
        Me.txbDescripcion.Name = "txbDescripcion"
        Me.txbDescripcion.Size = New System.Drawing.Size(178, 50)
        Me.txbDescripcion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(149, 48)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(178, 24)
        Me.txbNombre.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(62, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageAgregar)
        Me.TabControl1.Controls.Add(Me.TabPageEditar)
        Me.TabControl1.Controls.Add(Me.TabPageEliminar)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(769, 443)
        Me.TabControl1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(644, 353)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 30)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Cerrar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(644, 353)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(73, 30)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Cerrar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(644, 353)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(73, 30)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'FrmNvoRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmNvoRol"
        Me.Text = "Mantenimiento de Roles"
        Me.TabPageEliminar.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPageEditar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageAgregar.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBoxNvoRol.ResumeLayout(False)
        Me.GroupBoxNvoRol.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabPageEliminar As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabPageEditar As System.Windows.Forms.TabPage
    Friend WithEvents txbDescripcionEditar As System.Windows.Forms.TextBox
    Friend WithEvents txbNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnActualizarEditar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TabPageAgregar As System.Windows.Forms.TabPage
    Friend WithEvents txbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBoxNvoRol As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
