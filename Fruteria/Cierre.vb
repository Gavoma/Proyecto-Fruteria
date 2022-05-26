Public Class Cierre

    'Private Sub VENTASHECHASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.VENTASHECHASBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    'Private Sub VENTASHECHASBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.VENTASHECHASBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    Private Sub Cierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.VENTASREGISTRADAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASREGISTRADASTableAdapter.Fill(Me.PROYECTOVENTADataSet.VENTASREGISTRADAS)

        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.VENTASHECHAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASHECHASTableAdapter.Fill(Me.PROYECTOVENTADataSet.VENTASHECHAS)

    End Sub


End Class