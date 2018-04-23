<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoCuenta))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageAgregar = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbNumeroCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbNombreCuenta = New System.Windows.Forms.TextBox()
        Me.TabPageEditar = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lsbMostrarEditarCuenta = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEditarTipo = New System.Windows.Forms.ComboBox()
        Me.btnActualizarEditar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbNumeroEditar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbNombreEditar = New System.Windows.Forms.TextBox()
        Me.TabPageEliminar = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lstbEliminar = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeroCnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageAgregar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageEditar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageEliminar.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageAgregar)
        Me.TabControl1.Controls.Add(Me.TabPageEditar)
        Me.TabControl1.Controls.Add(Me.TabPageEliminar)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(769, 443)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageAgregar
        '
        Me.TabPageAgregar.Controls.Add(Me.Button8)
        Me.TabPageAgregar.Controls.Add(Me.GroupBox2)
        Me.TabPageAgregar.Controls.Add(Me.GroupBox1)
        Me.TabPageAgregar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageAgregar.Name = "TabPageAgregar"
        Me.TabPageAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAgregar.Size = New System.Drawing.Size(761, 410)
        Me.TabPageAgregar.TabIndex = 0
        Me.TabPageAgregar.Text = "Agregar"
        Me.TabPageAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Cuentas"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(6, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 238)
        Me.ListBox1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.cmbTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txbNumeroCuenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txbNombreCuenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(321, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 257)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agreagar Cuenta"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(181, 189)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(104, 31)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbTipoCuenta
        '
        Me.cmbTipoCuenta.FormattingEnabled = True
        Me.cmbTipoCuenta.Location = New System.Drawing.Point(124, 126)
        Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
        Me.cmbTipoCuenta.Size = New System.Drawing.Size(220, 26)
        Me.cmbTipoCuenta.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tipo "
        '
        'txbNumeroCuenta
        '
        Me.txbNumeroCuenta.Location = New System.Drawing.Point(124, 82)
        Me.txbNumeroCuenta.Name = "txbNumeroCuenta"
        Me.txbNumeroCuenta.Size = New System.Drawing.Size(220, 24)
        Me.txbNumeroCuenta.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'txbNombreCuenta
        '
        Me.txbNombreCuenta.Location = New System.Drawing.Point(124, 37)
        Me.txbNombreCuenta.Name = "txbNombreCuenta"
        Me.txbNombreCuenta.Size = New System.Drawing.Size(220, 24)
        Me.txbNombreCuenta.TabIndex = 6
        '
        'TabPageEditar
        '
        Me.TabPageEditar.Controls.Add(Me.Button1)
        Me.TabPageEditar.Controls.Add(Me.GroupBox4)
        Me.TabPageEditar.Controls.Add(Me.GroupBox3)
        Me.TabPageEditar.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEditar.Name = "TabPageEditar"
        Me.TabPageEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEditar.Size = New System.Drawing.Size(761, 410)
        Me.TabPageEditar.TabIndex = 1
        Me.TabPageEditar.Text = "Editar"
        Me.TabPageEditar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lsbMostrarEditarCuenta)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lista de Cuentas"
        '
        'lsbMostrarEditarCuenta
        '
        Me.lsbMostrarEditarCuenta.FormattingEnabled = True
        Me.lsbMostrarEditarCuenta.ItemHeight = 18
        Me.lsbMostrarEditarCuenta.Location = New System.Drawing.Point(6, 19)
        Me.lsbMostrarEditarCuenta.Name = "lsbMostrarEditarCuenta"
        Me.lsbMostrarEditarCuenta.Size = New System.Drawing.Size(220, 238)
        Me.lsbMostrarEditarCuenta.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbEditarTipo)
        Me.GroupBox3.Controls.Add(Me.btnActualizarEditar)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txbNumeroEditar)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txbNombreEditar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(321, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 257)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tipo "
        '
        'cmbEditarTipo
        '
        Me.cmbEditarTipo.Enabled = False
        Me.cmbEditarTipo.FormattingEnabled = True
        Me.cmbEditarTipo.Location = New System.Drawing.Point(134, 134)
        Me.cmbEditarTipo.Name = "cmbEditarTipo"
        Me.cmbEditarTipo.Size = New System.Drawing.Size(220, 26)
        Me.cmbEditarTipo.TabIndex = 13
        '
        'btnActualizarEditar
        '
        Me.btnActualizarEditar.Enabled = False
        Me.btnActualizarEditar.Location = New System.Drawing.Point(212, 193)
        Me.btnActualizarEditar.Name = "btnActualizarEditar"
        Me.btnActualizarEditar.Size = New System.Drawing.Size(104, 31)
        Me.btnActualizarEditar.TabIndex = 2
        Me.btnActualizarEditar.Text = "Actualizar"
        Me.btnActualizarEditar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(95, 193)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 31)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Numero"
        '
        'txbNumeroEditar
        '
        Me.txbNumeroEditar.Enabled = False
        Me.txbNumeroEditar.Location = New System.Drawing.Point(134, 84)
        Me.txbNumeroEditar.Name = "txbNumeroEditar"
        Me.txbNumeroEditar.Size = New System.Drawing.Size(220, 24)
        Me.txbNumeroEditar.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'txbNombreEditar
        '
        Me.txbNombreEditar.Enabled = False
        Me.txbNombreEditar.Location = New System.Drawing.Point(134, 39)
        Me.txbNombreEditar.Name = "txbNombreEditar"
        Me.txbNombreEditar.Size = New System.Drawing.Size(220, 24)
        Me.txbNombreEditar.TabIndex = 11
        '
        'TabPageEliminar
        '
        Me.TabPageEliminar.Controls.Add(Me.Button2)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox6)
        Me.TabPageEliminar.Controls.Add(Me.GroupBox5)
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
        Me.GroupBox6.Location = New System.Drawing.Point(317, 100)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(393, 128)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Eliminar Persona"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(87, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 31)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Refrescar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(204, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 31)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lstbEliminar)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(34, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 271)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lista de Personas"
        '
        'lstbEliminar
        '
        Me.lstbEliminar.FormattingEnabled = True
        Me.lstbEliminar.ItemHeight = 18
        Me.lstbEliminar.Location = New System.Drawing.Point(6, 23)
        Me.lstbEliminar.Name = "lstbEliminar"
        Me.lstbEliminar.Size = New System.Drawing.Size(220, 238)
        Me.lstbEliminar.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(761, 410)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Listado de Cuentas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroCnt, Me.NombreCnt, Me.TipoCnt})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(721, 376)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroCnt
        '
        Me.NumeroCnt.DataPropertyName = "NumeroCnt"
        Me.NumeroCnt.FillWeight = 30.0!
        Me.NumeroCnt.HeaderText = "Cuenta"
        Me.NumeroCnt.Name = "NumeroCnt"
        '
        'NombreCnt
        '
        Me.NombreCnt.DataPropertyName = "NombreCnt"
        Me.NombreCnt.HeaderText = "Nombre"
        Me.NombreCnt.Name = "NombreCnt"
        '
        'TipoCnt
        '
        Me.TipoCnt.DataPropertyName = "TipoCnt"
        Me.TipoCnt.FillWeight = 50.0!
        Me.TipoCnt.HeaderText = "Tipo "
        Me.TipoCnt.Name = "TipoCnt"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(644, 353)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(73, 30)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(644, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 30)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(644, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 30)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMantenimientoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMantenimientoCuenta"
        Me.Text = "Mantenimiento de Cuentas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageAgregar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageEditar.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageEliminar.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAgregar As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txbNumeroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbNombreCuenta As System.Windows.Forms.TextBox
    Friend WithEvents TabPageEditar As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lsbMostrarEditarCuenta As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEditarTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnActualizarEditar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txbNumeroEditar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txbNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents TabPageEliminar As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstbEliminar As System.Windows.Forms.ListBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroCnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
