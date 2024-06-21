<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGit = New TextBox()
        txtStopwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lblIndex = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(233, 77)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(259, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(233, 118)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(259, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(233, 155)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(259, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGit
        ' 
        txtGit.Location = New Point(233, 192)
        txtGit.Name = "txtGit"
        txtGit.ReadOnly = True
        txtGit.Size = New Size(259, 31)
        txtGit.TabIndex = 3
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(233, 229)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(259, 31)
        txtStopwatch.TabIndex = 4
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(59, 300)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(259, 41)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(404, 300)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(255, 41)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(538, 25)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 38)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(637, 25)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 40)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblIndex
        ' 
        lblIndex.AutoSize = True
        lblIndex.Location = New Point(13, 372)
        lblIndex.Name = "lblIndex"
        lblIndex.Size = New Size(64, 25)
        lblIndex.TabIndex = 9
        lblIndex.Text = "Index: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 10
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 11
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 12
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(96, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 13
        Label4.Text = "Github"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(96, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 25)
        Label5.TabIndex = 14
        Label5.Text = "Time Taken"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(405, 25)
        Label6.TabIndex = 15
        Label6.Text = "Vedanshi Verma, Slidely Task 2- View Submissions"
        ' 
        ' ViewSubmissions
        ' 
        ClientSize = New Size(735, 406)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblIndex)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGit)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "ViewSubmissions"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGit As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblIndex As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
