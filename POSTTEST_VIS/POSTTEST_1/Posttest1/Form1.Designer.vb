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
        Label1 = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblIPK = New Label()
        lblPredikat = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        lblSemester = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 20)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Nilai IP Semester"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(72, 61)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(125, 27)
        txtIPSemester.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(165, 117)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(21, 117)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(95, 35)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(68, 20)
        lblIPK.TabIndex = 4
        lblIPK.Text = "IPK : 0,00"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(95, 96)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(80, 20)
        lblPredikat.TabIndex = 5
        lblPredikat.Text = "Predikat : -"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtIPSemester)
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Location = New Point(121, 169)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(274, 166)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ButtonHighlight
        GroupBox2.Controls.Add(lblSemester)
        GroupBox2.Controls.Add(lblIPK)
        GroupBox2.Controls.Add(lblPredikat)
        GroupBox2.Location = New Point(47, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(422, 138)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        ' 
        ' lblSemester
        ' 
        lblSemester.AutoSize = True
        lblSemester.Location = New Point(95, 65)
        lblSemester.Name = "lblSemester"
        lblSemester.Size = New Size(137, 20)
        lblSemester.TabIndex = 6
        lblSemester.Text = "Jumlah Semester : -"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(525, 347)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Menghitung IPK"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIPK As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSemester As Label

End Class
