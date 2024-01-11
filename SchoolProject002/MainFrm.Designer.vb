<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.StaffToolStripMenuItem, Me.ExamToolStripMenuItem, Me.ReportToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.ManageStudentToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'ManageStudentToolStripMenuItem
        '
        Me.ManageStudentToolStripMenuItem.Name = "ManageStudentToolStripMenuItem"
        Me.ManageStudentToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ManageStudentToolStripMenuItem.Text = "Manage Student"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffToolStripMenuItem, Me.ManageStaffToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'ManageStaffToolStripMenuItem
        '
        Me.ManageStaffToolStripMenuItem.Name = "ManageStaffToolStripMenuItem"
        Me.ManageStaffToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageStaffToolStripMenuItem.Text = "Manage Staff"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterCAToolStripMenuItem, Me.EnterExamToolStripMenuItem})
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeResultsToolStripMenuItem, Me.PrintResultToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'EnterCAToolStripMenuItem
        '
        Me.EnterCAToolStripMenuItem.Name = "EnterCAToolStripMenuItem"
        Me.EnterCAToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnterCAToolStripMenuItem.Text = "Enter CA"
        '
        'EnterExamToolStripMenuItem
        '
        Me.EnterExamToolStripMenuItem.Name = "EnterExamToolStripMenuItem"
        Me.EnterExamToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnterExamToolStripMenuItem.Text = "Enter Exam"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDManageToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ADDManageToolStripMenuItem
        '
        Me.ADDManageToolStripMenuItem.Name = "ADDManageToolStripMenuItem"
        Me.ADDManageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ADDManageToolStripMenuItem.Text = "ADD/Manage"
        '
        'ComputeResultsToolStripMenuItem
        '
        Me.ComputeResultsToolStripMenuItem.Name = "ComputeResultsToolStripMenuItem"
        Me.ComputeResultsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ComputeResultsToolStripMenuItem.Text = "Compute Results"
        '
        'PrintResultToolStripMenuItem
        '
        Me.PrintResultToolStripMenuItem.Name = "PrintResultToolStripMenuItem"
        Me.PrintResultToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PrintResultToolStripMenuItem.Text = "Print Result"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 416)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADDManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputeResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
