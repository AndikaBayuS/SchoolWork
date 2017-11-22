<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSupplier
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
        Me.TKdS = New System.Windows.Forms.TextBox()
        Me.TNamaS = New System.Windows.Forms.TextBox()
        Me.TAlamatS = New System.Windows.Forms.TextBox()
        Me.TNotelS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.GridSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No.Telepon"
        '
        'TKdS
        '
        Me.TKdS.Location = New System.Drawing.Point(235, 73)
        Me.TKdS.Name = "TKdS"
        Me.TKdS.Size = New System.Drawing.Size(138, 20)
        Me.TKdS.TabIndex = 5
        '
        'TNamaS
        '
        Me.TNamaS.Location = New System.Drawing.Point(235, 99)
        Me.TNamaS.Name = "TNamaS"
        Me.TNamaS.Size = New System.Drawing.Size(194, 20)
        Me.TNamaS.TabIndex = 6
        '
        'TAlamatS
        '
        Me.TAlamatS.Location = New System.Drawing.Point(235, 125)
        Me.TAlamatS.Name = "TAlamatS"
        Me.TAlamatS.Size = New System.Drawing.Size(173, 20)
        Me.TAlamatS.TabIndex = 7
        '
        'TNotelS
        '
        Me.TNotelS.Location = New System.Drawing.Point(235, 151)
        Me.TNotelS.Name = "TNotelS"
        Me.TNotelS.Size = New System.Drawing.Size(173, 20)
        Me.TNotelS.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnInput)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 57)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(411, 20)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(330, 19)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(249, 19)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(168, 19)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(87, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(6, 19)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 23)
        Me.BtnInput.TabIndex = 0
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'GridSupplier
        '
        Me.GridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSupplier.Location = New System.Drawing.Point(66, 255)
        Me.GridSupplier.Name = "GridSupplier"
        Me.GridSupplier.Size = New System.Drawing.Size(435, 160)
        Me.GridSupplier.TabIndex = 10
        '
        'FSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 437)
        Me.Controls.Add(Me.GridSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TNotelS)
        Me.Controls.Add(Me.TAlamatS)
        Me.Controls.Add(Me.TNamaS)
        Me.Controls.Add(Me.TKdS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FSupplier"
        Me.Text = "FSupplier"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TKdS As System.Windows.Forms.TextBox
    Friend WithEvents TNamaS As System.Windows.Forms.TextBox
    Friend WithEvents TAlamatS As System.Windows.Forms.TextBox
    Friend WithEvents TNotelS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnInput As System.Windows.Forms.Button
    Friend WithEvents GridSupplier As System.Windows.Forms.DataGridView
End Class
