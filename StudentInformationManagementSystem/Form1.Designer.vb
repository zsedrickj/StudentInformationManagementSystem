<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        btnExit = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnCreate = New Button()
        btnDashBoard = New Button()
        Panel2 = New Panel()
        pnlNav = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        DataGridViewStudents = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(30), CByte(54))
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnCreate)
        Panel1.Controls.Add(btnDashBoard)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(209, 664)
        Panel1.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Bottom
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(0, 622)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(209, 42)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.TextImageRelation = TextImageRelation.TextBeforeImage
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Dock = DockStyle.Top
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.Location = New Point(0, 292)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(209, 42)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete Student"
        btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Dock = DockStyle.Top
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.Location = New Point(0, 250)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(209, 42)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Edit Student"
        btnUpdate.TextImageRelation = TextImageRelation.TextBeforeImage
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.Dock = DockStyle.Top
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatStyle = FlatStyle.Flat
        btnCreate.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreate.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), Image)
        btnCreate.Location = New Point(0, 208)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(209, 42)
        btnCreate.TabIndex = 1
        btnCreate.Text = "Add Student"
        btnCreate.TextImageRelation = TextImageRelation.TextBeforeImage
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnDashBoard
        ' 
        btnDashBoard.Dock = DockStyle.Top
        btnDashBoard.FlatAppearance.BorderSize = 0
        btnDashBoard.FlatStyle = FlatStyle.Flat
        btnDashBoard.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashBoard.ForeColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        btnDashBoard.Image = CType(resources.GetObject("btnDashBoard.Image"), Image)
        btnDashBoard.Location = New Point(0, 166)
        btnDashBoard.Name = "btnDashBoard"
        btnDashBoard.Size = New Size(209, 42)
        btnDashBoard.TabIndex = 1
        btnDashBoard.Text = "Dashboard"
        btnDashBoard.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDashBoard.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(pnlNav)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(209, 166)
        Panel2.TabIndex = 0
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        pnlNav.Location = New Point(0, 193)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(3, 100)
        pnlNav.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 20)
        Label1.TabIndex = 1
        Label1.Text = "Student Management"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.students
        PictureBox1.Location = New Point(68, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(158), CByte(161), CByte(176))
        Label2.Location = New Point(227, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 39)
        Label2.TabIndex = 1
        Label2.Text = "Dashboard"
        ' 
        ' DataGridViewStudents
        ' 
        DataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewStudents.Location = New Point(254, 117)
        DataGridViewStudents.Name = "DataGridViewStudents"
        DataGridViewStudents.RowHeadersWidth = 51
        DataGridViewStudents.Size = New Size(780, 454)
        DataGridViewStudents.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(51), CByte(73))
        ClientSize = New Size(1070, 664)
        Controls.Add(DataGridViewStudents)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashBoard As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewStudents As DataGridView

End Class
