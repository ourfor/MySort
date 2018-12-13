<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.技术支持ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.博客ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.敬请期待ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.联系我们ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WechatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Qq2320813747ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "RUN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 81)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(387, 208)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "排序的一些算法"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始ToolStripMenuItem, Me.文件ToolStripMenuItem, Me.帮助ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '开始ToolStripMenuItem
        '
        Me.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem"
        Me.开始ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.开始ToolStripMenuItem.Text = "开始"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.技术支持ToolStripMenuItem, Me.敬请期待ToolStripMenuItem, Me.联系我们ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '技术支持ToolStripMenuItem
        '
        Me.技术支持ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.博客ToolStripMenuItem})
        Me.技术支持ToolStripMenuItem.Name = "技术支持ToolStripMenuItem"
        Me.技术支持ToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.技术支持ToolStripMenuItem.Text = "技术支持"
        '
        '博客ToolStripMenuItem
        '
        Me.博客ToolStripMenuItem.Name = "博客ToolStripMenuItem"
        Me.博客ToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.博客ToolStripMenuItem.Text = "博客"
        '
        '敬请期待ToolStripMenuItem
        '
        Me.敬请期待ToolStripMenuItem.Name = "敬请期待ToolStripMenuItem"
        Me.敬请期待ToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.敬请期待ToolStripMenuItem.Text = "敬请期待"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '联系我们ToolStripMenuItem
        '
        Me.联系我们ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QQToolStripMenuItem, Me.WechatToolStripMenuItem})
        Me.联系我们ToolStripMenuItem.Name = "联系我们ToolStripMenuItem"
        Me.联系我们ToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.联系我们ToolStripMenuItem.Text = "联系我们"
        '
        'QQToolStripMenuItem
        '
        Me.QQToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.QQToolStripMenuItem.Name = "QQToolStripMenuItem"
        Me.QQToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.QQToolStripMenuItem.Text = "QQ"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(215, 26)
        Me.ToolStripMenuItem2.Text = "2320813747"
        '
        'WechatToolStripMenuItem
        '
        Me.WechatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Qq2320813747ToolStripMenuItem})
        Me.WechatToolStripMenuItem.Name = "WechatToolStripMenuItem"
        Me.WechatToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.WechatToolStripMenuItem.Text = "Wechat"
        '
        'Qq2320813747ToolStripMenuItem
        '
        Me.Qq2320813747ToolStripMenuItem.Name = "Qq2320813747ToolStripMenuItem"
        Me.Qq2320813747ToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.Qq2320813747ToolStripMenuItem.Text = "qq2320813747"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 技术支持ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 博客ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 敬请期待ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 联系我们ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents WechatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Qq2320813747ToolStripMenuItem As ToolStripMenuItem
End Class
