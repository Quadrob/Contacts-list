<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.SearchResultListBox = New System.Windows.Forms.ListBox()
        Me.MenuBtn = New System.Windows.Forms.PictureBox()
        Me.ConfirmSearchBtn = New System.Windows.Forms.PictureBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmSearchBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchResultListBox
        '
        Me.SearchResultListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchResultListBox.FormattingEnabled = True
        Me.SearchResultListBox.HorizontalExtent = 600
        Me.SearchResultListBox.HorizontalScrollbar = True
        Me.SearchResultListBox.ItemHeight = 22
        Me.SearchResultListBox.Location = New System.Drawing.Point(439, 24)
        Me.SearchResultListBox.Name = "SearchResultListBox"
        Me.SearchResultListBox.ScrollAlwaysVisible = True
        Me.SearchResultListBox.Size = New System.Drawing.Size(520, 532)
        Me.SearchResultListBox.TabIndex = 0
        '
        'MenuBtn
        '
        Me.MenuBtn.BackColor = System.Drawing.Color.Transparent
        Me.MenuBtn.BackgroundImage = CType(resources.GetObject("MenuBtn.BackgroundImage"), System.Drawing.Image)
        Me.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuBtn.Location = New System.Drawing.Point(140, 522)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(170, 50)
        Me.MenuBtn.TabIndex = 4
        Me.MenuBtn.TabStop = False
        '
        'ConfirmSearchBtn
        '
        Me.ConfirmSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmSearchBtn.BackgroundImage = CType(resources.GetObject("ConfirmSearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.ConfirmSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfirmSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmSearchBtn.Location = New System.Drawing.Point(60, 320)
        Me.ConfirmSearchBtn.Name = "ConfirmSearchBtn"
        Me.ConfirmSearchBtn.Size = New System.Drawing.Size(330, 70)
        Me.ConfirmSearchBtn.TabIndex = 5
        Me.ConfirmSearchBtn.TabStop = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(50, 255)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(350, 45)
        Me.SearchTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 72)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search Contacts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 87)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Please enter the index number or a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keyword below to search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your contacts."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ConfirmSearchBtn)
        Me.Controls.Add(Me.MenuBtn)
        Me.Controls.Add(Me.SearchResultListBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Contacts"
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmSearchBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchResultListBox As ListBox
    Friend WithEvents MenuBtn As PictureBox
    Friend WithEvents ConfirmSearchBtn As PictureBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
