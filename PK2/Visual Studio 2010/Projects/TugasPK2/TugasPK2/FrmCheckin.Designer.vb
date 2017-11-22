<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckin
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
        Me.gbIdentitas = New System.Windows.Forms.GroupBox()
        Me.tTelp = New System.Windows.Forms.TextBox()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.tNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCheckIn = New System.Windows.Forms.GroupBox()
        Me.tBiayaKamar = New System.Windows.Forms.TextBox()
        Me.tTarifKamar = New System.Windows.Forms.TextBox()
        Me.tNamaKamar = New System.Windows.Forms.TextBox()
        Me.tJenisKamar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.dtpMasuk = New System.Windows.Forms.ComboBox()
        Me.tLama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbExtra = New System.Windows.Forms.GroupBox()
        Me.tBiayaExtra = New System.Windows.Forms.TextBox()
        Me.tHargaExtra = New System.Windows.Forms.TextBox()
        Me.tJmlExtra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbTidak = New System.Windows.Forms.RadioButton()
        Me.rbBedFan = New System.Windows.Forms.RadioButton()
        Me.rbFan = New System.Windows.Forms.RadioButton()
        Me.rbBed = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbIdentitas.SuspendLayout()
        Me.gbCheckIn.SuspendLayout()
        Me.gbExtra.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbIdentitas
        '
        Me.gbIdentitas.Controls.Add(Me.tTelp)
        Me.gbIdentitas.Controls.Add(Me.tNama)
        Me.gbIdentitas.Controls.Add(Me.tNo)
        Me.gbIdentitas.Controls.Add(Me.Label3)
        Me.gbIdentitas.Controls.Add(Me.Label2)
        Me.gbIdentitas.Controls.Add(Me.Label1)
        Me.gbIdentitas.Location = New System.Drawing.Point(13, 13)
        Me.gbIdentitas.Name = "gbIdentitas"
        Me.gbIdentitas.Size = New System.Drawing.Size(380, 116)
        Me.gbIdentitas.TabIndex = 0
        Me.gbIdentitas.TabStop = False
        Me.gbIdentitas.Text = "Identitas"
        '
        'tTelp
        '
        Me.tTelp.Location = New System.Drawing.Point(110, 74)
        Me.tTelp.Name = "tTelp"
        Me.tTelp.Size = New System.Drawing.Size(149, 20)
        Me.tTelp.TabIndex = 6
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(110, 48)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(190, 20)
        Me.tNama.TabIndex = 5
        '
        'tNo
        '
        Me.tNo.Location = New System.Drawing.Point(110, 22)
        Me.tNo.Name = "tNo"
        Me.tNo.Size = New System.Drawing.Size(149, 20)
        Me.tNo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No telp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Identitas"
        '
        'gbCheckIn
        '
        Me.gbCheckIn.Controls.Add(Me.tBiayaKamar)
        Me.gbCheckIn.Controls.Add(Me.tTarifKamar)
        Me.gbCheckIn.Controls.Add(Me.tNamaKamar)
        Me.gbCheckIn.Controls.Add(Me.tJenisKamar)
        Me.gbCheckIn.Controls.Add(Me.Label11)
        Me.gbCheckIn.Controls.Add(Me.Label10)
        Me.gbCheckIn.Controls.Add(Me.Label9)
        Me.gbCheckIn.Controls.Add(Me.Label8)
        Me.gbCheckIn.Controls.Add(Me.Button1)
        Me.gbCheckIn.Controls.Add(Me.Label7)
        Me.gbCheckIn.Controls.Add(Me.ComboBox2)
        Me.gbCheckIn.Controls.Add(Me.dtpMasuk)
        Me.gbCheckIn.Controls.Add(Me.tLama)
        Me.gbCheckIn.Controls.Add(Me.Label6)
        Me.gbCheckIn.Controls.Add(Me.Label5)
        Me.gbCheckIn.Controls.Add(Me.Label4)
        Me.gbCheckIn.Location = New System.Drawing.Point(13, 163)
        Me.gbCheckIn.Name = "gbCheckIn"
        Me.gbCheckIn.Size = New System.Drawing.Size(380, 271)
        Me.gbCheckIn.TabIndex = 1
        Me.gbCheckIn.TabStop = False
        Me.gbCheckIn.Text = "Check In"
        '
        'tBiayaKamar
        '
        Me.tBiayaKamar.Location = New System.Drawing.Point(110, 223)
        Me.tBiayaKamar.Name = "tBiayaKamar"
        Me.tBiayaKamar.Size = New System.Drawing.Size(159, 20)
        Me.tBiayaKamar.TabIndex = 17
        '
        'tTarifKamar
        '
        Me.tTarifKamar.Location = New System.Drawing.Point(110, 197)
        Me.tTarifKamar.Name = "tTarifKamar"
        Me.tTarifKamar.Size = New System.Drawing.Size(159, 20)
        Me.tTarifKamar.TabIndex = 16
        '
        'tNamaKamar
        '
        Me.tNamaKamar.Location = New System.Drawing.Point(110, 171)
        Me.tNamaKamar.Name = "tNamaKamar"
        Me.tNamaKamar.Size = New System.Drawing.Size(159, 20)
        Me.tNamaKamar.TabIndex = 15
        '
        'tJenisKamar
        '
        Me.tJenisKamar.Location = New System.Drawing.Point(110, 145)
        Me.tJenisKamar.Name = "tJenisKamar"
        Me.tJenisKamar.Size = New System.Drawing.Size(159, 20)
        Me.tJenisKamar.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Biaya Kamar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tarif Kamar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nama Kamar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Jenis Kamar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Pilih Kamar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Hari"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(110, 79)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'dtpMasuk
        '
        Me.dtpMasuk.FormattingEnabled = True
        Me.dtpMasuk.Location = New System.Drawing.Point(110, 26)
        Me.dtpMasuk.Name = "dtpMasuk"
        Me.dtpMasuk.Size = New System.Drawing.Size(101, 21)
        Me.dtpMasuk.TabIndex = 6
        '
        'tLama
        '
        Me.tLama.Location = New System.Drawing.Point(110, 52)
        Me.tLama.Name = "tLama"
        Me.tLama.Size = New System.Drawing.Size(45, 20)
        Me.tLama.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Lama Menginap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tanggal Masuk"
        '
        'gbExtra
        '
        Me.gbExtra.Controls.Add(Me.tBiayaExtra)
        Me.gbExtra.Controls.Add(Me.tHargaExtra)
        Me.gbExtra.Controls.Add(Me.tJmlExtra)
        Me.gbExtra.Controls.Add(Me.Label14)
        Me.gbExtra.Controls.Add(Me.Label13)
        Me.gbExtra.Controls.Add(Me.Label12)
        Me.gbExtra.Controls.Add(Me.GroupBox4)
        Me.gbExtra.Location = New System.Drawing.Point(451, 13)
        Me.gbExtra.Name = "gbExtra"
        Me.gbExtra.Size = New System.Drawing.Size(348, 169)
        Me.gbExtra.TabIndex = 2
        Me.gbExtra.TabStop = False
        Me.gbExtra.Text = "Extra"
        '
        'tBiayaExtra
        '
        Me.tBiayaExtra.Location = New System.Drawing.Point(82, 126)
        Me.tBiayaExtra.Name = "tBiayaExtra"
        Me.tBiayaExtra.Size = New System.Drawing.Size(158, 20)
        Me.tBiayaExtra.TabIndex = 6
        '
        'tHargaExtra
        '
        Me.tHargaExtra.Location = New System.Drawing.Point(82, 100)
        Me.tHargaExtra.Name = "tHargaExtra"
        Me.tHargaExtra.Size = New System.Drawing.Size(158, 20)
        Me.tHargaExtra.TabIndex = 5
        '
        'tJmlExtra
        '
        Me.tJmlExtra.Location = New System.Drawing.Point(82, 74)
        Me.tJmlExtra.Name = "tJmlExtra"
        Me.tJmlExtra.Size = New System.Drawing.Size(44, 20)
        Me.tJmlExtra.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Biaya Extra"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Harga"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Jumlah"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbTidak)
        Me.GroupBox4.Controls.Add(Me.rbBedFan)
        Me.GroupBox4.Controls.Add(Me.rbFan)
        Me.GroupBox4.Controls.Add(Me.rbBed)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 39)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'rbTidak
        '
        Me.rbTidak.AutoSize = True
        Me.rbTidak.Location = New System.Drawing.Point(198, 16)
        Me.rbTidak.Name = "rbTidak"
        Me.rbTidak.Size = New System.Drawing.Size(52, 17)
        Me.rbTidak.TabIndex = 3
        Me.rbTidak.TabStop = True
        Me.rbTidak.Text = "Tidak"
        Me.rbTidak.UseVisualStyleBackColor = True
        '
        'rbBedFan
        '
        Me.rbBedFan.AutoSize = True
        Me.rbBedFan.Location = New System.Drawing.Point(106, 16)
        Me.rbBedFan.Name = "rbBedFan"
        Me.rbBedFan.Size = New System.Drawing.Size(86, 17)
        Me.rbBedFan.TabIndex = 2
        Me.rbBedFan.TabStop = True
        Me.rbBedFan.Text = "Bed dan Fan"
        Me.rbBedFan.UseVisualStyleBackColor = True
        '
        'rbFan
        '
        Me.rbFan.AutoSize = True
        Me.rbFan.Location = New System.Drawing.Point(57, 16)
        Me.rbFan.Name = "rbFan"
        Me.rbFan.Size = New System.Drawing.Size(43, 17)
        Me.rbFan.TabIndex = 1
        Me.rbFan.TabStop = True
        Me.rbFan.Text = "Fan"
        Me.rbFan.UseVisualStyleBackColor = True
        '
        'rbBed
        '
        Me.rbBed.AutoSize = True
        Me.rbBed.Location = New System.Drawing.Point(7, 16)
        Me.rbBed.Name = "rbBed"
        Me.rbBed.Size = New System.Drawing.Size(44, 17)
        Me.rbBed.TabIndex = 0
        Me.rbBed.TabStop = True
        Me.rbBed.Text = "Bed"
        Me.rbBed.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(581, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "TOTAL BIAYA"
        '
        'tTotal
        '
        Me.tTotal.FormattingEnabled = True
        Me.tTotal.Location = New System.Drawing.Point(451, 215)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(348, 43)
        Me.tTotal.TabIndex = 4
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(451, 268)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(114, 23)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(571, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 269)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FrmCheckin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 491)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbExtra)
        Me.Controls.Add(Me.gbCheckIn)
        Me.Controls.Add(Me.gbIdentitas)
        Me.Name = "FrmCheckin"
        Me.Text = "FrmCheckin"
        Me.gbIdentitas.ResumeLayout(False)
        Me.gbIdentitas.PerformLayout()
        Me.gbCheckIn.ResumeLayout(False)
        Me.gbCheckIn.PerformLayout()
        Me.gbExtra.ResumeLayout(False)
        Me.gbExtra.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbIdentitas As System.Windows.Forms.GroupBox
    Friend WithEvents tTelp As System.Windows.Forms.TextBox
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents tNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbCheckIn As System.Windows.Forms.GroupBox
    Friend WithEvents tBiayaKamar As System.Windows.Forms.TextBox
    Friend WithEvents tTarifKamar As System.Windows.Forms.TextBox
    Friend WithEvents tNamaKamar As System.Windows.Forms.TextBox
    Friend WithEvents tJenisKamar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMasuk As System.Windows.Forms.ComboBox
    Friend WithEvents tLama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbExtra As System.Windows.Forms.GroupBox
    Friend WithEvents tBiayaExtra As System.Windows.Forms.TextBox
    Friend WithEvents tHargaExtra As System.Windows.Forms.TextBox
    Friend WithEvents tJmlExtra As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbBedFan As System.Windows.Forms.RadioButton
    Friend WithEvents rbFan As System.Windows.Forms.RadioButton
    Friend WithEvents rbBed As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.ListBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
