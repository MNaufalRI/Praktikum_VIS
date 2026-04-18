<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDeckBuilder
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
        Label1 = New Label()
        txtSearch = New TextBox()
        dgvDeck = New DataGridView()
        Label2 = New Label()
        txtIdDeck = New TextBox()
        Label3 = New Label()
        txtNamaDeck = New TextBox()
        Label4 = New Label()
        cmbPemain = New ComboBox()
        Label5 = New Label()
        cmbAnimalCard = New ComboBox()
        lblAnimalInfo = New Label()
        lblAnimalRarity = New Label()
        Label6 = New Label()
        cmbStrongCard = New ComboBox()
        lblStrongInfo = New Label()
        Label7 = New Label()
        cmbMiracleCard = New ComboBox()
        lblMiracleInfo = New Label()
        Label8 = New Label()
        lblTotalPower = New Label()
        prgPower = New ProgressBar()
        Label9 = New Label()
        cmbStatusDeck = New ComboBox()
        Label10 = New Label()
        txtCatatan = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvDeck, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.2F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 27)
        Label1.TabIndex = 0
        Label1.Text = "DECK MANAGEMENT"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(350, 56)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "🔍 Cari nama deck atau pemain..."
        txtSearch.Size = New Size(482, 23)
        txtSearch.TabIndex = 1
        ' 
        ' dgvDeck
        ' 
        dgvDeck.BackgroundColor = Color.White
        dgvDeck.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(45), CByte(174), CByte(55))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        dgvDeck.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDeck.EnableHeadersVisualStyles = False
        dgvDeck.Location = New Point(350, 86)
        dgvDeck.Margin = New Padding(3, 2, 3, 2)
        dgvDeck.Name = "dgvDeck"
        dgvDeck.RowHeadersVisible = False
        dgvDeck.Size = New Size(648, 371)
        dgvDeck.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 18
        Label2.Text = "ID Deck (Auto)"
        ' 
        ' txtIdDeck
        ' 
        txtIdDeck.Location = New Point(13, 56)
        txtIdDeck.Margin = New Padding(3, 2, 3, 2)
        txtIdDeck.Name = "txtIdDeck"
        txtIdDeck.ReadOnly = True
        txtIdDeck.Size = New Size(88, 23)
        txtIdDeck.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(109, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 19
        Label3.Text = "Nama Deck"
        ' 
        ' txtNamaDeck
        ' 
        txtNamaDeck.Location = New Point(109, 56)
        txtNamaDeck.Margin = New Padding(3, 2, 3, 2)
        txtNamaDeck.Name = "txtNamaDeck"
        txtNamaDeck.Size = New Size(210, 23)
        txtNamaDeck.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 20
        Label4.Text = "Pemain Owner"
        ' 
        ' cmbPemain
        ' 
        cmbPemain.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPemain.Location = New Point(13, 98)
        cmbPemain.Margin = New Padding(3, 2, 3, 2)
        cmbPemain.Name = "cmbPemain"
        cmbPemain.Size = New Size(307, 23)
        cmbPemain.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 15)
        Label5.TabIndex = 21
        Label5.Text = "Animal Card"
        ' 
        ' cmbAnimalCard
        ' 
        cmbAnimalCard.Location = New Point(13, 142)
        cmbAnimalCard.Margin = New Padding(3, 2, 3, 2)
        cmbAnimalCard.Name = "cmbAnimalCard"
        cmbAnimalCard.Size = New Size(307, 23)
        cmbAnimalCard.TabIndex = 6
        ' 
        ' lblAnimalInfo
        ' 
        lblAnimalInfo.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAnimalInfo.ForeColor = Color.DimGray
        lblAnimalInfo.Location = New Point(13, 165)
        lblAnimalInfo.Name = "lblAnimalInfo"
        lblAnimalInfo.Size = New Size(175, 15)
        lblAnimalInfo.TabIndex = 16
        lblAnimalInfo.Text = "Strength: - | Health: -"
        ' 
        ' lblAnimalRarity
        ' 
        lblAnimalRarity.Location = New Point(0, 0)
        lblAnimalRarity.Name = "lblAnimalRarity"
        lblAnimalRarity.Size = New Size(100, 23)
        lblAnimalRarity.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 188)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 15)
        Label6.TabIndex = 22
        Label6.Text = "Strong Card"
        ' 
        ' cmbStrongCard
        ' 
        cmbStrongCard.Location = New Point(13, 202)
        cmbStrongCard.Margin = New Padding(3, 2, 3, 2)
        cmbStrongCard.Name = "cmbStrongCard"
        cmbStrongCard.Size = New Size(307, 23)
        cmbStrongCard.TabIndex = 7
        ' 
        ' lblStrongInfo
        ' 
        lblStrongInfo.Location = New Point(0, 0)
        lblStrongInfo.Name = "lblStrongInfo"
        lblStrongInfo.Size = New Size(100, 23)
        lblStrongInfo.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 248)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 15)
        Label7.TabIndex = 23
        Label7.Text = "Miracle Card"
        ' 
        ' cmbMiracleCard
        ' 
        cmbMiracleCard.Location = New Point(13, 262)
        cmbMiracleCard.Margin = New Padding(3, 2, 3, 2)
        cmbMiracleCard.Name = "cmbMiracleCard"
        cmbMiracleCard.Size = New Size(307, 23)
        cmbMiracleCard.TabIndex = 8
        ' 
        ' lblMiracleInfo
        ' 
        lblMiracleInfo.Location = New Point(0, 0)
        lblMiracleInfo.Name = "lblMiracleInfo"
        lblMiracleInfo.Size = New Size(100, 23)
        lblMiracleInfo.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 311)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 15)
        Label8.TabIndex = 24
        Label8.Text = "TOTAL DECK POWER"
        ' 
        ' lblTotalPower
        ' 
        lblTotalPower.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalPower.Location = New Point(262, 308)
        lblTotalPower.Name = "lblTotalPower"
        lblTotalPower.Size = New Size(57, 22)
        lblTotalPower.TabIndex = 17
        lblTotalPower.Text = "0"
        lblTotalPower.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' prgPower
        ' 
        prgPower.Location = New Point(13, 330)
        prgPower.Margin = New Padding(3, 2, 3, 2)
        prgPower.Maximum = 15000
        prgPower.Name = "prgPower"
        prgPower.Size = New Size(306, 11)
        prgPower.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 352)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 15)
        Label9.TabIndex = 25
        Label9.Text = "Status Deck"
        ' 
        ' cmbStatusDeck
        ' 
        cmbStatusDeck.Items.AddRange(New Object() {"Aktif", "Nonaktif"})
        cmbStatusDeck.Location = New Point(13, 368)
        cmbStatusDeck.Margin = New Padding(3, 2, 3, 2)
        cmbStatusDeck.Name = "cmbStatusDeck"
        cmbStatusDeck.Size = New Size(106, 23)
        cmbStatusDeck.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(131, 352)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 15)
        Label10.TabIndex = 26
        Label10.Text = "Catatan Strategi"
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Location = New Point(131, 368)
        txtCatatan.Margin = New Padding(3, 2, 3, 2)
        txtCatatan.Multiline = True
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(189, 46)
        txtCatatan.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.SandyBrown
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(13, 428)
        btnSimpan.Margin = New Padding(3, 2, 3, 2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(70, 30)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Chocolate
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(92, 428)
        btnUbah.Margin = New Padding(3, 2, 3, 2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(70, 30)
        btnUbah.TabIndex = 13
        btnUbah.Text = "UBAH"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(80), CByte(80))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(171, 428)
        btnHapus.Margin = New Padding(3, 2, 3, 2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(70, 30)
        btnHapus.TabIndex = 14
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.PeachPuff
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.Gray
        btnBatal.Location = New Point(249, 428)
        btnBatal.Margin = New Padding(3, 2, 3, 2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(70, 30)
        btnBatal.TabIndex = 15
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormDeckBuilder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 472)
        Controls.Add(lblTotalPower)
        Controls.Add(lblAnimalInfo)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCatatan)
        Controls.Add(cmbStatusDeck)
        Controls.Add(prgPower)
        Controls.Add(cmbMiracleCard)
        Controls.Add(cmbStrongCard)
        Controls.Add(cmbAnimalCard)
        Controls.Add(cmbPemain)
        Controls.Add(txtNamaDeck)
        Controls.Add(txtIdDeck)
        Controls.Add(dgvDeck)
        Controls.Add(txtSearch)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormDeckBuilder"
        Text = "Animal Kaiser - Deck Management"
        CType(dgvDeck, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvDeck As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdDeck As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDeck As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPemain As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAnimalCard As System.Windows.Forms.ComboBox
    Friend WithEvents lblAnimalInfo As System.Windows.Forms.Label
    Friend WithEvents lblAnimalRarity As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbStrongCard As System.Windows.Forms.ComboBox
    Friend WithEvents lblStrongInfo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbMiracleCard As System.Windows.Forms.ComboBox
    Friend WithEvents lblMiracleInfo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPower As System.Windows.Forms.Label
    Friend WithEvents prgPower As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbStatusDeck As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class