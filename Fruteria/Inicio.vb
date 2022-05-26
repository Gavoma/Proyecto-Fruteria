Public Class Inicio
    'Private Sub USUARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.USUARIOBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.PROYECTOVENTADataSet)

    'End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTOVENTADataSet.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me.PROYECTOVENTADataSet.USUARIO)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarUsuario()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsuario.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Close()

    End Sub

    Private Sub BuscarUsuario()
        Dim nTotal As Byte
        nTotal = USUARIOTableAdapter.ExisteUsuario(txtUsuario.Text, txtPassword.Text)
        If nTotal = 1 Then
            My.Settings.sUsuario = txtUsuario.Text
            Me.Hide()
            PantallaP.Show()
            txtUsuario.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Usuario o clave invalida")

        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                BuscarUsuario()
        End Select
    End Sub
End Class