Public Class frmPayroll
    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFICA.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNet.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFICA.Text = ""
        lblFederal.Text = ""
        lblState.Text = ""
        lblNet.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        strIncome = txtGrossPay.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState
        decNet = decIncome - decFica - decFederal - decState
        lblNet.Text = decNet.ToString("C")
        lblFICA.Text = decFica.ToString("C")
        lblFederal.Text = decFederal.ToString("C")
        lblState.Text = decState.ToString("C")
    End Sub
End Class
