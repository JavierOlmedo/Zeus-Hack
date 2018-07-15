
Public Class Form1

    'Desarrollado por @JJavierOlmedo - Hackpuntes.com [2018]

    'Variables
    Dim direccionMemoria As Integer = &HEF2E74 'Direccion de memoria para cambiar el valor (Obtenida con Cheat Engine)
    Dim nombreProceso = "Zeus" 'Nombre de proceso para comprobar si está en ejecución
    Dim dracmas As Integer

    'Metodo al pulsar el boton Hack
    Private Sub btnHack_Click(sender As Object, e As EventArgs) Handles btnHack.Click
        'Comprobamos si está el juego ejecutándose
        If procesoON() Then
            lblProceso.Text = "ON"
            lblProceso.ForeColor = Color.LightGreen
            'Comprobamos que el valor sea un número
            If IsNumeric(tbDracmas.Text) = False Then
                MessageBox.Show("The value is not a digit or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dracmas = tbDracmas.Text
                Try
                    'Hackeamos las monedas
                    WriteInteger(nombreProceso, direccionMemoria, dracmas)
                Catch ex As Exception
                End Try
                'Mostamos un mensaje para verificar que se han cambiado
                MessageBox.Show("You've successfully introduced " + CStr(dracmas) + " drachmas, please come back to the game", "0xEF2E74", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            lblProceso.Text = "OFF"
            lblProceso.ForeColor = Color.Red
            MessageBox.Show("Process of Zeus not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Metodo que devuelve si el proceso esta en ejecución
    Function procesoON() As Boolean
        Dim aplicacioncorriendo As Process() = Process.GetProcessesByName(nombreProceso)
        If aplicacioncorriendo.Length >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Metodo que abre una ventana con la información sobre el desarrollador
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        about.ShowDialog()
    End Sub
End Class
