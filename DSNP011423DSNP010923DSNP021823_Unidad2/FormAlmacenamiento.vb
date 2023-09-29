Public Class FormAlmacenamiento
    Dim almacenamiento As Almacenamiento = New Almacenamiento()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBox1.Items.AddRange(almacenamiento.Medidas())
        ComboBox1.SelectedIndex = 0
        ComboBox2.Items.AddRange(almacenamiento.Medidas())
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox1.Text IsNot "" Then
                TextBox2.Text = almacenamiento.Convertir(Double.Parse(TextBox1.Text), ComboBox1.Text, ComboBox2.Text)
            End If
        Catch ex As FormatException
            MessageBox.Show("Es necesario que ingreses un valor numérico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
            TextBox1.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub FormAlmacenamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class