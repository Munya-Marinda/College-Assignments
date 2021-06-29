Public Class frm_ITI_Hub
    'Variables
    Dim arrYearlyRegionSales(11, 3) As Double ' 11 because there are 12 months (array index = 0..x) ... 1 - KZN  |  2 - GAU  |  3 - WCP 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub Display()
        ' .... Dispaly Current Array Values
        'Create tabs In Rich Text Box #######################
        rchOut.SelectAll() 'code by @Martin {Stack-overload}
        rchOut.SelectionTabs = New Integer() {80, 200, 300}
        rchOut.AcceptsTab = True
        rchOut.Select(0, 0)

        rchOut.Clear()
        'Set headings
        rchOut.Text = "Month" & vbTab & "KZN Sales (R)" & vbTab & "GAU Sales (R)" & vbTab & "WCP Sales (R)" & vbNewLine

        'Display Monthly Sales
        For j = 0 To UBound(arrYearlyRegionSales)
            If (arrYearlyRegionSales(j, 1) = 0) And (arrYearlyRegionSales(j, 2) = 0) And (arrYearlyRegionSales(j, 3) = 0) Then 'If a month = 0 for all 3 Regions
                rchOut.Text += j + 1 & vbTab & " ---- " & vbTab & " ---- " & vbTab & " ---- " & vbNewLine
            Else
                rchOut.Text += j + 1 & vbTab & arrYearlyRegionSales(j, 1) & vbTab & arrYearlyRegionSales(j, 2) & vbTab & arrYearlyRegionSales(j, 3) & vbNewLine
            End If
        Next
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' ...... Calculate Sum of ALL Regions
        Dim dTotal As Double
        For j = 1 To 3
            For k = 0 To 11
                dTotal += arrYearlyRegionSales(k, j)
            Next
        Next

        lblTotalSales.Text = dTotal.ToString("C2")

        ' ..... Calculate % contribution per Region
        'KZN
        Dim KZN_Sales As Double
        For j = 0 To 11
            KZN_Sales += arrYearlyRegionSales(j, 1)
        Next
        lblKZN_Perc.Text = Format((KZN_Sales) / (dTotal), "0.00%")

        'GAU
        Dim GAU_Sales As Double
        For j = 0 To 11
            GAU_Sales += arrYearlyRegionSales(j, 2)
        Next
        lblGAU_Perc.Text = Format((GAU_Sales) / (dTotal), "0.00%")

        'WCP
        Dim WCP_Sales As Double
        For j = 0 To 11
            WCP_Sales += arrYearlyRegionSales(j, 3)
        Next
        lblWCP_Perc.Text = Format((WCP_Sales) / (dTotal), "0.00%")

        'MsgBox(Format((WCP_Sales) / (dTotal) + (GAU_Sales) / (dTotal) + (KZN_Sales) / (dTotal), "0.00%"))

    End Sub

    Private Sub frm_ITI_Hub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate Inputs
        txtKZN.Text = 0
        txtGAU.Text = 0
        txtWCP.Text = 0

        For j = 1 To 12
            cmbMnth.Items.Add(j)
        Next

        'Load Sales into array

        'KZN 6 Month Sale [hard coded]
        arrYearlyRegionSales(0, 1) = 120000
        arrYearlyRegionSales(1, 1) = 190000
        arrYearlyRegionSales(2, 1) = 175000
        arrYearlyRegionSales(3, 1) = 188000
        arrYearlyRegionSales(4, 1) = 125000
        arrYearlyRegionSales(5, 1) = 163000

        'GAU 6 Month Sale [hard coded]
        arrYearlyRegionSales(0, 2) = 90000
        arrYearlyRegionSales(1, 2) = 85000
        arrYearlyRegionSales(2, 2) = 80000
        arrYearlyRegionSales(3, 2) = 83000
        arrYearlyRegionSales(4, 2) = 87000
        arrYearlyRegionSales(5, 2) = 80000

        'WCP 6 Month Sale [hard coded]
        arrYearlyRegionSales(0, 3) = 65000
        arrYearlyRegionSales(1, 3) = 64000
        arrYearlyRegionSales(2, 3) = 71000
        arrYearlyRegionSales(3, 3) = 67000
        arrYearlyRegionSales(4, 3) = 65000
        arrYearlyRegionSales(5, 3) = 64000

        Call Display()

    End Sub

    Private Sub btnSubmitSales_Click(sender As Object, e As EventArgs) Handles btnAddNewSales.Click

        'Create and Assign VARS
        Dim iMnth As Integer
        Dim dKZN, dGAU, dWCP As Double

        dKZN = txtKZN.Text
        dGAU = txtGAU.Text
        dWCP = txtWCP.Text

        'Add to current values

        'if no input in cmbMnth --> Find 1st zero value (...for all three regions)
        If (cmbMnth.SelectedIndex = -1) Then
            Dim iZeroPos As Integer
            For j = 0 To UBound(arrYearlyRegionSales)
                If (arrYearlyRegionSales(j, 1) = 0) And (arrYearlyRegionSales(j, 2) = 0) And (arrYearlyRegionSales(j, 3) = 0) Then 'If a month = 0 for all 3 
                    'MsgBox("Pos Zero found at " & j)
                    iZeroPos = j
                    Exit For
                End If
            Next
            iMnth = iZeroPos
        Else
            iMnth = cmbMnth.Text
            iMnth -= 1
        End If

        'Insert User input
        arrYearlyRegionSales(iMnth, 1) = txtKZN.Text
        arrYearlyRegionSales(iMnth, 2) = txtGAU.Text
        arrYearlyRegionSales(iMnth, 3) = txtWCP.Text

        'MsgBox("Values Add" & vbNewLine & arrYearlyRegionSales(iMnth, 1) & vbNewLine & arrYearlyRegionSales(iMnth, 2) & vbNewLine & arrYearlyRegionSales(iMnth, 3))

        rchOut.Clear()
        'Set headings
        rchOut.Text = "Month" & vbTab & "KZN Sales (R)" & vbTab & "GAU Sales (R)" & vbTab & "WCP Sales (R)" & vbNewLine

        'Display Monthly Sales
        For j = 0 To UBound(arrYearlyRegionSales)
            If (arrYearlyRegionSales(j, 1) = 0) And (arrYearlyRegionSales(j, 2) = 0) And (arrYearlyRegionSales(j, 3) = 0) Then 'If a month = 0 for all 3 Regions
                rchOut.Text += j + 1 & vbTab & " ---- " & vbTab & " ---- " & vbTab & " ---- " & vbNewLine
            Else
                rchOut.Text += j + 1 & vbTab & arrYearlyRegionSales(j, 1) & vbTab & arrYearlyRegionSales(j, 2) & vbTab & arrYearlyRegionSales(j, 3) & vbNewLine
            End If
        Next

    End Sub
End Class
