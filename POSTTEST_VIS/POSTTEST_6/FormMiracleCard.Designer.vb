<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMiracleCard
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtEfekMiracle = New TextBox()
        Label13 = New Label()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        txtSearch = New TextBox()
        Label9 = New Label()
        dgvMiracle = New DataGridView()
        txtDeskripsi = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        cmbRarity = New ComboBox()
        Label4 = New Label()
        txtNamaKartu = New TextBox()
        Label3 = New Label()
        txtKodeKartu = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtJumlahMiracle = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(dgvMiracle, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtEfekMiracle
        ' 
        txtEfekMiracle.BackColor = Color.White
        txtEfekMiracle.BorderStyle = BorderStyle.FixedSingle
        txtEfekMiracle.Location = New Point(12, 286)
        txtEfekMiracle.Name = "txtEfekMiracle"
        txtEfekMiracle.Size = New Size(295, 27)
        txtEfekMiracle.TabIndex = 83
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label13.Location = New Point(12, 263)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 20)
        Label13.TabIndex = 84
        Label13.Text = "Efek Miracle"
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(180), CByte(210), CByte(230))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(40), CByte(70), CByte(90))
        btnBatal.Location = New Point(325, 423)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(105, 40)
        btnBatal.TabIndex = 85
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(80), CByte(80))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(325, 369)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(105, 40)
        btnHapus.TabIndex = 86
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(180))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(325, 313)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(105, 40)
        btnUbah.TabIndex = 87
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(325, 261)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(105, 40)
        btnSimpan.TabIndex = 88
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(490, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "🔍 Ketik nama kartu..."
        txtSearch.Size = New Size(350, 27)
        txtSearch.TabIndex = 89
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label9.Location = New Point(446, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 90
        Label9.Text = "Cari :"
        ' 
        ' dgvMiracle
        ' 
        dgvMiracle.BackgroundColor = Color.White
        dgvMiracle.BorderStyle = BorderStyle.None
        dgvMiracle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        dgvMiracle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMiracle.ColumnHeadersHeight = 29
        dgvMiracle.EnableHeadersVisualStyles = False
        dgvMiracle.GridColor = Color.FromArgb(CByte(200), CByte(220), CByte(240))
        dgvMiracle.Location = New Point(446, 59)
        dgvMiracle.Name = "dgvMiracle"
        dgvMiracle.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(210), CByte(235), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        dgvMiracle.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvMiracle.Size = New Size(705, 413)
        dgvMiracle.TabIndex = 91
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Location = New Point(12, 346)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(295, 117)
        txtDeskripsi.TabIndex = 92
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label8.Location = New Point(12, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 93
        Label8.Text = "Deskripsi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label7.Location = New Point(12, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 20)
        Label7.TabIndex = 94
        Label7.Text = "Jumlah Miracle"
        ' 
        ' cmbRarity
        ' 
        cmbRarity.BackColor = Color.White
        cmbRarity.FlatStyle = FlatStyle.Flat
        cmbRarity.Location = New Point(12, 179)
        cmbRarity.Name = "cmbRarity"
        cmbRarity.Size = New Size(295, 28)
        cmbRarity.TabIndex = 95
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 96
        Label4.Text = "Rarity"
        ' 
        ' txtNamaKartu
        ' 
        txtNamaKartu.BorderStyle = BorderStyle.FixedSingle
        txtNamaKartu.Location = New Point(12, 125)
        txtNamaKartu.Name = "txtNamaKartu"
        txtNamaKartu.Size = New Size(295, 27)
        txtNamaKartu.TabIndex = 97
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label3.Location = New Point(12, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 98
        Label3.Text = "Nama Kartu"
        ' 
        ' txtKodeKartu
        ' 
        txtKodeKartu.BorderStyle = BorderStyle.FixedSingle
        txtKodeKartu.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtKodeKartu.Location = New Point(12, 72)
        txtKodeKartu.Name = "txtKodeKartu"
        txtKodeKartu.Size = New Size(295, 27)
        txtKodeKartu.TabIndex = 99
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 100
        Label2.Text = "Kode Kartu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(80), CByte(150))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 36)
        Label1.TabIndex = 101
        Label1.Text = "MIRACLE CARD"
        ' 
        ' txtJumlahMiracle
        ' 
        txtJumlahMiracle.BorderStyle = BorderStyle.FixedSingle
        txtJumlahMiracle.Location = New Point(12, 233)
        txtJumlahMiracle.Name = "txtJumlahMiracle"
        txtJumlahMiracle.Size = New Size(295, 27)
        txtJumlahMiracle.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormMiracleCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1163, 484)
        Controls.Add(txtJumlahMiracle)
        Controls.Add(txtEfekMiracle)
        Controls.Add(Label13)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(Label9)
        Controls.Add(dgvMiracle)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(cmbRarity)
        Controls.Add(Label4)
        Controls.Add(txtNamaKartu)
        Controls.Add(Label3)
        Controls.Add(txtKodeKartu)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormMiracleCard"
        Text = "Animal Kaiser - Miracle Card"
        CType(dgvMiracle, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEfekMiracle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvMiracle As DataGridView
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbRarity As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaKartu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeKartu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJumlahMiracle As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class