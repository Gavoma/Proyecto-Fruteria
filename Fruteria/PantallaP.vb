Public Class PantallaP
    Private currentBtn As Button
    Private leftBorderBtn As Panel

    Private Sub Horafecha_Tick(sender As Object, e As EventArgs) Handles Horafecha.Tick
        Hora.Text = DateTime.Now.ToLongTimeString()
        Fecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub HideMenu()
        PanelSubMenu.Visible = False
    End Sub

    Private Sub PantallaP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideMenu()
    End Sub

    Private Sub ShowSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            HideMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub BotonMenu_Click(sender As Object, e As EventArgs) Handles BotonMenu.Click
        ShowSubMenu(PanelSubMenu)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox(" ¿Desea salir del programa? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If

        HideMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox(" ¿Desea cerrar sesion? ", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Inicio.Show()
            Me.Close()
        End If

        HideMenu()
    End Sub

    Private currentForm As Form = Nothing

    Private Sub openPanelControl(openPanel As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = openPanel
        openPanel.TopLevel = False
        openPanel.FormBorderStyle = FormBorderStyle.None
        openPanel.Dock = DockStyle.Fill
        Panel1.Controls.Add(openPanel)
        Panel1.Tag = openPanel
        openPanel.BringToFront()
        openPanel.Show()
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        openPanelControl(New Menu1())

    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        openPanelControl(New Almacen())

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        openPanelControl(New Principal())

    End Sub

    Private Sub btnCierreVenta_Click(sender As Object, e As EventArgs) Handles btnCierreVenta.Click

        openPanelControl(New Cierre())
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        openPanelControl(New PantallaInicial())
    End Sub

End Class