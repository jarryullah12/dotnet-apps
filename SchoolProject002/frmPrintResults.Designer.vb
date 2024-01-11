<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintResults
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btnPrintResult = New System.Windows.Forms.Button()
        Me.cmbStream = New System.Windows.Forms.ComboBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SMS = New SchoolProject002.SMS()
        Me.AssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssessmentsTableAdapter = New SchoolProject002.SMSTableAdapters.AssessmentsTableAdapter()
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrintResult
        '
        Me.btnPrintResult.Location = New System.Drawing.Point(567, 50)
        Me.btnPrintResult.Name = "btnPrintResult"
        Me.btnPrintResult.Size = New System.Drawing.Size(122, 50)
        Me.btnPrintResult.TabIndex = 39
        Me.btnPrintResult.Text = "Print Results"
        Me.btnPrintResult.UseVisualStyleBackColor = True
        '
        'cmbStream
        '
        Me.cmbStream.FormattingEnabled = True
        Me.cmbStream.Items.AddRange(New Object() {"Art", "Math", "Science", "Computer"})
        Me.cmbStream.Location = New System.Drawing.Point(344, 25)
        Me.cmbStream.Name = "cmbStream"
        Me.cmbStream.Size = New System.Drawing.Size(199, 21)
        Me.cmbStream.TabIndex = 36
        '
        'cmbSubject
        '
        Me.cmbSubject.Enabled = False
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Items.AddRange(New Object() {"Hindi", "English", "Math", "computer"})
        Me.cmbSubject.Location = New System.Drawing.Point(65, 85)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(478, 21)
        Me.cmbSubject.TabIndex = 38
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Class1"})
        Me.cmbClass.Location = New System.Drawing.Point(65, 25)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(216, 21)
        Me.cmbClass.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Subject"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Stream"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Class"
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "ResultsDS"
        ReportDataSource2.Value = Me.AssessmentsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SchoolProject002.ResultReportTabular.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 123)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(838, 297)
        Me.ReportViewer1.TabIndex = 40
        '
        'SMS
        '
        Me.SMS.DataSetName = "SMS"
        Me.SMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssessmentsBindingSource
        '
        Me.AssessmentsBindingSource.DataMember = "Assessments"
        Me.AssessmentsBindingSource.DataSource = Me.SMS
        '
        'AssessmentsTableAdapter
        '
        Me.AssessmentsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnPrintResult)
        Me.Controls.Add(Me.cmbStream)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmPrintResults"
        Me.Text = "frmPrintResults"
        CType(Me.SMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrintResult As System.Windows.Forms.Button
    Friend WithEvents cmbStream As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SMS As SchoolProject002.SMS
    Friend WithEvents AssessmentsTableAdapter As SchoolProject002.SMSTableAdapters.AssessmentsTableAdapter
End Class
