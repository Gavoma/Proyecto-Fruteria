Public Class Principal

    'Private Sub USUARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.USUARIOBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.PROYECTOVENTADataSet.USUARIO)


    End Sub

    Private Sub HabilitarBotones()
        If USUARIODataGridView.RowCount > 0 Then
            btnNuevo.Enabled = True : btnEditar.Enabled = True : btnEliminar.Enabled = True
        Else
            btnNuevo.Enabled = True : btnEditar.Enabled = False : btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        USUARIODataGridView.Enabled = True
        Me.USUARIOBindingSource.AddNew()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Me.Validate()
            Me.USUARIOBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)
            MessageBox.Show("info guardada")
            USUARIODataGridView.Enabled = True
            HabilitarBotones()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim nResp As Byte
            nResp = MessageBox.Show("seguro de eliminar?", "itsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If nResp = 6 Then
                Me.USUARIOTableAdapter.Delete(FoliouTextBox.Text, NombreTextBox.Text, UsuarioTextBox.Text, UsuarioTextBox.Text, NombreTextBox.Text)
                MessageBox.Show("registro eliminado")
                Me.USUARIOTableAdapter.Fill(Me.PROYECTOVENTADataSet.USUARIO)
                HabilitarBotones()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.USUARIODataGridView.Enabled = True
            Me.USUARIOTableAdapter.Fill(Me.PROYECTOVENTADataSet.USUARIO)
            HabilitarBotones()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                Me.USUARIOTableAdapter.BuscarUsuario(Me.PROYECTOVENTADataSet.USUARIO, txtBuscar.Text)

        End Select
    End Sub


End Class