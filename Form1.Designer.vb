<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.PictureBox()
        Me.SearchBtn = New System.Windows.Forms.PictureBox()
        Me.AddConBtn = New System.Windows.Forms.PictureBox()
        Me.EditConBtn = New System.Windows.Forms.PictureBox()
        Me.DeleteConBtn = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddConBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditConBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeleteConBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(45, -5)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(350, 250)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(460, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 97)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contact List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 72)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The easiest and safest way to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "store your contacts."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.BackgroundImage = CType(resources.GetObject("ExitBtn.BackgroundImage"), System.Drawing.Image)
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.Location = New System.Drawing.Point(410, 528)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(170, 50)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.TabStop = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.BackgroundImage = CType(resources.GetObject("SearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBtn.Location = New System.Drawing.Point(75, 290)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(360, 70)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.TabStop = False
        '
        'AddConBtn
        '
        Me.AddConBtn.BackColor = System.Drawing.Color.Transparent
        Me.AddConBtn.BackgroundImage = CType(resources.GetObject("AddConBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddConBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddConBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddConBtn.Location = New System.Drawing.Point(550, 290)
        Me.AddConBtn.Name = "AddConBtn"
        Me.AddConBtn.Size = New System.Drawing.Size(360, 70)
        Me.AddConBtn.TabIndex = 5
        Me.AddConBtn.TabStop = False
        '
        'EditConBtn
        '
        Me.EditConBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditConBtn.BackgroundImage = CType(resources.GetObject("EditConBtn.BackgroundImage"), System.Drawing.Image)
        Me.EditConBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditConBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditConBtn.Location = New System.Drawing.Point(75, 400)
        Me.EditConBtn.Name = "EditConBtn"
        Me.EditConBtn.Size = New System.Drawing.Size(360, 70)
        Me.EditConBtn.TabIndex = 6
        Me.EditConBtn.TabStop = False
        '
        'DeleteConBtn
        '
        Me.DeleteConBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeleteConBtn.BackgroundImage = CType(resources.GetObject("DeleteConBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteConBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteConBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteConBtn.Location = New System.Drawing.Point(550, 400)
        Me.DeleteConBtn.Name = "DeleteConBtn"
        Me.DeleteConBtn.Size = New System.Drawing.Size(360, 70)
        Me.DeleteConBtn.TabIndex = 7
        Me.DeleteConBtn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.DeleteConBtn)
        Me.Controls.Add(Me.EditConBtn)
        Me.Controls.Add(Me.AddConBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddConBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditConBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeleteConBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitBtn As PictureBox
    Friend WithEvents SearchBtn As PictureBox
    Friend WithEvents AddConBtn As PictureBox
    Friend WithEvents EditConBtn As PictureBox
    Friend WithEvents DeleteConBtn As PictureBox
End Class
