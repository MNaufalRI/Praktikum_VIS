<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemain
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        txtIdPemain = New TextBox()
        Label3 = New Label()
        txtNama = New TextBox()
        Label4 = New Label()
        txtUsername = New TextBox()
        lblStatDeck = New Label()
        lblStatWin = New Label()
        dgvDeckMilik = New DataGridView()
        Label5 = New Label()
        txtSearch = New TextBox()
        Label9 = New Label()
        dgvPemain = New DataGridView()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvDeckMilik, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPemain, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(11, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 36)
        Label1.TabIndex = 0
        Label1.Text = "PLAYER MANAGEMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Teal
        Label2.Location = New Point(15, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 17
        Label2.Text = "ID Pemain"
        ' 
        ' txtIdPemain
        ' 
        txtIdPemain.BackColor = SystemColors.Info
        txtIdPemain.BorderStyle = BorderStyle.FixedSingle
        txtIdPemain.Location = New Point(15, 77)
        txtIdPemain.Name = "txtIdPemain"
        txtIdPemain.ReadOnly = True
        txtIdPemain.Size = New Size(100, 27)
        txtIdPemain.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Teal
        Label3.Location = New Point(125, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 16
        Label3.Text = "Nama Lengkap"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(125, 77)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(240, 27)
        txtNama.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Teal
        Label4.Location = New Point(15, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 15
        Label4.Text = "Username Unik"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(15, 139)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(349, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblStatDeck
        ' 
        lblStatDeck.AutoSize = True
        lblStatDeck.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold)
        lblStatDeck.Location = New Point(15, 185)
        lblStatDeck.Name = "lblStatDeck"
        lblStatDeck.Size = New Size(152, 21)
        lblStatDeck.TabIndex = 14
        lblStatDeck.Text = "Total Deck Milik: -"
        ' 
        ' lblStatWin
        ' 
        lblStatWin.AutoSize = True
        lblStatWin.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold)
        lblStatWin.Location = New Point(200, 185)
        lblStatWin.Name = "lblStatWin"
        lblStatWin.Size = New Size(144, 21)
        lblStatWin.TabIndex = 13
        lblStatWin.Text = "Win/Lose Ratio: -"
        ' 
        ' dgvDeckMilik
        ' 
        dgvDeckMilik.BackgroundColor = Color.WhiteSmoke
        dgvDeckMilik.BorderStyle = BorderStyle.Fixed3D
        dgvDeckMilik.ColumnHeadersHeight = 29
        dgvDeckMilik.Location = New Point(15, 235)
        dgvDeckMilik.Name = "dgvDeckMilik"
        dgvDeckMilik.RowHeadersVisible = False
        dgvDeckMilik.RowHeadersWidth = 51
        dgvDeckMilik.Size = New Size(350, 149)
        dgvDeckMilik.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(15, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 22)
        Label5.TabIndex = 12
        Label5.Text = "Daftar Deck Terdaftar"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Location = New Point(525, 19)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "🔍 Cari nama atau username..."
        txtSearch.Size = New Size(349, 27)
        txtSearch.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.Teal
        Label9.Location = New Point(475, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 11
        Label9.Text = "Cari :"
        ' 
        ' dgvPemain
        ' 
        dgvPemain.BackgroundColor = Color.White
        dgvPemain.BorderStyle = BorderStyle.None
        dgvPemain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Aqua
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        dgvPemain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPemain.ColumnHeadersHeight = 29
        dgvPemain.EnableHeadersVisualStyles = False
        dgvPemain.Location = New Point(400, 60)
        dgvPemain.Name = "dgvPemain"
        dgvPemain.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(210), CByte(245), CByte(215))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        dgvPemain.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvPemain.Size = New Size(741, 400)
        dgvPemain.TabIndex = 6
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(15, 411)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(85, 40)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Teal
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(105, 411)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(85, 40)
        btnUbah.TabIndex = 8
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(80), CByte(80))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(195, 411)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(85, 40)
        btnHapus.TabIndex = 9
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(285, 411)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(80, 40)
        btnBatal.TabIndex = 10
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormPemain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 480)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(dgvPemain)
        Controls.Add(Label9)
        Controls.Add(txtSearch)
        Controls.Add(Label5)
        Controls.Add(dgvDeckMilik)
        Controls.Add(lblStatWin)
        Controls.Add(lblStatDeck)
        Controls.Add(txtUsername)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(txtIdPemain)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPemain"
        Text = "Animal Kaiser - Player Management"
        CType(dgvDeckMilik, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPemain, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdPemain As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblStatDeck As System.Windows.Forms.Label
    Friend WithEvents lblStatWin As System.Windows.Forms.Label
    Friend WithEvents dgvDeckMilik As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvPemain As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class