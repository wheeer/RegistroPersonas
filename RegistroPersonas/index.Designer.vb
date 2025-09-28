<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        ctCrear = New Button()
        btLeer = New Button()
        btActualizar = New Button()
        btEliminar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ctCrear
        ' 
        ctCrear.Location = New Point(56, 62)
        ctCrear.Name = "ctCrear"
        ctCrear.Size = New Size(75, 23)
        ctCrear.TabIndex = 0
        ctCrear.Text = "Crear"
        ctCrear.UseVisualStyleBackColor = True
        ' 
        ' btLeer
        ' 
        btLeer.Location = New Point(163, 62)
        btLeer.Name = "btLeer"
        btLeer.Size = New Size(75, 23)
        btLeer.TabIndex = 1
        btLeer.Text = "Leer"
        btLeer.UseVisualStyleBackColor = True
        ' 
        ' btActualizar
        ' 
        btActualizar.Location = New Point(56, 110)
        btActualizar.Name = "btActualizar"
        btActualizar.Size = New Size(75, 23)
        btActualizar.TabIndex = 2
        btActualizar.Text = "Actualizar"
        btActualizar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(163, 110)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(75, 23)
        btEliminar.TabIndex = 3
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 4
        Label1.Text = "Escoge tu CRUD"
        ' 
        ' index
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(291, 180)
        Controls.Add(Label1)
        Controls.Add(btEliminar)
        Controls.Add(btActualizar)
        Controls.Add(btLeer)
        Controls.Add(ctCrear)
        Name = "index"
        Text = "index"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ctCrear As Button
    Friend WithEvents btLeer As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents Label1 As Label
End Class
