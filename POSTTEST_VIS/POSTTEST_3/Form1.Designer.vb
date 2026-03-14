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
        pbProfile = New PictureBox()
        btnBrowse = New Button()
        txtTelepon = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        cbHobby10 = New CheckBox()
        cbHobby9 = New CheckBox()
        cbHobby8 = New CheckBox()
        cbHobby7 = New CheckBox()
        cbHobby6 = New CheckBox()
        cbHobby5 = New CheckBox()
        cbHobby4 = New CheckBox()
        cbHobby3 = New CheckBox()
        cbHobby2 = New CheckBox()
        cbHobby1 = New CheckBox()
        dtpLahir = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnCetak = New Button()
        PictureBox1 = New PictureBox()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobby.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbProfile
        ' 
        pbProfile.BorderStyle = BorderStyle.FixedSingle
        pbProfile.Location = New Point(12, 25)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(251, 294)
        pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfile.TabIndex = 0
        pbProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(14, 346)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(117, 33)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(428, 153)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(291, 25)
        txtTelepon.TabIndex = 2
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(428, 68)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(291, 25)
        txtUmur.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(428, 25)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(291, 25)
        txtNama.TabIndex = 4
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(428, 196)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(291, 25)
        txtAlamat.TabIndex = 5
        ' 
        ' gbGender
        ' 
        gbGender.BackColor = Color.Transparent
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Font = New Font("Mongolian Baiti", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        gbGender.Location = New Point(297, 226)
        gbGender.Name = "gbGender"
        gbGender.Size = New Size(268, 168)
        gbGender.TabIndex = 6
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(28, 59)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(98, 20)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(28, 32)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(84, 20)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = Color.Transparent
        gbHobby.Controls.Add(cbHobby10)
        gbHobby.Controls.Add(cbHobby9)
        gbHobby.Controls.Add(cbHobby8)
        gbHobby.Controls.Add(cbHobby7)
        gbHobby.Controls.Add(cbHobby6)
        gbHobby.Controls.Add(cbHobby5)
        gbHobby.Controls.Add(cbHobby4)
        gbHobby.Controls.Add(cbHobby3)
        gbHobby.Controls.Add(cbHobby2)
        gbHobby.Controls.Add(cbHobby1)
        gbHobby.Location = New Point(584, 226)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(292, 168)
        gbHobby.TabIndex = 7
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' cbHobby10
        ' 
        cbHobby10.AutoSize = True
        cbHobby10.Location = New Point(140, 131)
        cbHobby10.Name = "cbHobby10"
        cbHobby10.Size = New Size(120, 22)
        cbHobby10.TabIndex = 9
        cbHobby10.Text = "Menggambar"
        cbHobby10.UseVisualStyleBackColor = True
        ' 
        ' cbHobby9
        ' 
        cbHobby9.AutoSize = True
        cbHobby9.Location = New Point(140, 104)
        cbHobby9.Name = "cbHobby9"
        cbHobby9.Size = New Size(91, 22)
        cbHobby9.TabIndex = 8
        cbHobby9.Text = "Fotografi"
        cbHobby9.UseVisualStyleBackColor = True
        ' 
        ' cbHobby8
        ' 
        cbHobby8.AutoSize = True
        cbHobby8.Location = New Point(140, 77)
        cbHobby8.Name = "cbHobby8"
        cbHobby8.Size = New Size(93, 22)
        cbHobby8.TabIndex = 7
        cbHobby8.Text = "Olahraga"
        cbHobby8.UseVisualStyleBackColor = True
        ' 
        ' cbHobby7
        ' 
        cbHobby7.AutoSize = True
        cbHobby7.Location = New Point(140, 50)
        cbHobby7.Name = "cbHobby7"
        cbHobby7.Size = New Size(71, 22)
        cbHobby7.TabIndex = 6
        cbHobby7.Text = "Musik"
        cbHobby7.UseVisualStyleBackColor = True
        ' 
        ' cbHobby6
        ' 
        cbHobby6.AutoSize = True
        cbHobby6.Location = New Point(140, 23)
        cbHobby6.Name = "cbHobby6"
        cbHobby6.Size = New Size(94, 22)
        cbHobby6.TabIndex = 5
        cbHobby6.Text = "Berkebun"
        cbHobby6.UseVisualStyleBackColor = True
        ' 
        ' cbHobby5
        ' 
        cbHobby5.AutoSize = True
        cbHobby5.Location = New Point(7, 131)
        cbHobby5.Name = "cbHobby5"
        cbHobby5.Size = New Size(95, 22)
        cbHobby5.TabIndex = 4
        cbHobby5.Text = "Memasak"
        cbHobby5.UseVisualStyleBackColor = True
        ' 
        ' cbHobby4
        ' 
        cbHobby4.AutoSize = True
        cbHobby4.Location = New Point(7, 104)
        cbHobby4.Name = "cbHobby4"
        cbHobby4.Size = New Size(85, 22)
        cbHobby4.TabIndex = 3
        cbHobby4.Text = "Gaming"
        cbHobby4.UseVisualStyleBackColor = True
        ' 
        ' cbHobby3
        ' 
        cbHobby3.AutoSize = True
        cbHobby3.Location = New Point(7, 77)
        cbHobby3.Name = "cbHobby3"
        cbHobby3.Size = New Size(96, 22)
        cbHobby3.TabIndex = 2
        cbHobby3.Text = "Membaca"
        cbHobby3.UseVisualStyleBackColor = True
        ' 
        ' cbHobby2
        ' 
        cbHobby2.AutoSize = True
        cbHobby2.Location = New Point(7, 50)
        cbHobby2.Name = "cbHobby2"
        cbHobby2.Size = New Size(77, 22)
        cbHobby2.TabIndex = 1
        cbHobby2.Text = "Coding"
        cbHobby2.UseVisualStyleBackColor = True
        ' 
        ' cbHobby1
        ' 
        cbHobby1.AutoSize = True
        cbHobby1.Location = New Point(7, 23)
        cbHobby1.Name = "cbHobby1"
        cbHobby1.Size = New Size(83, 22)
        cbHobby1.TabIndex = 0
        cbHobby1.Text = "Menulis"
        cbHobby1.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(428, 110)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(291, 25)
        dtpLahir.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(297, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 18)
        Label1.TabIndex = 9
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(297, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 18)
        Label2.TabIndex = 10
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(297, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 18)
        Label3.TabIndex = 11
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(297, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 18)
        Label4.TabIndex = 12
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(297, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 18)
        Label5.TabIndex = 13
        Label5.Text = "Alamat"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = SystemColors.ControlLight
        btnCetak.Location = New Point(148, 333)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(117, 51)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.stephen
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(706, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 215)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0e3274a31efb12df0f5897ae389d16dd
        ClientSize = New Size(900, 405)
        Controls.Add(btnCetak)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpLahir)
        Controls.Add(gbHobby)
        Controls.Add(gbGender)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(txtUmur)
        Controls.Add(txtTelepon)
        Controls.Add(btnBrowse)
        Controls.Add(pbProfile)
        Controls.Add(PictureBox1)
        Font = New Font("Georgia", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Name = "Form1"
        Text = "Cetak Kartu"
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Deklarasi variabel yang sudah disesuaikan namanya dengan InitializeComponent
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobby As GroupBox
    ' Pastikan nama di sini sama dengan yang ada di InitializeComponent
    Friend WithEvents cbHobby1 As CheckBox
    Friend WithEvents cbHobby2 As CheckBox
    Friend WithEvents cbHobby3 As CheckBox
    Friend WithEvents cbHobby4 As CheckBox
    Friend WithEvents cbHobby5 As CheckBox
    Friend WithEvents cbHobby6 As CheckBox
    Friend WithEvents cbHobby7 As CheckBox
    Friend WithEvents cbHobby8 As CheckBox
    Friend WithEvents cbHobby9 As CheckBox
    Friend WithEvents cbHobby10 As CheckBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
