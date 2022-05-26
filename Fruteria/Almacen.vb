Public Class Almacen
    'Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.PRODUCTOSBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub
    Private Sub HabilitarBotones()
        If PRODUCTOSDataGridView.RowCount > 0 Then
            btnNuevo.Enabled = True : btnGuardar.Enabled = True : btnEliminar.Enabled = True
        Else
            btnNuevo.Enabled = True : btnGuardar.Enabled = False : btnEliminar.Enabled = False
        End If
    End Sub


    Private Sub Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTOVENTADataSet.PRODUCTOS)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.PRODUCTOSDataGridView.Enabled = True
            Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTOVENTADataSet.PRODUCTOS)
            HabilitarBotones()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        PRODUCTOSDataGridView.Enabled = True
        Me.PRODUCTOSBindingSource.AddNew()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Me.Validate()
            Me.PRODUCTOSBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)
            MessageBox.Show("info guardada")
            PRODUCTOSDataGridView.Enabled = True
            HabilitarBotones()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim nResp As Byte
            nResp = MessageBox.Show("seguro de eliminar?", "itsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If nResp = 6 Then
                Me.PRODUCTOSTableAdapter.Delete(CodproTextBox.Text, NomproTextBox.Text, PrecioTextBox.Text, ExistenciaTextBox.Text, CategoriaTextBox.Text, DescripcionTextBox.Text)
                MessageBox.Show("registro eliminado")
                Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTOVENTADataSet.PRODUCTOS)
                HabilitarBotones()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class