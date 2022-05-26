Public Class Menu1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Inicio.Show()
        Me.Close()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim frm As New BuscarProducto
        frm.ShowDialog()
        AddOwnedForm(frm)

    End Sub

    'Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.PRODUCTOSBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTOVENTADataSet.PRODUCTOS)



    End Sub

    Private Sub btnVentaFinaliada_Click(sender As Object, e As EventArgs) Handles btnVentaFinaliada.Click
        Dim frs As New FinalizarVenta
        If MsgBox(" ¿Desea guardar la venta? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            frs.ShowDialog()
            AddOwnedForm(frs)
        End If
    End Sub



    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.PRODUCTOSTableAdapter.BuscarProductos(Me.PROYECTOVENTADataSet.PRODUCTOS, txtCodigo.Text)

        End Select
    End Sub


    'Private Sub lbTotalPesos_Click(sender As Object, e As EventArgs) Handles lbTotalPesos.Click
    '    Dim total As Double = 0
    '    Dim iTotal As Integer = Me.PRODUCTOSDataGridView.Rows.Count
    '    Dim i As Integer

    '    For i = 0 To iTotal - 1
    '        total = total + Double.Parse(Me.PRODUCTOSDataGridView(4, i).Value)

    '    Next
    '    lbTotalPesos.Text = Format(total, "$#,##0.00 ")

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PRODUCTOSDataGridView.Rows.Add(Me.PROYECTOVENTADataSet.PRODUCTOS, txtCodigo.Text)


    End Sub
End Class
