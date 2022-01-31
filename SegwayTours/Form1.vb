Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tour.Items.Insert(0, "Select Tour")
        cmb_tour.Items.Insert(1, "Golden Gate Tour ($79.99)")
        cmb_tour.Items.Insert(2, "Waterfront Tour ($69.99)")
        cmb_tour.SelectedIndex = 0
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs) Handles btn_compute.Click
        Dim tourPrice As Double
        Select Case cmb_tour.SelectedIndex
            Case 1
                tourPrice = 79.99
            Case 2
                tourPrice = 69.99
            Case Else
                MessageBox.Show("Please select a tour", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select

        Dim discPrice As Integer
        Select Case lb_dicount.SelectedIndex
            Case 0
                discPrice = 10
            Case 1
                discPrice = 20
            Case 3
                discPrice = 30
            Case Else
                discPrice = 0
        End Select

        Dim tickets As Integer
        If (txt_tickets.Text <> String.Empty Or txt_tickets.Text > 0) Then
            tickets = txt_tickets.Text
        Else
            MessageBox.Show("Enter number of tickets", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Dim total As Double
        total = computeTotal(tickets, tourPrice, discPrice)

        lbl_total.Text = total
    End Sub

    Public Function computeTotal(ByVal noTickets As Integer, ByVal tourPrice As Double, ByVal discount As Integer) As Double
        Dim semiTotal As Double
        semiTotal = noTickets * tourPrice
        If (discount <> 0) Then
            Return semiTotal - (semiTotal * 10) / 100
        Else
            Return semiTotal
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl_total.Text = "Your final tour cost is"
        cmb_tour.SelectedIndex = 0
        lb_dicount.SelectedIndex = -1
        txt_tickets.Text = String.Empty
    End Sub
End Class
