Public Class frmWallpaperApp
    '###########################################'
    '               CODE BY MUNYA               '
    '###########################################
    'Developed an in Visual Basic, using the Microsoft Visual Studio IDE

    'A  Windows  application that  calculates  the  number  of  single rolls of wallpaper required to cover a room

    Public dNumRolls As Double

    Sub DropBoxChanged(cmbName As String)
        'Combo Box Changed, clear answer
        txtAnswer.Clear()
    End Sub
    Sub PopulateLWHRc()
        'Populates the comboxes
        Dim dvar As Double

        For i = 10 To 35
            cmbHeight.Items.Add(i)
            cmbWidth.Items.Add(i)
            cmbLength.Items.Add(i)
        Next

        dvar = 40
        Do While (dvar <> 50.5)
            cmbRollCvrg.Items.Add(dvar)
            dvar += 0.5
        Loop

    End Sub

    Function CalcRolls(iH As Double, iW As Double, iL As Double, dRC As Double) As Double
        'Calculates ammount of rolls needed
        Dim iresult As Double

        iresult = ((iH * iW) * (2) + (iL * iH) * (2)) / dRC 'FORMULA'
        Dim m As Double = iresult

        iresult = Math.Round(iresult)

        If (iresult < m) Then
            iresult = iresult + 1
        End If

        CalcRolls = iresult
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit button
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Variables'
        Dim intHeight As Double
        Dim intLength As Double
        Dim intWidth As Double
        Dim intRollCvrg As Double

        'Initialize Vars'
        intHeight = cmbHeight.SelectedItem
        intLength = cmbLength.SelectedItem
        intWidth = cmbWidth.SelectedItem
        intRollCvrg = cmbRollCvrg.SelectedItem

        dNumRolls = CalcRolls(intHeight, intLength, intWidth, intRollCvrg)
        txtAnswer.Text = dNumRolls
    End Sub

    Private Sub OnLoadMainForm(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate Comboboxes'
        Call PopulateLWHRc()
        dNumRolls = 0
    End Sub

    Private Sub OnCmbLength(sender As Object, e As EventArgs) Handles cmbLength.SelectionChangeCommitted
        'Combo Box Length Changed
        Call DropBoxChanged("Length")
    End Sub

    Private Sub cmbWidth_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbWidth.SelectionChangeCommitted
        'Combo Box Width Changed
        Call DropBoxChanged("Width")
    End Sub

    Private Sub cmbHeight_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeight.SelectionChangeCommitted
        'Combo Box Height Changed
        Call DropBoxChanged("Height")

    End Sub

    Private Sub cmbRollCvrg_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRollCvrg.SelectionChangeCommitted
        'Combo Box RollCvrg Changed
        Call DropBoxChanged("RollCvrg")
    End Sub

End Class
