<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStrongCard
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        txtSearch = New TextBox()
        Label9 = New Label()
        dgvStrong = New DataGridView()
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
        Label10 = New Label()
        txtNilaiP = New TextBox()
        txtNilaiG = New TextBox()
        txtNilaiT = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        txtAura = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvStrong, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(200), CByte(230), CByte(205))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(40), CByte(90), CByte(45))
        btnBatal.Location = New Point(325, 423)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(105, 40)
        btnBatal.TabIndex = 27
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(80), CByte(80))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(325, 369)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(105, 40)
        btnHapus.TabIndex = 28
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(35), CByte(155), CByte(85))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(325, 313)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(105, 40)
        btnUbah.TabIndex = 29
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(45), CByte(174), CByte(55))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(325, 261)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(105, 40)
        btnSimpan.TabIndex = 30
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
        txtSearch.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label9.Location = New Point(446, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 32
        Label9.Text = "Cari :"
        ' 
        ' dgvStrong
        ' 
        dgvStrong.BackgroundColor = Color.White
        dgvStrong.BorderStyle = BorderStyle.None
        dgvStrong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(45), CByte(174), CByte(55))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(45), CByte(174), CByte(55))
        dgvStrong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvStrong.ColumnHeadersHeight = 29
        dgvStrong.EnableHeadersVisualStyles = False
        dgvStrong.GridColor = Color.FromArgb(CByte(200), CByte(230), CByte(200))
        dgvStrong.Location = New Point(446, 59)
        dgvStrong.Name = "dgvStrong"
        dgvStrong.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(210), CByte(245), CByte(215))
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgvStrong.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvStrong.Size = New Size(705, 413)
        dgvStrong.TabIndex = 33
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Location = New Point(12, 403)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(295, 60)
        txtDeskripsi.TabIndex = 34
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label8.Location = New Point(12, 380)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 35
        Label8.Text = "Deskripsi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label7.Location = New Point(12, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 20)
        Label7.TabIndex = 39
        Label7.Text = "Nilai Statistik (1-5)"
        ' 
        ' cmbRarity
        ' 
        cmbRarity.BackColor = Color.White
        cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRarity.FlatStyle = FlatStyle.Flat
        cmbRarity.Location = New Point(12, 179)
        cmbRarity.Name = "cmbRarity"
        cmbRarity.Size = New Size(295, 28)
        cmbRarity.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 45
        Label4.Text = "Rarity"
        ' 
        ' txtNamaKartu
        ' 
        txtNamaKartu.BorderStyle = BorderStyle.FixedSingle
        txtNamaKartu.Location = New Point(12, 125)
        txtNamaKartu.Name = "txtNamaKartu"
        txtNamaKartu.Size = New Size(295, 27)
        txtNamaKartu.TabIndex = 46
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label3.Location = New Point(12, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 47
        Label3.Text = "Nama Kartu"
        ' 
        ' txtKodeKartu
        ' 
        txtKodeKartu.BorderStyle = BorderStyle.FixedSingle
        txtKodeKartu.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        txtKodeKartu.Location = New Point(12, 72)
        txtKodeKartu.Name = "txtKodeKartu"
        txtKodeKartu.Size = New Size(295, 27)
        txtKodeKartu.TabIndex = 48
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 49
        Label2.Text = "Kode Kartu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(45), CByte(174), CByte(55))
        Label1.Location = New Point(12, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 36)
        Label1.TabIndex = 50
        Label1.Text = "STRONG CARD"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 8.0F)
        Label10.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label10.Location = New Point(238, 245)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 19)
        Label10.TabIndex = 51
        Label10.Text = "Power"
        ' 
        ' txtNilaiP
        ' 
        txtNilaiP.BorderStyle = BorderStyle.FixedSingle
        txtNilaiP.Location = New Point(238, 268)
        txtNilaiP.Name = "txtNilaiP"
        txtNilaiP.Size = New Size(69, 27)
        txtNilaiP.TabIndex = 52
        ' 
        ' txtNilaiG
        ' 
        txtNilaiG.BorderStyle = BorderStyle.FixedSingle
        txtNilaiG.Location = New Point(12, 268)
        txtNilaiG.Name = "txtNilaiG"
        txtNilaiG.Size = New Size(69, 27)
        txtNilaiG.TabIndex = 53
        ' 
        ' txtNilaiT
        ' 
        txtNilaiT.BorderStyle = BorderStyle.FixedSingle
        txtNilaiT.Location = New Point(126, 268)
        txtNilaiT.Name = "txtNilaiT"
        txtNilaiT.Size = New Size(69, 27)
        txtNilaiT.TabIndex = 54
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 8.0F)
        Label11.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label11.Location = New Point(12, 245)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 19)
        Label11.TabIndex = 55
        Label11.Text = "Guts"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Comic Sans MS", 8.0F)
        Label12.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label12.Location = New Point(126, 245)
        Label12.Name = "Label12"
        Label12.Size = New Size(41, 19)
        Label12.TabIndex = 56
        Label12.Text = "Tech"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Comic Sans MS", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(35), CByte(130), CByte(45))
        Label13.Location = New Point(12, 316)
        Label13.Name = "Label13"
        Label13.Size = New Size(95, 20)
        Label13.TabIndex = 57
        Label13.Text = "Aura Effect"
        ' 
        ' txtAura
        ' 
        txtAura.BorderStyle = BorderStyle.FixedSingle
        txtAura.Location = New Point(12, 339)
        txtAura.Name = "txtAura"
        txtAura.Size = New Size(295, 27)
        txtAura.TabIndex = 58
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormStrongCard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1163, 484)
        Controls.Add(txtAura)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(txtNilaiT)
        Controls.Add(txtNilaiG)
        Controls.Add(txtNilaiP)
        Controls.Add(Label10)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(Label9)
        Controls.Add(dgvStrong)
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
        Name = "FormStrongCard"
        Text = "Animal Kaiser - Strong Card"
        CType(dgvStrong, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvStrong As DataGridView
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
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNilaiP As TextBox
    Friend WithEvents txtNilaiG As TextBox
    Friend WithEvents txtNilaiT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAura As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class