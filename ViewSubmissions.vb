Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissions
    Dim currentIndex As Integer = 0
    Dim submissions As JArray

    Private Sub ViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmissions()
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString("http://localhost:3000/read")
            submissions = JArray.Parse(response)
            If submissions.Count > 0 Then
                DisplaySubmission(currentIndex)
            Else
                MessageBox.Show("No submissions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As JObject = submissions(index)
            txtName.Text = submission("name").ToString()
            txtEmail.Text = submission("email").ToString()
            txtPhone.Text = submission("phone").ToString()
            txtGit.Text = submission("github_link").ToString()
            txtStopwatch.Text = submission("stopwatch_time").ToString()
            lblIndex.Text = "Submission " & (index + 1) & " of " & submissions.Count
        Else
            MessageBox.Show("No submission found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("Already at the first submission.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("Already at the last submission.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            txtName.ReadOnly = False
            txtEmail.ReadOnly = False
            txtPhone.ReadOnly = False
            txtGit.ReadOnly = False
            txtStopwatch.ReadOnly = False
            btnEdit.Text = "Save"
        Else
            Dim updatedSubmission As New JObject From {
                {"name", txtName.Text},
                {"email", txtEmail.Text},
                {"phone", txtPhone.Text},
                {"github_link", txtGit.Text},
                {"stopwatch_time", txtStopwatch.Text}
            }

            Try
                Dim client As New WebClient()
                client.Headers(HttpRequestHeader.ContentType) = "application/json"
                client.UploadString("http://localhost:3000/update?index=" & currentIndex, "PUT", updatedSubmission.ToString())
                MessageBox.Show("Submission updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSubmissions()
            Catch ex As Exception
                MessageBox.Show("Error updating submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtPhone.ReadOnly = True
            txtGit.ReadOnly = True
            txtStopwatch.ReadOnly = True
            btnEdit.Text = "Edit"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim client As New WebClient()
                client.UploadString("http://localhost:3000/delete?index=" & currentIndex, "DELETE", String.Empty)
                MessageBox.Show("Submission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If currentIndex >= submissions.Count - 1 Then
                    currentIndex -= 1
                End If
                LoadSubmissions()
            Catch ex As Exception
                MessageBox.Show("Error deleting submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub ViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    ' Ctrl + P for Previous
                    btnPrevious.PerformClick()
                Case Keys.N
                    ' Ctrl + N for Next
                    btnNext.PerformClick()
                Case Keys.D
                    ' Ctrl + D for Delete
                    btnDelete.PerformClick()
                Case Keys.E
                    ' Ctrl + E for Edit
                    btnEdit.PerformClick()
            End Select
        End If
        If e.Control AndAlso e.KeyCode = Keys.Q Then
            Me.Close() ' Exit the application
        End If
    End Sub

    Private Sub ApplyStyling()
        ' Form background color
        Me.BackColor = Color.LightGray

        ' Button styles
        Dim buttonColor As Color = Color.FromArgb(0, 122, 204)
        Dim buttonHoverColor As Color = Color.FromArgb(0, 86, 143)
        Dim buttonForeColor As Color = Color.White

        btnPrevious.BackColor = buttonColor
        btnPrevious.ForeColor = buttonForeColor
        btnNext.BackColor = buttonColor
        btnNext.ForeColor = buttonForeColor
        btnEdit.BackColor = buttonColor
        btnEdit.ForeColor = buttonForeColor
        btnDelete.BackColor = Color.FromArgb(220, 53, 69)
        btnDelete.ForeColor = buttonForeColor

        ' Text box styles
        Dim textBoxColor As Color = Color.WhiteSmoke
        Dim textBoxBorderColor As Color = Color.Silver

        txtName.BackColor = textBoxColor
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtEmail.BackColor = textBoxColor
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtPhone.BackColor = textBoxColor
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtGit.BackColor = textBoxColor
        txtGit.BorderStyle = BorderStyle.FixedSingle

        ' Label styles
        lblIndex.ForeColor = Color.DimGray
    End Sub

    Private Sub ViewSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyStyling()
    End Sub



End Class
