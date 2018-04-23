<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoConsulta))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RbtnDocumento = New System.Windows.Forms.RadioButton()
        Me.RbtnCntAhorro = New System.Windows.Forms.RadioButton()
        Me.RbtnCntaMon = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.DGVTipoOperacion = New System.Windows.Forms.DataGridView()
        Me.checkbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGVTipoCuentas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVTipoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVTipoCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(507, 518)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(361, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RbtnDocumento
        '
        Me.RbtnDocumento.AutoSize = True
        Me.RbtnDocumento.Location = New System.Drawing.Point(60, 118)
        Me.RbtnDocumento.Name = "RbtnDocumento"
        Me.RbtnDocumento.Size = New System.Drawing.Size(193, 22)
        Me.RbtnDocumento.TabIndex = 10
        Me.RbtnDocumento.TabStop = True
        Me.RbtnDocumento.Text = "Consulta por Documento"
        Me.RbtnDocumento.UseVisualStyleBackColor = True
        '
        'RbtnCntAhorro
        '
        Me.RbtnCntAhorro.AutoSize = True
        Me.RbtnCntAhorro.Location = New System.Drawing.Point(60, 90)
        Me.RbtnCntAhorro.Name = "RbtnCntAhorro"
        Me.RbtnCntAhorro.Size = New System.Drawing.Size(150, 22)
        Me.RbtnCntAhorro.TabIndex = 11
        Me.RbtnCntAhorro.TabStop = True
        Me.RbtnCntAhorro.Text = "Cuentas de Ahorro"
        Me.RbtnCntAhorro.UseVisualStyleBackColor = True
        '
        'RbtnCntaMon
        '
        Me.RbtnCntaMon.AutoSize = True
        Me.RbtnCntaMon.Location = New System.Drawing.Point(60, 62)
        Me.RbtnCntaMon.Name = "RbtnCntaMon"
        Me.RbtnCntaMon.Size = New System.Drawing.Size(180, 22)
        Me.RbtnCntaMon.TabIndex = 12
        Me.RbtnCntaMon.TabStop = True
        Me.RbtnCntaMon.Text = "Cuentas de Monetarios"
        Me.RbtnCntaMon.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(73, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 24)
        Me.TextBox1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RbtnCntaMon)
        Me.GroupBox1.Controls.Add(Me.RbtnCntAhorro)
        Me.GroupBox1.Controls.Add(Me.RbtnDocumento)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(82, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 230)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo De Consulta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox2.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(433, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 230)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lapso De Tiempo"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(273, 47)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 13
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(28, 47)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.DGVTipoOperacion)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(25, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 222)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Transaccion"
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(15, 191)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(104, 22)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Todos"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'DGVTipoOperacion
        '
        Me.DGVTipoOperacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTipoOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkbox, Me.Numero, Me.Nombre})
        Me.DGVTipoOperacion.Location = New System.Drawing.Point(15, 23)
        Me.DGVTipoOperacion.Name = "DGVTipoOperacion"
        Me.DGVTipoOperacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVTipoOperacion.Size = New System.Drawing.Size(398, 162)
        Me.DGVTipoOperacion.TabIndex = 1
        '
        'checkbox
        '
        Me.checkbox.FillWeight = 20.0!
        Me.checkbox.HeaderText = ""
        Me.checkbox.Name = "checkbox"
        Me.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Numero
        '
        Me.Numero.DataPropertyName = "descripcion"
        Me.Numero.HeaderText = "Descripcion"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.DataPropertyName = "id_tipo_transaccion"
        Me.Nombre.HeaderText = " Id Tipo"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGVTipoCuentas)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(505, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(498, 222)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Segun Cuentas"
        '
        'DGVTipoCuentas
        '
        Me.DGVTipoCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTipoCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.DGVTipoCuentas.Location = New System.Drawing.Point(25, 23)
        Me.DGVTipoCuentas.Name = "DGVTipoCuentas"
        Me.DGVTipoCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVTipoCuentas.Size = New System.Drawing.Size(444, 162)
        Me.DGVTipoCuentas.TabIndex = 2
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn1.HeaderText = " Id Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 191)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 22)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Todos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmTipoConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 573)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTipoConsulta"
        Me.Text = "Consulta General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVTipoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGVTipoCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RbtnDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCntAhorro As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCntaMon As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents DGVTipoOperacion As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents DGVTipoCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents checkbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
