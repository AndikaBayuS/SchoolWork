<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBarang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkdbarang = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtmerk = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.txtjml = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GridBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Merk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga"
        '
        'txtkdbarang
        '
        Me.txtkdbarang.Location = New System.Drawing.Point(178, 52)
        Me.txtkdbarang.Name = "txtkdbarang"
        Me.txtkdbarang.Size = New System.Drawing.Size(130, 20)
        Me.txtkdbarang.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(178, 78)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(233, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtmerk
        '
        Me.txtmerk.Location = New System.Drawing.Point(178, 104)
        Me.txtmerk.Name = "txtmerk"
        Me.txtmerk.Size = New System.Drawing.Size(159, 20)
        Me.txtmerk.TabIndex = 9
        '
        'txtsatuan
        '
        Me.txtsatuan.Location = New System.Drawing.Point(178, 130)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(130, 20)
        Me.txtsatuan.TabIndex = 10
        '
        'txtjml
        '
        Me.txtjml.Location = New System.Drawing.Point(178, 156)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(130, 20)
        Me.txtjml.TabIndex = 11
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(178, 182)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(130, 20)
        Me.txtharga.TabIndex = 12
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(6, 19)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 23)
        Me.BtnInput.TabIndex = 13
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(87, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(168, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 15
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(249, 19)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 16
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(330, 19)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 17
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(411, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GridBarang
        '
        Me.GridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBarang.Location = New System.Drawing.Point(18, 292)
        Me.GridBarang.Name = "GridBarang"
        Me.GridBarang.Size = New System.Drawing.Size(480, 169)
        Me.GridBarang.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnInput)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 53)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'FBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridBarang)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtjml)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtmerk)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkdbarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FBarang"
        Me.Text = "FBarang"
        CType(Me.GridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtkdbarang As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtmerk As System.Windows.Forms.TextBox
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtjml As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents BtnInput As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GridBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
