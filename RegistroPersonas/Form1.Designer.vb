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
        cbRUT = New ComboBox()
        btnActualizar = New Button()
        btEliminar = New Button()
        Label7 = New Label()
        grSexo.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Location = New Point(12, 9)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(30, 15)
        lblRut.TabIndex = 0
        lblRut.Text = "Rut*"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 38)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombres*"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(12, 70)
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
        grSexo.Location = New Point(12, 106)
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
        lblComuna.Location = New Point(12, 179)
        lblComuna.Name = "lblComuna"
        lblComuna.Size = New Size(58, 15)
        lblComuna.TabIndex = 4
        lblComuna.Text = "Comuna*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 6
        Label6.Text = "Observacion"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(129, 281)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 23)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar MySql"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(90, 35)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(259, 23)
        txtNombre.TabIndex = 10
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(90, 67)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(259, 23)
        txtApellido.TabIndex = 11
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(90, 208)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(259, 23)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(90, 240)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(259, 23)
        txtObservacion.TabIndex = 14
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(90, 176)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(259, 23)
        cboComuna.TabIndex = 15
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(240, 6)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(109, 23)
        btnCargar.TabIndex = 34
        btnCargar.Text = "Cargar Datos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' cbRUT
        ' 
        cbRUT.FormattingEnabled = True
        cbRUT.Location = New Point(90, 6)
        cbRUT.Name = "cbRUT"
        cbRUT.Size = New Size(128, 23)
        cbRUT.TabIndex = 33
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(12, 281)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(109, 23)
        btnActualizar.TabIndex = 35
        btnActualizar.Text = "Actualiar Datos"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(244, 281)
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
        Label7.Location = New Point(244, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 12)
        Label7.TabIndex = 37
        Label7.Text = "* Campos obligatorios"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 340)
        Controls.Add(Label7)
        Controls.Add(btEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnCargar)
        Controls.Add(cbRUT)
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
    Friend WithEvents cbRUT As ComboBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Label7 As Label

End Class
