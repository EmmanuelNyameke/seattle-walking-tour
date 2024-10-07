' Program: Seattle Walking Tour
' Author: K Bola
' Date: September 21, 2024
' Purpose: This program computes the cost of seattle walking tour 
Public Class frmSeattle
    Const _cdecPricePerTicket As Decimal = 14.99D
    Const _cdecAdditionalCost As Decimal = 1.99D
    Dim strNumberOfTickets As String
    Dim intNumberOfTickets As Integer
    Dim decTotalCost As Decimal
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        strNumberOfTickets = txtNumberOfTickets.Text
        intNumberOfTickets = Convert.ToInt32(strNumberOfTickets)
        decTotalCost = intNumberOfTickets * _cdecPricePerTicket * _cdecAdditionalCost
        lblCost.Text = decTotalCost.ToString("C") & vbCrLf & "NB: Additional Cost of " & _cdecAdditionalCost.ToString("C") & " was " & vbCrLf & "added as one-time booking " & vbCrLf & "fee for using the app." & vbCrLf & "Thank you for your Cooperation." & vbCrLf & "Enjoy your tour."
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberOfTickets.Clear()
        lblCost.Text = ""
        txtNumberOfTickets.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub frmSeattle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
        txtNumberOfTickets.Focus()
        lblPricePerTour.Text = _cdecPricePerTicket.ToString("C") & " Per Ticket"
    End Sub
End Class
