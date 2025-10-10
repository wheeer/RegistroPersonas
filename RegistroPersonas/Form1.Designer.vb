<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblRut = New Label()
        lblNombre = New Label()
        lblApellido = New Label()
        grSexo = New GroupBox()
        rbtnNoEspecifica = New CheckBox()
        rbtnFemenino = New CheckBox()
        rbtnMasculino = New CheckBox()
        lblComuna = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnGuardar = New Button()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCiudad = New TextBox()
        txtObservacion = New TextBox()
        cboComuna = New ComboBox()
        btnCargar = New Button()
        btnActualizar = New Button()
        btEliminar = New Button()
        Label7 = New Label()
        txtRut = New TextBox()
        Label1 = New Label()
        grSexo.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Location = New Point(12, 31)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(30, 15)
        lblRut.TabIndex = 0
        lblRut.Text = "Rut*"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 60)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombres*"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(12, 92)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(61, 15)
        lblApellido.TabIndex = 2
        lblApellido.Text = "Apellidos*"
        ' 
        ' grSexo
        ' 
        grSexo.Controls.Add(rbtnNoEspecifica)
        grSexo.Controls.Add(rbtnFemenino)
        grSexo.Controls.Add(rbtnMasculino)
        grSexo.Location = New Point(12, 128)
        grSexo.Name = "grSexo"
        grSexo.Size = New Size(337, 57)
        grSexo.TabIndex = 3
        grSexo.TabStop = False
        grSexo.Text = "Sexo"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(203, 22)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(97, 19)
        rbtnNoEspecifica.TabIndex = 2
        rbtnNoEspecifica.Text = "No especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(105, 22)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(79, 19)
        rbtnFemenino.TabIndex = 1
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(13, 22)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(81, 19)
        rbtnMasculino.TabIndex = 0
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' lblComuna
        ' 
        lblComuna.AutoSize = True
        lblComuna.Location = New Point(12, 201)
        lblComuna.Name = "lblComuna"
        lblComuna.Size = New Size(58, 15)
        lblComuna.TabIndex = 4
        lblComuna.Text = "Comuna*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 6
        Label6.Text = "Observacion"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(129, 303)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 23)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar MySql"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(90, 57)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(259, 23)
        txtNombre.TabIndex = 10
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(90, 89)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(259, 23)
        txtApellido.TabIndex = 11
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(90, 230)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(259, 23)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(90, 262)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(259, 23)
        txtObservacion.TabIndex = 14
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(90, 198)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(259, 23)
        cboComuna.TabIndex = 15
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(240, 28)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(109, 23)
        btnCargar.TabIndex = 34
        btnCargar.Text = "Cargar Datos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(12, 303)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(109, 23)
        btnActualizar.TabIndex = 35
        btnActualizar.Text = "Actualizar Datos"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(244, 303)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(109, 23)
        btEliminar.TabIndex = 36
        btEliminar.Text = "Eliminar datos"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7F)
        Label7.Location = New Point(244, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 12)
        Label7.TabIndex = 37
        Label7.Text = "* Campos obligatorios"
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(93, 28)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(141, 23)
        txtRut.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 39
        Label1.Text = " Ejemplo 123456789"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 363)
        Controls.Add(Label1)
        Controls.Add(txtRut)
        Controls.Add(Label7)
        Controls.Add(btEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnCargar)
        Controls.Add(cboComuna)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(btnGuardar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblComuna)
        Controls.Add(grSexo)
        Controls.Add(lblApellido)
        Controls.Add(lblNombre)
        Controls.Add(lblRut)
        Name = "Form1"
        Text = "Form1"
        grSexo.ResumeLayout(False)
        grSexo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRut As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents grSexo As GroupBox
    Friend WithEvents rbtnNoEspecifica As CheckBox
    Friend WithEvents rbtnFemenino As CheckBox
    Friend WithEvents rbtnMasculino As CheckBox
    Friend WithEvents lblComuna As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents cboComuna As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label1 As Label

End Class
