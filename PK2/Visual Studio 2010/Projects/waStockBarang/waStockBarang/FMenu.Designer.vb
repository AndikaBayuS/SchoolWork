<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.UtilityToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountToolStripMenuItem})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.UserAccountToolStripMenuItem.Text = "User Account"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataBarangToolStripMenuItem, Me.LaporanDataPelangganToolStripMenuItem, Me.LaporanDataSupplierToolStripMenuItem, Me.LaporanDataPenjualanToolStripMenuItem, Me.LaporanDataPembelianToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataBarangToolStripMenuItem
        '
        Me.LaporanDataBarangToolStripMenuItem.Name = "LaporanDataBarangToolStripMenuItem"
        Me.LaporanDataBarangToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LaporanDataBarangToolStripMenuItem.Text = "Laporan Data Barang"
        '
        'LaporanDataPelangganToolStripMenuItem
        '
        Me.LaporanDataPelangganToolStripMenuItem.Name = "LaporanDataPelangganToolStripMenuItem"
        Me.LaporanDataPelangganToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LaporanDataPelangganToolStripMenuItem.Text = "Laporan Data Pelanggan"
        '
        'LaporanDataSupplierToolStripMenuItem
        '
        Me.LaporanDataSupplierToolStripMenuItem.Name = "LaporanDataSupplierToolStripMenuItem"
        Me.LaporanDataSupplierToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LaporanDataSupplierToolStripMenuItem.Text = "Laporan Data Supplier"
        '
        'LaporanDataPenjualanToolStripMenuItem
        '
        Me.LaporanDataPenjualanToolStripMenuItem.Name = "LaporanDataPenjualanToolStripMenuItem"
        Me.LaporanDataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LaporanDataPenjualanToolStripMenuItem.Text = "Laporan Data Penjualan"
        '
        'LaporanDataPembelianToolStripMenuItem
        '
        Me.LaporanDataPembelianToolStripMenuItem.Name = "LaporanDataPembelianToolStripMenuItem"
        Me.LaporanDataPembelianToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.LaporanDataPembelianToolStripMenuItem.Text = "Laporan Data Pembelian"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LoginToolStripMenuItem.Text = "Log In"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogoutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 435)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
