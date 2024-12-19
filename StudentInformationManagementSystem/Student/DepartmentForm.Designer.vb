<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DepartmentForm
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
        Panel3 = New Panel()
        btnBack = New Button()
        dgvDepartment = New DataGridView()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3.SuspendLayout()
        CType(dgvDepartment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnBack)
        Panel3.Controls.Add(dgvDepartment)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(62, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1046, 468)
        Panel3.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(878, 410)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(96, 27)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvDepartment
        ' 
        dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDepartment.Location = New Point(72, 106)
        dgvDepartment.Name = "dgvDepartment"
        dgvDepartment.RowHeadersWidth = 51
        dgvDepartment.Size = New Size(902, 266)
        dgvDepartment.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label8.Location = New Point(72, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(235, 29)
        Label8.TabIndex = 1
        Label8.Text = "List of departments"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' DepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        ClientSize = New Size(1181, 577)
        Controls.Add(Panel3)
        Font = New Font("Microsoft Sans Serif", 10.2F)
        FormBorderStyle = FormBorderStyle.None
        Name = "DepartmentForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvDepartment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvDepartment As DataGridView
    Friend WithEvents Label8 As Label

End Class
