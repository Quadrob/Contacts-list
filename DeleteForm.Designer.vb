<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteForm))
        Me.MenuBtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SearchResultListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuBtn
        '
        Me.MenuBtn.BackColor = System.Drawing.Color.Transparent
        Me.MenuBtn.BackgroundImage = CType(resources.GetObject("MenuBtn.BackgroundImage"), System.Drawing.Image)
        Me.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuBtn.Location = New System.Drawing.Point(410, 530)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(170, 50)
        Me.MenuBtn.TabIndex = 5
        Me.MenuBtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 72)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Delete Contact"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteBtn.BackgroundImage = CType(resources.GetObject("DeleteBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.Location = New System.Drawing.Point(335, 430)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(330, 70)
        Me.DeleteBtn.TabIndex = 9
        Me.DeleteBtn.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 50)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Please select the index number of the contact" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you wish to delete and click butto" &
    "n."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 36)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Index Number :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(560, 173)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 41)
        Me.NumericUpDown1.TabIndex = 20
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SearchResultListBox
        '
        Me.SearchResultListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchResultListBox.FormattingEnabled = True
        Me.SearchResultListBox.HorizontalExtent = 600
        Me.SearchResultListBox.HorizontalScrollbar = True
        Me.SearchResultListBox.ItemHeight = 22
        Me.SearchResultListBox.Location = New System.Drawing.Point(85, 290)
        Me.SearchResultListBox.Name = "SearchResultListBox"
        Me.SearchResultListBox.ScrollAlwaysVisible = True
        Me.SearchResultListBox.Size = New System.Drawing.Size(799, 114)
        Me.SearchResultListBox.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "This is the selected contact to delete:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchResultListBox)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuBtn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 650)
        Me.Name = "DeleteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Contact"
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuBtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteBtn As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents SearchResultListBox As ListBox
    Friend WithEvents Label3 As Label
End Class
