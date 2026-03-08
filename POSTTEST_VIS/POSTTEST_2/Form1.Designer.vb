<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        Label2 = New Label()
        txtJudulTambah = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label3 = New Label()
        dgvBuku = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientActiveCaption
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(14, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(337, 190)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(125, 143)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(96, 32)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(103, 97)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(194, 25)
        txtGenre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 19)
        Label2.TabIndex = 2
        Label2.Text = "Genre :"
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulTambah.Location = New Point(103, 44)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(194, 25)
        txtJudulTambah.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 19)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.GradientActiveCaption
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(389, 18)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(335, 190)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(127, 143)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(96, 32)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulHapus.Location = New Point(111, 47)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(182, 25)
        txtJudulHapus.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 19)
        Label3.TabIndex = 2
        Label3.Text = "Judul Buku :"
        ' 
        ' dgvBuku
        ' 
        dgvBuku.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvBuku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(20), CByte(25), CByte(72))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBuku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkTurquoise
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvBuku.DefaultCellStyle = DataGridViewCellStyle2
        dgvBuku.EnableHeadersVisualStyles = False
        dgvBuku.Location = New Point(187, 12)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(431, 201)
        dgvBuku.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Location = New Point(26, 219)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(744, 219)
        Panel1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(dgvBuku)
        Name = "Form1"
        Text = "Posttest 2 "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    ' DEKLARASI VARIABEL (Bagian yang sering bikin error jika tidak sama)
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel

End Class