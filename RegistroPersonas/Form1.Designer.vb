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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New CheckBox()
        rbtnFemenino = New CheckBox()
        rbtnMasculino = New CheckBox()
        Label4 = New Label()
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
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(12, 106)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(320, 57)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 4
        Label4.Text = "Comuina"
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
        txtNombre.Size = New Size(224, 23)
        txtNombre.TabIndex = 10
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(90, 67)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(224, 23)
        txtApellido.TabIndex = 11
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(90, 208)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(203, 23)
        txtCiudad.TabIndex = 13
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(90, 240)
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(203, 23)
        txtObservacion.TabIndex = 14
        ' 
        ' cboComuna
        ' 
        cboComuna.FormattingEnabled = True
        cboComuna.Location = New Point(90, 176)
        cboComuna.Name = "cboComuna"
        cboComuna.Size = New Size(203, 23)
        cboComuna.TabIndex = 15
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(205, 6)
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
        cbRUT.Size = New Size(109, 23)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 316)
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
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As CheckBox
    Friend WithEvents rbtnFemenino As CheckBox
    Friend WithEvents rbtnMasculino As CheckBox
    Friend WithEvents Label4 As Label
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

End Class
