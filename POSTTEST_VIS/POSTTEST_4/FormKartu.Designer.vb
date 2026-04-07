<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pbFotoHasil = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.BackColor = Color.White
        pbFotoHasil.Location = New Point(116, 157)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(141, 142)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(1, 310)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(371, 30)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        lblNama.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(145, 393)
        lblID.Name = "lblID"
        lblID.Size = New Size(52, 20)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.Font = New Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKomunitas.Location = New Point(1, 340)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(371, 37)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Divisi"
        lblKomunitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontak.Location = New Point(145, 454)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(52, 20)
        lblKontak.TabIndex = 4
        lblKontak.Text = "Label4"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.Transparent
        lblHobby.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(145, 423)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(52, 20)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Label5"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(73, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 6
        Label1.Text = "ID No   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(73, 423)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 7
        Label2.Text = "Hobby  :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(73, 454)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 8
        Label3.Text = "Kontak : "
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.ForestGreen
        BackgroundImage = My.Resources.Resources.Green_and_White_Modern_Professional_Company_ID_Card
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(373, 641)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoHasil)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Kartu"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
