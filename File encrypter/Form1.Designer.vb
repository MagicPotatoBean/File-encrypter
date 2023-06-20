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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.DecryptBtn = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.IV = New System.Windows.Forms.TextBox()
        Me.RandomiseKeyBtn = New System.Windows.Forms.Button()
        Me.RandomiseIVBtn = New System.Windows.Forms.Button()
        Me.EstablishKeysBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(12, 12)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.EncryptBtn.TabIndex = 0
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'DecryptBtn
        '
        Me.DecryptBtn.Location = New System.Drawing.Point(93, 12)
        Me.DecryptBtn.Name = "DecryptBtn"
        Me.DecryptBtn.Size = New System.Drawing.Size(75, 23)
        Me.DecryptBtn.TabIndex = 1
        Me.DecryptBtn.Text = "Decrypt"
        Me.DecryptBtn.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 87)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(12, 110)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(100, 20)
        Me.Key.TabIndex = 5
        '
        'IV
        '
        Me.IV.Location = New System.Drawing.Point(12, 136)
        Me.IV.Name = "IV"
        Me.IV.Size = New System.Drawing.Size(100, 20)
        Me.IV.TabIndex = 6
        '
        'RandomiseKeyBtn
        '
        Me.RandomiseKeyBtn.Location = New System.Drawing.Point(118, 108)
        Me.RandomiseKeyBtn.Name = "RandomiseKeyBtn"
        Me.RandomiseKeyBtn.Size = New System.Drawing.Size(111, 23)
        Me.RandomiseKeyBtn.TabIndex = 7
        Me.RandomiseKeyBtn.Text = "Randomise Key"
        Me.RandomiseKeyBtn.UseVisualStyleBackColor = True
        '
        'RandomiseIVBtn
        '
        Me.RandomiseIVBtn.Location = New System.Drawing.Point(118, 134)
        Me.RandomiseIVBtn.Name = "RandomiseIVBtn"
        Me.RandomiseIVBtn.Size = New System.Drawing.Size(111, 23)
        Me.RandomiseIVBtn.TabIndex = 8
        Me.RandomiseIVBtn.Text = "Randomise IV"
        Me.RandomiseIVBtn.UseVisualStyleBackColor = True
        '
        'EstablishKeysBtn
        '
        Me.EstablishKeysBtn.Location = New System.Drawing.Point(118, 82)
        Me.EstablishKeysBtn.Name = "EstablishKeysBtn"
        Me.EstablishKeysBtn.Size = New System.Drawing.Size(111, 23)
        Me.EstablishKeysBtn.TabIndex = 9
        Me.EstablishKeysBtn.Text = "Establish keys"
        Me.EstablishKeysBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EstablishKeysBtn)
        Me.Controls.Add(Me.RandomiseIVBtn)
        Me.Controls.Add(Me.RandomiseKeyBtn)
        Me.Controls.Add(Me.IV)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.DecryptBtn)
        Me.Controls.Add(Me.EncryptBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents DecryptBtn As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Key As TextBox
    Friend WithEvents IV As TextBox
    Friend WithEvents RandomiseKeyBtn As Button
    Friend WithEvents RandomiseIVBtn As Button
    Friend WithEvents EstablishKeysBtn As Button
End Class
