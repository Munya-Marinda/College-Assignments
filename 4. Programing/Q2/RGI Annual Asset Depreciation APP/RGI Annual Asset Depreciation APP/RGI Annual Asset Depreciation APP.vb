Public Class frmRGI
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub Calc_and_Display_DDB(dAssetCost As Double, dSalvageValue As Double, iUsefulLife As Double, iPeriod As Integer)
        Dim DDB As String
        Dim i As Double

        For iPeriod = 1 To iUsefulLife
            i = Financial.DDB(dAssetCost, dSalvageValue, iUsefulLife, iPeriod)
            i = Math.Round(i, 2, MidpointRounding.AwayFromZero)
            DDB = i.ToString("F")
            'If (InStr(DDB, ".") = 0) Then
            '    DDB &= DDB & "." & Mid(DDB, InStr(DDB, "."))
            'End If
            rchDDB.AppendText(vbNewLine + (iPeriod & vbTab & DDB))
        Next

    End Sub

    Sub Calc_and_Display_SYD(dAssetCost As Double, dSalvageValue As Double, iUsefulLife As Double, iPeriod As Integer)
        Dim SYD As String


        rchSYD.Text = "Year" & vbTab & "Depreciation"
        For iPeriod = 1 To iUsefulLife
            'SYD = Math.Round(SYD, 2, MidpointRounding.AwayFromZero)
            'SYD = FormatCurrency(SYD, , , TriState.True, TriState.True) 'FormatCurrency code by VB Helper {bv-helper.com}
            SYD = Financial.SYD(dAssetCost, dSalvageValue, iUsefulLife, iPeriod).ToString("C2")
            rchSYD.AppendText(vbNewLine + (iPeriod & vbTab & SYD))
        Next
    End Sub

    Private Sub btnCalcDeprValues_Click(sender As Object, e As EventArgs) Handles btnCalcDeprValues.Click
        Dim dAssetCost, dSalvageValue As Double
        Dim iUsefulLife, iPeriod As Integer

        dAssetCost = txtAssetCost.Text
        dSalvageValue = txtSalvageValue.Text
        iUsefulLife = cmbUsefulLife.SelectedItem 'max = user selection (years)

        iPeriod = 1 'used as count, min = 1 (years)

        'Create tabs In Rich Text Box #######################
        rchDDB.SelectAll() 'code by @Martin {Stack-overload}
        rchDDB.SelectionTabs = New Integer() {60}
        rchDDB.AcceptsTab = True
        rchDDB.Select(0, 0)

        'rich-edit-code by @Martin {Stack-overload}
        rchDDB.Clear()
        rchSYD.Clear()

        rchDDB.Text = "Year" & vbTab & "Depreciation"

        Call Calc_and_Display_SYD(dAssetCost, dSalvageValue, iUsefulLife, iPeriod)
        Call Calc_and_Display_DDB(dAssetCost, dSalvageValue, iUsefulLife, iPeriod)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 3 To 20
            cmbUsefulLife.Items.Add(i)
        Next

        'Set values on input(s) saves debugging time
        'txtAssetCost.Text = 5000
        'txtSalvageValue.Text = 100
        'cmbUsefulLife.SelectedIndex = 2

    End Sub
End Class
