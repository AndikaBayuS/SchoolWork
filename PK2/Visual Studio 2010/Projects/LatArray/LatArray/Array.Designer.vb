<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Array
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.cmbKota = New System.Windows.Forms.ComboBox()
        Me.cmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstTampil = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provinsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kota / Kabupaten"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kecamatan"
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(196, 30)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(121, 21)
        Me.cmbProv.TabIndex = 3
        '
        'cmbKota
        '
        Me.cmbKota.FormattingEnabled = True
        Me.cmbKota.Location = New System.Drawing.Point(196, 70)
        Me.cmbKota.Name = "cmbKota"
        Me.cmbKota.Size = New System.Drawing.Size(121, 21)
        Me.cmbKota.TabIndex = 4
        '
        'cmbKecamatan
        '
        Me.cmbKecamatan.FormattingEnabled = True
        Me.cmbKecamatan.Location = New System.Drawing.Point(196, 113)
        Me.cmbKecamatan.Name = "cmbKecamatan"
        Me.cmbKecamatan.Size = New System.Drawing.Size(121, 21)
        Me.cmbKecamatan.TabIndex = 5
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(29, 186)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 6
        Me.btnTampil.Text = "Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 186)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstTampil
        '
        Me.lstTampil.FormattingEnabled = True
        Me.lstTampil.Location = New System.Drawing.Point(29, 228)
        Me.lstTampil.Name = "lstTampil"
        Me.lstTampil.Size = New System.Drawing.Size(288, 95)
        Me.lstTampil.TabIndex = 9
        '
        'LatArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 350)
        Me.Controls.Add(Me.lstTampil)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTampil)
        Me.Controls.Add(Me.cmbKecamatan)
        Me.Controls.Add(Me.cmbKota)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LatArray"
        Me.Text = "LatArray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProv As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKota As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstTampil As System.Windows.Forms.ListBox
End Class
