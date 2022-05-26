Public Class BuscarProducto
    'Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.PRODUCTOSBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTOVENTADataSet.PRODUCTOS)

    End Sub

    Private Sub PRODUCTOSDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUCTOSDataGridView.CellDoubleClick
        'Dim frm As Menu1 = CType(Owner, Menu1)
        'frm.txtCodigo.Text = PRODUCTOSDataGridView.CurrentRow.Cells(0).Value.ToString()
        'Me.Close()

    End Sub


End Class