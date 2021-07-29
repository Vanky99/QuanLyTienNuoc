<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TậpTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMụcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TậpTinToolStripMenuItem
        '
        Me.TậpTinToolStripMenuItem.Image = CType(resources.GetObject("TậpTinToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TậpTinToolStripMenuItem.Name = "TậpTinToolStripMenuItem"
        Me.TậpTinToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.TậpTinToolStripMenuItem.Text = "Trang Chủ"
        '
        'DanhMụcToolStripMenuItem
        '
        Me.DanhMụcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NhânViênToolStripMenuItem, Me.KháchHàngToolStripMenuItem})
        Me.DanhMụcToolStripMenuItem.Image = CType(resources.GetObject("DanhMụcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem"
        Me.DanhMụcToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DanhMụcToolStripMenuItem.Text = "Danh Mục"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Image = CType(resources.GetObject("NhânViênToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Image = CType(resources.GetObject("KháchHàngToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.Image = CType(resources.GetObject("HóaĐơnToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.Image = CType(resources.GetObject("TìmKiếmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm Kiếm"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BáoCáoToolStripMenuItem.Text = "Báo Cáo"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ Giúp"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TậpTinToolStripMenuItem, Me.DanhMụcToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.BáoCáoToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(485, 349)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TậpTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhMụcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
