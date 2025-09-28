<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        cboComuna = New ComboBox()
        txtObservacion = New TextBox()
        txtCiudad = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        btnActualizar = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New CheckBox()
        rbtnFemenino = New CheckBox()
        rbtnMasculino = New CheckBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cbRUT = New ComboBox()
        btnCargar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(94, 188)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(224, 23)
        cboComuna.TabIndex = 30
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(94, 252)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(224, 23)
        txtObservacion.TabIndex = 29
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(94, 220)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(224, 23)
        txtCiudad.TabIndex = 28
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(94, 79)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(224, 23)
        txtApellido.TabIndex = 27
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(94, 47)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(224, 23)
        txtNombre.TabIndex = 26
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(112, 293)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(109, 23)
        btnActualizar.TabIndex = 23
        btnActualizar.Text = "Actualiar Datos"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 22
        Label6.Text = "Observacion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 21
        Label5.Text = "Ciudad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 20
        Label4.Text = "Comuina"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(16, 118)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(292, 57)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(184, 22)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(97, 19)
        rbtnNoEspecifica.TabIndex = 2
        rbtnNoEspecifica.Text = "No especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(96, 22)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(79, 19)
        rbtnFemenino.TabIndex = 1
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(6, 22)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(81, 19)
        rbtnMasculino.TabIndex = 0
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 18
        Label3.Text = "Apellidos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 17
        Label2.Text = "Nombres"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 16
        Label1.Text = "Rut"
        ' 
        ' cbRUT
        ' 
        cbRUT.FormattingEnabled = True
        cbRUT.Location = New Point(94, 18)
        cbRUT.Name = "cbRUT"
        cbRUT.Size = New Size(109, 23)
        cbRUT.TabIndex = 31
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(209, 18)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(109, 23)
        btnCargar.TabIndex = 32
        btnCargar.Text = "Cargar Datos"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' update
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 341)
        Controls.Add(btnCargar)
        Controls.Add(cbRUT)
        Controls.Add(cboComuna)
        Controls.Add(txtObservacion)
        Controls.Add(txtCiudad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(btnActualizar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "update"
        Text = "update"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboComuna As ComboBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As CheckBox
    Friend WithEvents rbtnFemenino As CheckBox
    Friend WithEvents rbtnMasculino As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRUT As ComboBox
    Friend WithEvents btnCargar As Button
End Class
