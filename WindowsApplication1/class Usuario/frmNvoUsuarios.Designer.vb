<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNvoUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNvoUsuarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbPageAgregar = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxRolAgregar = New System.Windows.Forms.ComboBox()
        Me.txbConfirmarAgregar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbContraseñaAgregar = New System.Windows.Forms.TextBox()
        Me.txbUsuariAgregar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAceptarAgregar = New System.Windows.Forms.Button()
        Me.tabPageEditar = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstbMostrarEditar = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbRolEditar = New System.Windows.Forms.Label()
        Me.cbxRolEditar = New System.Windows.Forms.ComboBox()
        Me.txbConfirmarEditar = New System.Windows.Forms.TextBox()
        Me.lbConfirmarEditar = New System.Windows.Forms.Label()
        Me.lbContraseñaEditar = New System.Windows.Forms.Label()
        Me.lbUsuarioEditar = New System.Windows.Forms.Label()
        Me.txbContraseñaEditar = New System.Windows.Forms.TextBox()
        Me.txbUsuarioEditar = New System.Windows.Forms.TextBox()
        Me.BtnGuardarEditar = New System.Windows.Forms.Button()
        Me.BtnModificarEditar = New System.Windows.Forms.Button()
        Me.TabPageEliminar = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbnRefrescarEliminar = New System.Windows.Forms.Button()
        Me.btnEliminarEliminar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbxmostraEliminar = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbPageAgregar.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabPageEditar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageEliminar.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPageAgregar)
        Me.TabControl1.Controls.Add(Me.tabPageEditar)
        Me.TabControl1.Controls.Add(Me.TabPageEliminar)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 452)
        Me.TabControl1.TabIndex = 0
        '
        'tbPageAgregar
        '
        Me.tbPageAgregar.Controls.Add(Me.Button8)
        Me.tbPageAgregar.Controls.Add(Me.GroupBox3)
        Me.tbPageAgregar.Controls.Add(Me.GroupBox1)
        Me.tbPageAgregar.Location = New System.Drawing.Point(4, 29)
        Me.tbPageAgregar.Name = "tbPageAgregar"
        Me.tbPageAgregar.Size = New System.Drawing.Size(755, 419)
        Me.tbPageAgregar.TabIndex = 0
        Me.tbPageAgregar.Text = "Agregar "
        Me.tbPageAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 309)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista De Usuarios"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(6, 23)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 274)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxRolAgregar)
        Me.GroupBox1.Controls.Add(Me.txbConfirmarAgregar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txbContraseñaAgregar)
        Me.GroupBox1.Controls.Add(Me.txbUsuariAgregar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnAceptarAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(352, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 309)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Nuevo Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rol"
        '
        'cbxRolAgregar
        '
        Me.cbxRolAgregar.FormattingEnabled = True
        Me.cbxRolAgregar.Location = New System.Drawing.Point(139, 89)
        Me.cbxRolAgregar.Name = "cbxRolAgregar"
        Me.cbxRolAgregar.Size = New System.Drawing.Size(194, 26)
        Me.cbxRolAgregar.TabIndex = 1
        '
        'txbConfirmarAgregar
        '
        Me.txbConfirmarAgregar.Location = New System.Drawing.Point(138, 175)
        Me.txbConfirmarAgregar.Name = "txbConfirmarAgregar"
        Me.txbConfirmarAgregar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbConfirmarAgregar.Size = New System.Drawing.Size(196, 24)
        Me.txbConfirmarAgregar.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirmar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'txbContraseñaAgregar
        '
        Me.txbContraseñaAgregar.Location = New System.Drawing.Point(137, 131)
        Me.txbContraseñaAgregar.Name = "txbContraseñaAgregar"
        Me.txbContraseñaAgregar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContraseñaAgregar.Size = New System.Drawing.Size(196, 24)
        Me.txbContraseñaAgregar.TabIndex = 3
        '
        'txbUsuariAgregar
        '
        Me.txbUsuariAgregar.Location = New System.Drawing.Point(137, 44)
        Me.txbUsuariAgregar.Name = "txbUsuariAgregar"
        Me.txbUsuariAgregar.Size = New System.Drawing.Size(196, 24)
        Me.txbUsuariAgregar.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(220, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAceptarAgregar
        '
        Me.btnAceptarAgregar.Location = New System.Drawing.Point(46, 251)
        Me.btnAceptarAgregar.Name = "btnAceptarAgregar"
        Me.btnAceptarAgregar.Size = New System.Drawing.Size(102, 30)
        Me.btnAceptarAgregar.TabIndex = 1
        Me.btnAceptarAgregar.Text = "Aceptar"
        Me.btnAceptarAgregar.UseVisualStyleBackColor = True
        '
        'tabPageEditar
        '
        Me.tabPageEditar.Controls.Add(Me.Button1)
        Me.tabPageEditar.Controls.Add(Me.GroupBox4)
        Me.tabPageEditar.Controls.Add(Me.GroupBox2)
        Me.tabPageEditar.Location = New System.Drawing.Point(4, 29)
        Me.tabPageEditar.Name = "tabPageEditar"
        Me.tabPageEditar.Size = New System.Drawing.Size(755, 419)
        Me.tabPageEditar.TabIndex = 1
        Me.tabPageEditar.Text = "Editar "
        Me.tabPageEditar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstbMostrarEditar)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(39, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 309)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado de Usuarios"
        '
        'lstbMostrarEditar
        '
        Me.lstbMostrarEditar.FormattingEnabled = True
        Me.lstbMostrarEditar.ItemHeight = 18
        Me.lstbMostrarEditar.Location = New System.Drawing.Point(9, 24)
        Me.lstbMostrarEditar.Name = "lstbMostrarEditar"
        Me.lstbMostrarEditar.Size = New System.Drawing.Size(220, 274)
        Me.lstbMostrarEditar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbRolEditar)
        Me.GroupBox2.Controls.Add(Me.cbxRolEditar)
        Me.GroupBox2.Controls.Add(Me.txbConfirmarEditar)
        Me.GroupBox2.Controls.Add(Me.lbConfirmarEditar)
        Me.GroupBox2.Controls.Add(Me.lbContraseñaEditar)
        Me.GroupBox2.Controls.Add(Me.lbUsuarioEditar)
        Me.GroupBox2.Controls.Add(Me.txbContraseñaEditar)
        Me.GroupBox2.Controls.Add(Me.txbUsuarioEditar)
        Me.GroupBox2.Controls.Add(Me.BtnGuardarEditar)
        Me.GroupBox2.Controls.Add(Me.BtnModificarEditar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(355, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 309)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editar Usuario"
        '
        'lbRolEditar
        '
        Me.lbRolEditar.AutoSize = True
        Me.lbRolEditar.Location = New System.Drawing.Point(33, 94)
        Me.lbRolEditar.Name = "lbRolEditar"
        Me.lbRolEditar.Size = New System.Drawing.Size(31, 18)
        Me.lbRolEditar.TabIndex = 21
        Me.lbRolEditar.Text = "Rol"
        '
        'cbxRolEditar
        '
        Me.cbxRolEditar.Enabled = False
        Me.cbxRolEditar.FormattingEnabled = True
        Me.cbxRolEditar.Location = New System.Drawing.Point(132, 94)
        Me.cbxRolEditar.Name = "cbxRolEditar"
        Me.cbxRolEditar.Size = New System.Drawing.Size(194, 26)
        Me.cbxRolEditar.TabIndex = 11
        '
        'txbConfirmarEditar
        '
        Me.txbConfirmarEditar.Enabled = False
        Me.txbConfirmarEditar.Location = New System.Drawing.Point(130, 175)
        Me.txbConfirmarEditar.Name = "txbConfirmarEditar"
        Me.txbConfirmarEditar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbConfirmarEditar.Size = New System.Drawing.Size(196, 24)
        Me.txbConfirmarEditar.TabIndex = 20
        '
        'lbConfirmarEditar
        '
        Me.lbConfirmarEditar.AutoSize = True
        Me.lbConfirmarEditar.Location = New System.Drawing.Point(33, 182)
        Me.lbConfirmarEditar.Name = "lbConfirmarEditar"
        Me.lbConfirmarEditar.Size = New System.Drawing.Size(74, 18)
        Me.lbConfirmarEditar.TabIndex = 19
        Me.lbConfirmarEditar.Text = "Confirmar"
        '
        'lbContraseñaEditar
        '
        Me.lbContraseñaEditar.AutoSize = True
        Me.lbContraseñaEditar.Location = New System.Drawing.Point(33, 143)
        Me.lbContraseñaEditar.Name = "lbContraseñaEditar"
        Me.lbContraseñaEditar.Size = New System.Drawing.Size(85, 18)
        Me.lbContraseñaEditar.TabIndex = 17
        Me.lbContraseñaEditar.Text = "Contraseña"
        '
        'lbUsuarioEditar
        '
        Me.lbUsuarioEditar.AutoSize = True
        Me.lbUsuarioEditar.Location = New System.Drawing.Point(33, 49)
        Me.lbUsuarioEditar.Name = "lbUsuarioEditar"
        Me.lbUsuarioEditar.Size = New System.Drawing.Size(60, 18)
        Me.lbUsuarioEditar.TabIndex = 16
        Me.lbUsuarioEditar.Text = "Usuario"
        '
        'txbContraseñaEditar
        '
        Me.txbContraseñaEditar.Enabled = False
        Me.txbContraseñaEditar.Location = New System.Drawing.Point(130, 136)
        Me.txbContraseñaEditar.Name = "txbContraseñaEditar"
        Me.txbContraseñaEditar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContraseñaEditar.Size = New System.Drawing.Size(196, 24)
        Me.txbContraseñaEditar.TabIndex = 15
        '
        'txbUsuarioEditar
        '
        Me.txbUsuarioEditar.Enabled = False
        Me.txbUsuarioEditar.Location = New System.Drawing.Point(130, 49)
        Me.txbUsuarioEditar.Name = "txbUsuarioEditar"
        Me.txbUsuarioEditar.Size = New System.Drawing.Size(196, 24)
        Me.txbUsuarioEditar.TabIndex = 12
        '
        'BtnGuardarEditar
        '
        Me.BtnGuardarEditar.Enabled = False
        Me.BtnGuardarEditar.Location = New System.Drawing.Point(184, 236)
        Me.BtnGuardarEditar.Name = "BtnGuardarEditar"
        Me.BtnGuardarEditar.Size = New System.Drawing.Size(102, 30)
        Me.BtnGuardarEditar.TabIndex = 14
        Me.BtnGuardarEditar.Text = "Guardar"
        Me.BtnGuardarEditar.UseVisualStyleBackColor = True
        '
        'BtnModificarEditar
        '
        Me.BtnModificarEditar.Location = New System.Drawing.Point(78, 236)
        Me.BtnModificarEditar.Name = "BtnModificarEditar"
        Me.BtnModificarEditar.Size = New System.Drawing.Size(102, 30)
        Me.BtnModificarEditar.TabIndex = 13
        Me.BtnModificarEditar.Text = "Modificar"
        Me.BtnModificarEditar.UseVisualStyleBackColor = True
        '
        'TabPageEliminar
        '
        Me.TabPageEliminar.Controls.Add(Me.Button3)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox6)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox5)
        Me.TabPageEliminar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEliminar.Name = "TabPageEliminar"
        Me.TabPageEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEliminar.Size = New System.Drawing.Size(755, 419)
        Me.TabPageEliminar.TabIndex = 2
        Me.TabPageEliminar.Text = "Eliminar"
        Me.TabPageEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbnRefrescarEliminar)
        Me.GroupBox6.Controls.Add(Me.btnEliminarEliminar)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(313, 125)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(393, 128)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Eliminar Usuario"
        '
        'tbnRefrescarEliminar
        '
        Me.tbnRefrescarEliminar.Location = New System.Drawing.Point(58, 54)
        Me.tbnRefrescarEliminar.Name = "tbnRefrescarEliminar"
        Me.tbnRefrescarEliminar.Size = New System.Drawing.Size(121, 33)
        Me.tbnRefrescarEliminar.TabIndex = 4
        Me.tbnRefrescarEliminar.Text = "Refrescar"
        Me.tbnRefrescarEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminarEliminar
        '
        Me.btnEliminarEliminar.Location = New System.Drawing.Point(207, 54)
        Me.btnEliminarEliminar.Name = "btnEliminarEliminar"
        Me.btnEliminarEliminar.Size = New System.Drawing.Size(115, 33)
        Me.btnEliminarEliminar.TabIndex = 3
        Me.btnEliminarEliminar.Text = "Eliminar"
        Me.btnEliminarEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbxmostraEliminar)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(33, 54)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 309)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Listado de Usuarios"
        '
        'lbxmostraEliminar
        '
        Me.lbxmostraEliminar.FormattingEnabled = True
        Me.lbxmostraEliminar.ItemHeight = 18
        Me.lbxmostraEliminar.Location = New System.Drawing.Point(6, 25)
        Me.lbxmostraEliminar.Name = "lbxmostraEliminar"
        Me.lbxmostraEliminar.Size = New System.Drawing.Size(220, 274)
        Me.lbxmostraEliminar.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 419)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Listado de Usuarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario, Me.Rol, Me.Descripcion, Me.Estado, Me.Asignado})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.FillWeight = 45.0!
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'Rol
        '
        Me.Rol.DataPropertyName = "Rol"
        Me.Rol.FillWeight = 45.0!
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "DescripcionRol"
        Me.Descripcion.HeaderText = "Descripción Rol "
        Me.Descripcion.Name = "Descripcion"
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.FillWeight = 40.0!
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Asignado
        '
        Me.Asignado.DataPropertyName = "Asignado"
        Me.Asignado.FillWeight = 50.0!
        Me.Asignado.HeaderText = "Asignado a Persona"
        Me.Asignado.Name = "Asignado"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(644, 353)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(73, 30)
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(644, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 30)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(644, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 30)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmNvoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 452)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNvoUsuarios"
        Me.Text = "Mantenimiento de Usuarios"
        Me.TabControl1.ResumeLayout(False)
        Me.tbPageAgregar.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabPageEditar.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPageEliminar.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbPageAgregar As System.Windows.Forms.TabPage
    Friend WithEvents tabPageEditar As System.Windows.Forms.TabPage
    Friend WithEvents TabPageEliminar As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAceptarAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbContraseñaAgregar As System.Windows.Forms.TextBox
    Friend WithEvents txbUsuariAgregar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbConfirmarAgregar As System.Windows.Forms.TextBox
    Friend WithEvents cbxRolAgregar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbRolEditar As System.Windows.Forms.Label
    Friend WithEvents cbxRolEditar As System.Windows.Forms.ComboBox
    Friend WithEvents txbConfirmarEditar As System.Windows.Forms.TextBox
    Friend WithEvents lbConfirmarEditar As System.Windows.Forms.Label
    Friend WithEvents lbContraseñaEditar As System.Windows.Forms.Label
    Friend WithEvents lbUsuarioEditar As System.Windows.Forms.Label
    Friend WithEvents txbContraseñaEditar As System.Windows.Forms.TextBox
    Friend WithEvents txbUsuarioEditar As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardarEditar As System.Windows.Forms.Button
    Friend WithEvents BtnModificarEditar As System.Windows.Forms.Button
    Friend WithEvents lstbMostrarEditar As System.Windows.Forms.ListBox
    Friend WithEvents lbxmostraEliminar As System.Windows.Forms.ListBox
    Friend WithEvents tbnRefrescarEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarEliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
