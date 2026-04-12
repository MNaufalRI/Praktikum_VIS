<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnimalCard
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        txtKodeKartu = New TextBox()
        dgvAnimal = New DataGridView()
        txtSearch = New TextBox()
        txtNamaAnimal = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cmbRarity = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        txtStrength = New TextBox()
        txtHealth = New TextBox()
        Label7 = New Label()
        txtSkillP = New TextBox()
        txtSkillG = New TextBox()
        txtSkillT = New TextBox()
        Label8 = New Label()
        txtDeskripsi = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvAnimal, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 36)
        Label1.TabIndex = 23
        Label1.Text = "ANIMAL CARD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9F)
        Label2.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 22
        Label2.Text = "Kode Kartu"
        ' 
        ' txtKodeKartu
        ' 
        txtKodeKartu.BorderStyle = BorderStyle.FixedSingle
        txtKodeKartu.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtKodeKartu.Location = New Point(12, 72)
        txtKodeKartu.Name = "txtKodeKartu"
        txtKodeKartu.Size = New Size(295, 27)
        txtKodeKartu.TabIndex = 21
        ' 
        ' dgvAnimal
        ' 
        dgvAnimal.BackgroundColor = Color.White
        dgvAnimal.BorderStyle = BorderStyle.None
        dgvAnimal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        dgvAnimal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAnimal.ColumnHeadersHeight = 29
        dgvAnimal.EnableHeadersVisualStyles = False
        dgvAnimal.GridColor = Color.FromArgb(CByte(240), CByte(200), CByte(200))
        dgvAnimal.Location = New Point(446, 59)
        dgvAnimal.Name = "dgvAnimal"
        dgvAnimal.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(210), CByte(210))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        dgvAnimal.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvAnimal.Size = New Size(705, 413)
        dgvAnimal.TabIndex = 6
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(490, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "🔍 Ketik nama kartu..."
        txtSearch.Size = New Size(350, 27)
        txtSearch.TabIndex = 4
        ' 
        ' txtNamaAnimal
        ' 
        txtNamaAnimal.BorderStyle = BorderStyle.FixedSingle
        txtNamaAnimal.Location = New Point(12, 125)
        txtNamaAnimal.Name = "txtNamaAnimal"
        txtNamaAnimal.Size = New Size(295, 27)
        txtNamaAnimal.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9F)
        Label3.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label3.Location = New Point(12, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 20
        Label3.Text = "Nama Kartu"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 9F)
        Label4.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label4.Location = New Point(12, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 18
        Label4.Text = "Rarity"
        ' 
        ' cmbRarity
        ' 
        cmbRarity.BackColor = Color.White
        cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRarity.FlatStyle = FlatStyle.Flat
        cmbRarity.Location = New Point(12, 179)
        cmbRarity.Name = "cmbRarity"
        cmbRarity.Size = New Size(295, 28)
        cmbRarity.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 9F)
        Label5.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label5.Location = New Point(12, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 16
        Label5.Text = "Strength"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 9F)
        Label6.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label6.Location = New Point(182, 210)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 15
        Label6.Text = "Health"
        ' 
        ' txtStrength
        ' 
        txtStrength.BorderStyle = BorderStyle.FixedSingle
        txtStrength.Location = New Point(12, 233)
        txtStrength.Name = "txtStrength"
        txtStrength.Size = New Size(125, 27)
        txtStrength.TabIndex = 14
        ' 
        ' txtHealth
        ' 
        txtHealth.BorderStyle = BorderStyle.FixedSingle
        txtHealth.Location = New Point(182, 233)
        txtHealth.Name = "txtHealth"
        txtHealth.Size = New Size(125, 27)
        txtHealth.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 9F)
        Label7.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label7.Location = New Point(12, 263)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 20)
        Label7.TabIndex = 12
        Label7.Text = "Skills"
        ' 
        ' txtSkillP
        ' 
        txtSkillP.BorderStyle = BorderStyle.FixedSingle
        txtSkillP.Location = New Point(75, 286)
        txtSkillP.Name = "txtSkillP"
        txtSkillP.PlaceholderText = "Power"
        txtSkillP.Size = New Size(232, 27)
        txtSkillP.TabIndex = 11
        ' 
        ' txtSkillG
        ' 
        txtSkillG.BorderStyle = BorderStyle.FixedSingle
        txtSkillG.Location = New Point(75, 320)
        txtSkillG.Name = "txtSkillG"
        txtSkillG.PlaceholderText = "Guts"
        txtSkillG.Size = New Size(232, 27)
        txtSkillG.TabIndex = 10
        ' 
        ' txtSkillT
        ' 
        txtSkillT.BorderStyle = BorderStyle.FixedSingle
        txtSkillT.Location = New Point(75, 354)
        txtSkillT.Name = "txtSkillT"
        txtSkillT.PlaceholderText = "Technique"
        txtSkillT.Size = New Size(232, 27)
        txtSkillT.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 9F)
        Label8.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label8.Location = New Point(12, 384)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 8
        Label8.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Location = New Point(12, 407)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.ScrollBars = ScrollBars.Vertical
        txtDeskripsi.Size = New Size(295, 61)
        txtDeskripsi.TabIndex = 7
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(215), CByte(0), CByte(0))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(325, 261)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(105, 40)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(200), CByte(80), CByte(0))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(325, 313)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(105, 40)
        btnUbah.TabIndex = 2
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
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
        btnHapus.TabIndex = 1
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(245), CByte(210), CByte(210))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(100), CByte(0), CByte(0))
        btnBatal.Location = New Point(325, 423)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(105, 40)
        btnBatal.TabIndex = 0
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(150), CByte(0), CByte(0))
        Label9.Location = New Point(446, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 5
        Label9.Text = "Cari :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Power
        PictureBox1.Location = New Point(31, 286)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Guts1
        PictureBox2.Location = New Point(32, 320)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Tech
        PictureBox3.Location = New Point(32, 354)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormAnimalCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1163, 484)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(Label9)
        Controls.Add(dgvAnimal)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label8)
        Controls.Add(txtSkillT)
        Controls.Add(txtSkillG)
        Controls.Add(txtSkillP)
        Controls.Add(Label7)
        Controls.Add(txtHealth)
        Controls.Add(txtStrength)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cmbRarity)
        Controls.Add(Label4)
        Controls.Add(txtNamaAnimal)
        Controls.Add(Label3)
        Controls.Add(txtKodeKartu)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAnimalCard"
        Text = "Animal Kaiser - Animal Card"
        CType(dgvAnimal, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeKartu As TextBox
    Friend WithEvents dgvAnimal As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtNamaAnimal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRarity As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents txtHealth As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSkillP As TextBox
    Friend WithEvents txtSkillG As TextBox
    Friend WithEvents txtSkillT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class