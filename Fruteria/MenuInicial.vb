
Public Class MenuInicial
    Private currentBtn As Button
    Private leftBorderBtn As Panel




    Private currentForm As Form = Nothing

    Private Sub openPanelControl(openPanel As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = openPanel
        openPanel.TopLevel = False
        openPanel.FormBorderStyle = FormBorderStyle.None
        openPanel.Dock = DockStyle.Fill
        Panel3.Controls.Add(openPanel)
        Panel3.Tag = openPanel
        openPanel.BringToFront()
        openPanel.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openPanelControl(New Menu1())
        ActivateButton(sender, RGBColores.color1)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ActivateButton(sender, RGBColores.color2)
        openPanelControl(New Almacen())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActivateButton(sender, RGBColores.color1)
        openPanelControl(New Cierre())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openPanelControl(New Principal())

        ActivateButton(sender, RGBColores.color2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Inicio.Show()
        Me.Close()

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        Panel3.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(6, 80, 122)
            currentBtn.ForeColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(128, 128, 128)
            currentBtn.ForeColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        PantallaP.Show()
        Me.Hide()
    End Sub
End Class