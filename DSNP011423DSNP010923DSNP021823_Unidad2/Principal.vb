Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim frmAlmacenamiento As New FormAlmacenamiento
        Me.Hide()
        frmAlmacenamiento.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frmLongitud As New FormLongitud
        Me.Hide()
        frmLongitud.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim frmMasa As New FormMasa
        Me.Hide()
        frmMasa.ShowDialog()
        Me.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim frmTiempo As New FormTiempo
        Me.Hide()
        frmTiempo.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmAcercaDe As New AcercaDe
        frmAcercaDe.ShowDialog()
    End Sub
End Class
