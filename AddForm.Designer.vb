<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuBtn = New System.Windows.Forms.PictureBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmAddBtn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfirmAddBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 72)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Add To Contacts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(489, 50)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Please fill in the required text box's and then submit the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "information to add t" &
    "he contact."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuBtn
        '
        Me.MenuBtn.BackColor = System.Drawing.Color.Transparent
        Me.MenuBtn.BackgroundImage = CType(resources.GetObject("MenuBtn.BackgroundImage"), System.Drawing.Image)
        Me.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuBtn.Location = New System.Drawing.Point(50, 526)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(170, 50)
        Me.MenuBtn.TabIndex = 10
        Me.MenuBtn.TabStop = False
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(350, 172)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(482, 45)
        Me.FNameTextBox.TabIndex = 11
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(350, 247)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(482, 45)
        Me.LNameTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(350, 322)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(482, 45)
        Me.EmailTextBox.TabIndex = 13
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(350, 397)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(482, 45)
        Me.CountryTextBox.TabIndex = 14
        '
        'ConfirmAddBtn
        '
        Me.ConfirmAddBtn.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmAddBtn.BackgroundImage = CType(resources.GetObject("ConfirmAddBtn.BackgroundImage"), System.Drawing.Image)
        Me.ConfirmAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfirmAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfirmAddBtn.Location = New System.Drawing.Point(440, 506)
        Me.ConfirmAddBtn.Name = "ConfirmAddBtn"
        Me.ConfirmAddBtn.Size = New System.Drawing.Size(330, 70)
        Me.ConfirmAddBtn.TabIndex = 15
        Me.ConfirmAddBtn.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 36)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "First Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 36)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Last Name :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 36)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Email :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 36)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Country :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmAddBtn)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.MenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 650)
        Me.Name = "AddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Contact"
        CType(Me.MenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfirmAddBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuBtn As PictureBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents ConfirmAddBtn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
