<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cbDivisi = New ComboBox()
        rbWanita = New RadioButton()
        rbPria = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtTelp = New MaskedTextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        gbAktivitas = New GroupBox()
        Label12 = New Label()
        chk5 = New CheckBox()
        chk8 = New CheckBox()
        chk6 = New CheckBox()
        chk7 = New CheckBox()
        gbHobi = New GroupBox()
        Label11 = New Label()
        chk1 = New CheckBox()
        chk2 = New CheckBox()
        chk3 = New CheckBox()
        chk4 = New CheckBox()
        gbPeran = New GroupBox()
        rbPeran3 = New RadioButton()
        rbPeran2 = New RadioButton()
        rbPeran1 = New RadioButton()
        Label13 = New Label()
        btnBrowse = New Button()
        pbFotoProfil = New PictureBox()
        OFD1 = New OpenFileDialog()
        SFD1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbAktivitas.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(774, 28)
        MenuStrip1.TabIndex = 0
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.Buttons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(0, 26)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 428)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.b390f6d74ca9a1051d7280cdee7278ef
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(cbDivisi)
        TabPage1.Controls.Add(rbWanita)
        TabPage1.Controls.Add(rbPria)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(768, 392)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.BackColor = SystemColors.ControlLight
        cbDivisi.Font = New Font("Trebuchet MS", 9F)
        cbDivisi.FormattingEnabled = True
        cbDivisi.Location = New Point(148, 213)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(353, 28)
        cbDivisi.TabIndex = 11
        ' 
        ' rbWanita
        ' 
        rbWanita.AutoSize = True
        rbWanita.BackColor = Color.Transparent
        rbWanita.Font = New Font("Trebuchet MS", 9F)
        rbWanita.Location = New Point(218, 175)
        rbWanita.Name = "rbWanita"
        rbWanita.Size = New Size(76, 24)
        rbWanita.TabIndex = 10
        rbWanita.Text = "Wanita"
        rbWanita.UseVisualStyleBackColor = False
        ' 
        ' rbPria
        ' 
        rbPria.AutoSize = True
        rbPria.BackColor = Color.Transparent
        rbPria.Font = New Font("Trebuchet MS", 9F)
        rbPria.Location = New Point(148, 175)
        rbPria.Name = "rbPria"
        rbPria.Size = New Size(55, 24)
        rbPria.TabIndex = 9
        rbPria.Text = "Pria"
        rbPria.UseVisualStyleBackColor = False
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Font = New Font("Trebuchet MS", 9F)
        dtpLahir.Location = New Point(148, 133)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(346, 25)
        dtpLahir.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.BackColor = SystemColors.ControlLight
        txtID.Font = New Font("Trebuchet MS", 9F)
        txtID.Location = New Point(148, 95)
        txtID.Name = "txtID"
        txtID.Size = New Size(346, 25)
        txtID.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.ControlLight
        txtNama.Font = New Font("Trebuchet MS", 9F)
        txtNama.Location = New Point(148, 58)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(346, 25)
        txtNama.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Trebuchet MS", 9F)
        Label6.Location = New Point(17, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 20)
        Label6.TabIndex = 5
        Label6.Text = "Jenis Divisi : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Trebuchet MS", 9F)
        Label5.Location = New Point(17, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Trebuchet MS", 9F)
        Label4.Location = New Point(17, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 20)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Trebuchet MS", 9F)
        Label3.Location = New Point(17, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "ID Anggota : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 9F)
        Label2.Location = New Point(17, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(17, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 25)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Data Berikut"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.b390f6d74ca9a1051d7280cdee7278ef
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtxtTelp)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(768, 392)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = SystemColors.ControlLight
        txtAlamat.Font = New Font("Trebuchet MS", 9F)
        txtAlamat.Location = New Point(163, 142)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(408, 25)
        txtAlamat.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ControlLight
        txtEmail.Font = New Font("Trebuchet MS", 9F)
        txtEmail.Location = New Point(163, 98)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "example@gmail.com"
        txtEmail.Size = New Size(408, 25)
        txtEmail.TabIndex = 5
        ' 
        ' mtxtTelp
        ' 
        mtxtTelp.BackColor = SystemColors.ControlLight
        mtxtTelp.Font = New Font("Trebuchet MS", 9F)
        mtxtTelp.Location = New Point(163, 60)
        mtxtTelp.Mask = "0000-0000-0000"
        mtxtTelp.Name = "mtxtTelp"
        mtxtTelp.Size = New Size(408, 25)
        mtxtTelp.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Trebuchet MS", 9F)
        Label10.Location = New Point(23, 142)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 20)
        Label10.TabIndex = 3
        Label10.Text = "Alamat : "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Trebuchet MS", 9F)
        Label9.Location = New Point(23, 101)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 20)
        Label9.TabIndex = 2
        Label9.Text = "Email : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(23, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(276, 25)
        Label8.TabIndex = 1
        Label8.Text = "Masukkan Kontak/Info Berikut"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Trebuchet MS", 9F)
        Label7.Location = New Point(23, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 20)
        Label7.TabIndex = 0
        Label7.Text = "Nomor Telepon : "
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.b390f6d74ca9a1051d7280cdee7278ef
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(gbAktivitas)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFotoProfil)
        TabPage3.Location = New Point(4, 32)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(768, 392)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(144, 309)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(94, 29)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Cetak"
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.BackColor = Color.Transparent
        gbAktivitas.Controls.Add(Label12)
        gbAktivitas.Controls.Add(chk5)
        gbAktivitas.Controls.Add(chk8)
        gbAktivitas.Controls.Add(chk6)
        gbAktivitas.Controls.Add(chk7)
        gbAktivitas.Location = New Point(518, 135)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(216, 203)
        gbAktivitas.TabIndex = 10
        gbAktivitas.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 23)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 20)
        Label12.TabIndex = 0
        Label12.Text = "Aktivitas"
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(18, 60)
        chk5.Name = "chk5"
        chk5.Size = New Size(154, 24)
        chk5.TabIndex = 5
        chk5.Text = "Workshop Speaker"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(18, 150)
        chk8.Name = "chk8"
        chk8.Size = New Size(146, 24)
        chk8.TabIndex = 8
        chk8.Text = "UI/UX Researcher"
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(18, 90)
        chk6.Name = "chk6"
        chk6.Size = New Size(140, 24)
        chk6.TabIndex = 6
        chk6.Text = "Project Manager"
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(18, 120)
        chk7.Name = "chk7"
        chk7.Size = New Size(106, 24)
        chk7.TabIndex = 7
        chk7.Text = "Bug Hunter"
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.Transparent
        gbHobi.Controls.Add(Label11)
        gbHobi.Controls.Add(chk1)
        gbHobi.Controls.Add(chk2)
        gbHobi.Controls.Add(chk3)
        gbHobi.Controls.Add(chk4)
        gbHobi.Location = New Point(276, 135)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(236, 203)
        gbHobi.TabIndex = 9
        gbHobi.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(20, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 20)
        Label11.TabIndex = 2
        Label11.Text = "Hobby : "
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(20, 60)
        chk1.Name = "chk1"
        chk1.Size = New Size(207, 24)
        chk1.TabIndex = 1
        chk1.Text = "Competitive Programming"
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(20, 90)
        chk2.Name = "chk2"
        chk2.Size = New Size(122, 24)
        chk2.TabIndex = 2
        chk2.Text = "IoT Enthusiast"
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(20, 120)
        chk3.Name = "chk3"
        chk3.Size = New Size(150, 24)
        chk3.TabIndex = 3
        chk3.Text = "UI/UX Exploration"
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(20, 150)
        chk4.Name = "chk4"
        chk4.Size = New Size(164, 24)
        chk4.TabIndex = 4
        chk4.Text = "Game Development"
        ' 
        ' gbPeran
        ' 
        gbPeran.BackColor = Color.Transparent
        gbPeran.Controls.Add(rbPeran3)
        gbPeran.Controls.Add(rbPeran2)
        gbPeran.Controls.Add(rbPeran1)
        gbPeran.Controls.Add(Label13)
        gbPeran.Location = New Point(274, 19)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(460, 110)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        ' 
        ' rbPeran3
        ' 
        rbPeran3.AutoSize = True
        rbPeran3.Location = New Point(318, 61)
        rbPeran3.Name = "rbPeran3"
        rbPeran3.Size = New Size(74, 24)
        rbPeran3.TabIndex = 3
        rbPeran3.TabStop = True
        rbPeran3.Text = "Admin"
        rbPeran3.UseVisualStyleBackColor = True
        ' 
        ' rbPeran2
        ' 
        rbPeran2.AutoSize = True
        rbPeran2.Location = New Point(165, 61)
        rbPeran2.Name = "rbPeran2"
        rbPeran2.Size = New Size(88, 24)
        rbPeran2.TabIndex = 2
        rbPeran2.TabStop = True
        rbPeran2.Text = "Anggota"
        rbPeran2.UseVisualStyleBackColor = True
        ' 
        ' rbPeran1
        ' 
        rbPeran1.AutoSize = True
        rbPeran1.Location = New Point(22, 61)
        rbPeran1.Name = "rbPeran1"
        rbPeran1.Size = New Size(68, 24)
        rbPeran1.TabIndex = 1
        rbPeran1.TabStop = True
        rbPeran1.Text = "Ketua"
        rbPeran1.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(22, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 20)
        Label13.TabIndex = 0
        Label13.Text = "Pilihan Peran : "
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(23, 309)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        ' 
        ' pbFotoProfil
        ' 
        pbFotoProfil.BorderStyle = BorderStyle.FixedSingle
        pbFotoProfil.Location = New Point(23, 26)
        pbFotoProfil.Name = "pbFotoProfil"
        pbFotoProfil.Size = New Size(215, 253)
        pbFotoProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoProfil.TabIndex = 0
        pbFotoProfil.TabStop = False
        ' 
        ' OFD1
        ' 
        OFD1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(774, 454)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form Cetak"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents rbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents rbPria As System.Windows.Forms.RadioButton
    Friend WithEvents dtpLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents mtxtTelp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents pbFotoProfil As System.Windows.Forms.PictureBox
    Friend WithEvents gbPeran As System.Windows.Forms.GroupBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk8 As System.Windows.Forms.CheckBox
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rbPeran3 As RadioButton
    Friend WithEvents rbPeran2 As RadioButton
    Friend WithEvents rbPeran1 As RadioButton
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents SFD1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class