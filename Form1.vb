Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ApplyStyling()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewSubmissionsForm As New ViewSubmissions()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createSubmissionForm As New CreateSubmissions()
        createSubmissionForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if Ctrl+V is pressed for View Submissions
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick() ' Simulate a click on the View Submissions button
        End If

        ' Check if Ctrl+C is pressed for Create Submissions
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Button2.PerformClick() ' Simulate a click on the Create Submissions button
        End If
        If e.Control AndAlso e.KeyCode = Keys.Q Then
            Me.Close() ' Exit the application
        End If
    End Sub

    ' Apply styling to controls
    Private Sub ApplyStyling()
        ' Form background color
        Me.BackColor = Color.LightGray
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' Title label
        Dim titleFont As New Font(Me.Font.FontFamily, 14, FontStyle.Bold)
        Dim titleColor As Color = Color.FromArgb(51, 51, 51)

        Dim titleLabel As New Label()
        titleLabel.Text = "Vedanshi Verma, Slidely Task 2 - Slidely Form App"
        titleLabel.Font = titleFont
        titleLabel.ForeColor = titleColor
        titleLabel.AutoSize = True
        titleLabel.Location = New Point(20, 10)
        Me.Controls.Add(titleLabel)

        ' Button styles
        Dim button1Color As Color = Color.FromArgb(255, 255, 204) ' Light pink
        Dim button2Color As Color = Color.FromArgb(255, 255, 153) ' Light yellow

        ApplyButtonStyle(Button1, button1Color, 100)
        ApplyButtonStyle(Button2, button2Color, 160)
    End Sub

    ' Apply styling to buttons
    Private Sub ApplyButtonStyle(button As Button, backColor As Color, topPosition As Integer)
        button.BackColor = backColor
        button.ForeColor = Color.Black ' Set text color to black for better visibility
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.Font = New Font(Me.Font.FontFamily, 12, FontStyle.Bold)
        button.Size = New Size(250, 50) ' Bigger size length-wise
        button.Location = New Point((Me.ClientSize.Width - button.Width) / 2, topPosition)
        button.Anchor = AnchorStyles.None ' Center horizontally
        button.Cursor = Cursors.Hand
    End Sub
End Class
