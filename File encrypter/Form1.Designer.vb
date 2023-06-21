<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.DecryptBtn = New System.Windows.Forms.Button()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.IV = New System.Windows.Forms.TextBox()
        Me.RandomiseKeyBtn = New System.Windows.Forms.Button()
        Me.RandomiseIVBtn = New System.Windows.Forms.Button()
        Me.EstablishKeysBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(363, 64)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.EncryptBtn.TabIndex = 0
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'DecryptBtn
        '
        Me.DecryptBtn.Location = New System.Drawing.Point(444, 64)
        Me.DecryptBtn.Name = "DecryptBtn"
        Me.DecryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.DecryptBtn.TabIndex = 1
        Me.DecryptBtn.Text = "Decrypt"
        Me.DecryptBtn.UseVisualStyleBackColor = True
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(43, 12)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(476, 20)
        Me.Key.TabIndex = 5
        '
        'IV
        '
        Me.IV.Location = New System.Drawing.Point(43, 38)
        Me.IV.Name = "IV"
        Me.IV.Size = New System.Drawing.Size(476, 20)
        Me.IV.TabIndex = 6
        '
        'RandomiseKeyBtn
        '
        Me.RandomiseKeyBtn.Location = New System.Drawing.Point(129, 64)
        Me.RandomiseKeyBtn.Name = "RandomiseKeyBtn"
        Me.RandomiseKeyBtn.Size = New System.Drawing.Size(111, 23)
        Me.RandomiseKeyBtn.TabIndex = 7
        Me.RandomiseKeyBtn.Text = "Randomise Key"
        Me.RandomiseKeyBtn.UseVisualStyleBackColor = True
        '
        'RandomiseIVBtn
        '
        Me.RandomiseIVBtn.Location = New System.Drawing.Point(246, 64)
        Me.RandomiseIVBtn.Name = "RandomiseIVBtn"
        Me.RandomiseIVBtn.Size = New System.Drawing.Size(111, 23)
        Me.RandomiseIVBtn.TabIndex = 8
        Me.RandomiseIVBtn.Text = "Randomise IV"
        Me.RandomiseIVBtn.UseVisualStyleBackColor = True
        '
        'EstablishKeysBtn
        '
        Me.EstablishKeysBtn.Location = New System.Drawing.Point(12, 64)
        Me.EstablishKeysBtn.Name = "EstablishKeysBtn"
        Me.EstablishKeysBtn.Size = New System.Drawing.Size(111, 23)
        Me.EstablishKeysBtn.TabIndex = 9
        Me.EstablishKeysBtn.Text = "Establish keys"
        Me.EstablishKeysBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "IV"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 100)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EstablishKeysBtn)
        Me.Controls.Add(Me.RandomiseIVBtn)
        Me.Controls.Add(Me.RandomiseKeyBtn)
        Me.Controls.Add(Me.IV)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.DecryptBtn)
        Me.Controls.Add(Me.EncryptBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(548, 139)
        Me.MinimumSize = New System.Drawing.Size(548, 139)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents DecryptBtn As Button
    Friend WithEvents Key As TextBox
    Friend WithEvents IV As TextBox
    Friend WithEvents RandomiseKeyBtn As Button
    Friend WithEvents RandomiseIVBtn As Button
    Friend WithEvents EstablishKeysBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
