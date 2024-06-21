<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtGit = New TextBox()
        txtEmail = New TextBox()
        btnToggle = New Button()
        btnSubmit = New Button()
        txtPhone = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Timer1 = New Timer(components)
        lblStopwatch = New Label()
        btnReset = New Button()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(327, 49)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 0
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGit
        ' 
        txtGit.Location = New Point(327, 208)
        txtGit.Name = "txtGit"
        txtGit.Size = New Size(150, 31)
        txtGit.TabIndex = 1
        txtGit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(327, 101)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 2
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnToggle
        ' 
        btnToggle.Location = New Point(291, 294)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(112, 34)
        btnToggle.TabIndex = 3
        btnToggle.Text = "Toggle Stopwatch"
        btnToggle.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(68, 364)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(600, 34)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit Form"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(327, 149)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 5
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 6
        Label1.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 7
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(118, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 8
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(118, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 25)
        Label4.TabIndex = 9
        Label4.Text = "GithubRepo"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(119, 294)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(80, 25)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(512, 294)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 11
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(62, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(415, 25)
        lblTitle.TabIndex = 12
        lblTitle.Text = "Vedanshi Verma, Slidely Task 2 - Create Submission"
        ' 
        ' CreateSubmissions
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(btnReset)
        Controls.Add(lblStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPhone)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggle)
        Controls.Add(txtEmail)
        Controls.Add(txtGit)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissions"
        Text = "CreateSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGit As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnToggle As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblTitle As Label
End Class
