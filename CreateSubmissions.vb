Imports System.Net
Imports System.Text
Imports System.IO

Public Class CreateSubmissions
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private accumulatedTime As TimeSpan = TimeSpan.Zero

    ' Form Load Event to initialize the stopwatch display
    Private Sub CreateSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set background color
        Me.BackColor = Color.LightGray

        ' Set properties for the title label
        lblTitle.Text = "Vedanshi Verma, Slidely Task 2 - Create Submission"
        lblTitle.Font = New Font(lblTitle.Font.FontFamily, 14, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(10, 10)

        ' Set properties for the stopwatch label
        lblStopwatch.Text = "00:00:00"
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.TextAlign = ContentAlignment.MiddleCenter
        lblStopwatch.Font = New Font(lblStopwatch.Font.FontFamily, 16)

        ' Set TextBox properties
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtGit.BorderStyle = BorderStyle.FixedSingle

        ' Set Button properties
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.BackColor = Color.LightBlue
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.BackColor = Color.LightCoral
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.BackColor = Color.LightGreen

        btnToggle.PerformClick()
    End Sub

    ' Event handler for the Submit button click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim github As String = txtGit.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        ' Display each feature in separate lines in the message box
        MessageBox.Show($"Name: {name}" & vbCrLf &
                        $"Email: {email}" & vbCrLf &
                        $"Phone: {phone}" & vbCrLf &
                        $"GitHub: {github}" & vbCrLf &
                        $"Time: {stopwatchTime}")

        ' Make API call to submit the form
        SubmitForm(name, email, phone, github, stopwatchTime)

        ' Reset form after submission
        ' ResetForm()
        Me.Close()
    End Sub

    ' Method to make API call to submit the form
    Private Sub SubmitForm(name As String, email As String, phone As String, github As String, stopwatchTime As String)
        Dim request As WebRequest = WebRequest.Create("http://localhost:3000/create")
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim postData As String = $"{{""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{github}"",""stopwatch_time"":""{stopwatchTime}""}}"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As WebResponse = request.GetResponse()
        response.Close()
    End Sub

    ' Method to reset the form
    Private Sub ResetForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGit.Text = ""
        accumulatedTime = TimeSpan.Zero
        lblStopwatch.Text = "00:00:00"
        If stopwatchRunning Then
            stopwatchStartTime = DateTime.Now
        End If
    End Sub

    ' Event handler for the Toggle button click
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If stopwatchRunning Then
            ' Stop the stopwatch
            accumulatedTime += DateTime.Now - stopwatchStartTime
            Timer1.Stop()
            btnToggle.Text = "Toggle"
        Else
            ' Start or resume the stopwatch
            stopwatchStartTime = DateTime.Now
            Timer1.Start()
            btnToggle.Text = "Toggle"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    ' Event handler for the Timer Tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsedTime As TimeSpan
        If stopwatchRunning Then
            elapsedTime = DateTime.Now - stopwatchStartTime + accumulatedTime
        Else
            elapsedTime = accumulatedTime
        End If
        lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    ' Event handler for the Reset button click
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        accumulatedTime = TimeSpan.Zero
        lblStopwatch.Text = "00:00:00"
        If stopwatchRunning Then
            stopwatchStartTime = DateTime.Now
        End If
    End Sub

    ' Event handler for key down to handle shortcuts
    Private Sub CreateSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggle.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.R Then
            btnReset.PerformClick()
        End If
    End Sub
End Class
