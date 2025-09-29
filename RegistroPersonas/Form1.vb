Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión para MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el nombre del formulario
        Me.Text = "Registro de Usuarios"

        ' Llenar el ComboBox con comunas
        cboComuna.Items.Add("Santiago")
        cboComuna.Items.Add("Cerrillos")
        cboComuna.Items.Add("Cerro Navia")
        cboComuna.Items.Add("Conchalí")
        cboComuna.Items.Add("El Bosque")
        cboComuna.Items.Add("Estación Central")
        cboComuna.Items.Add("Huechuraba")
        cboComuna.Items.Add("Independencia")
        cboComuna.Items.Add("La Cisterna")
        cboComuna.Items.Add("La Florida")
        cboComuna.Items.Add("La Granja")
        cboComuna.Items.Add("La Pintana")
        cboComuna.Items.Add("La Reina")
        cboComuna.Items.Add("Las Condes")
        cboComuna.Items.Add("Lo Barnechea")
        cboComuna.Items.Add("Lo Espejo")
        cboComuna.Items.Add("Lo Prado")
        cboComuna.Items.Add("Macul")
        cboComuna.Items.Add("Maipú")
        cboComuna.Items.Add("Ñuñoa")
        cboComuna.Items.Add("Pedro Aguirre Cerda")
        cboComuna.Items.Add("Peñalolén")
        cboComuna.Items.Add("Providencia")
        cboComuna.Items.Add("Pudahuel")
        cboComuna.Items.Add("Quilicura")
        cboComuna.Items.Add("Quinta Normal")
        cboComuna.Items.Add("Recoleta")
        cboComuna.Items.Add("Renca")
        cboComuna.Items.Add("San Joaquín")
        cboComuna.Items.Add("San Miguel")
        cboComuna.Items.Add("San Ramón")
        cboComuna.Items.Add("Vitacura")
        cboComuna.Items.Add("Puente Alto")
        cboComuna.Items.Add("Pirque")
        cboComuna.Items.Add("San José de Maipo")
        cboComuna.Items.Add("Colina")
        cboComuna.Items.Add("Lampa")
        cboComuna.Items.Add("Tiltil")
        cboComuna.Items.Add("San Bernardo")
        cboComuna.Items.Add("Buin")
        cboComuna.Items.Add("Calera de Tango")
        cboComuna.Items.Add("Paine")

        'Llenar el ComboBox de RUT desde la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT RUT FROM Personas ORDER BY RUT"
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cbRUT.Items.Clear() ' Limpiar antes de cargar
                        While reader.Read()
                            cbRUT.Items.Add(reader("RUT").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar RUTs: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rut As String = cbRUT.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String

        ' Validar la selección del sexo
        If rbtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf rbtnNoEspecifica.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener otros campos
        Dim comuna As String = cboComuna.SelectedItem?.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar el formulario después de guardar
                    LimpiarFormulario()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        cbRUT.SelectedIndex = -1
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cboComuna.SelectedIndex = -1
        cbRUT.Focus() ' Colocar el foco en el campo RUT
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If cbRUT.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un RUT para cargar los datos.")
            Return
        End If

        Dim rutSeleccionado As String = cbRUT.SelectedItem.ToString()

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion 
                                     FROM Personas WHERE RUT = @rut"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rutSeleccionado)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                            txtCiudad.Text = reader("Ciudad").ToString()
                            txtObservacion.Text = reader("Observacion").ToString()

                            ' Seleccionar comuna en el ComboBox
                            Dim comuna As String = reader("Comuna").ToString()
                            If cboComuna.Items.Contains(comuna) Then
                                cboComuna.SelectedItem = comuna
                            End If

                            ' Seleccionar sexo
                            Dim sexo As String = reader("Sexo").ToString()
                            rbtnMasculino.Checked = (sexo = "Masculino")
                            rbtnFemenino.Checked = (sexo = "Femenino")
                            rbtnNoEspecifica.Checked = (sexo = "No especifica")
                        Else
                            MessageBox.Show("No se encontraron datos para el RUT seleccionado.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If cbRUT.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un RUT antes de actualizar.")
            Return
        End If

        Dim rutSeleccionado As String = cbRUT.SelectedItem.ToString()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim apellido As String = txtApellido.Text.Trim()
        Dim ciudad As String = txtCiudad.Text.Trim()
        Dim observacion As String = txtObservacion.Text.Trim()
        Dim comuna As String = If(cboComuna.SelectedItem IsNot Nothing, cboComuna.SelectedItem.ToString(), "")

        Dim sexo As String = ""
        If rbtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf rbtnNoEspecifica.Checked Then
            sexo = "No especifica"
        End If

        ' Validación mínima
        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(apellido) OrElse String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Complete todos los campos obligatorios (Nombre, Apellido, Comuna).")
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "UPDATE Personas 
                                 SET Nombre=@nombre, Apellido=@apellido, Sexo=@sexo, 
                                     Comuna=@comuna, Ciudad=@ciudad, Observacion=@observacion 
                                 WHERE RUT=@rut"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)
                    cmd.Parameters.AddWithValue("@rut", rutSeleccionado)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se encontró el registro a actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class