<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiffieHellman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiffieHellman))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Modulus = New System.Windows.Forms.TextBox()
        Me.Generator = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.saveToKeyBtn = New System.Windows.Forms.Button()
        Me.saveToIVBtn = New System.Windows.Forms.Button()
        Me.GAB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Modulus)
        Me.GroupBox1.Controls.Add(Me.Generator)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 67)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Public values (set to the same as friend)"
        '
        'Modulus
        '
        Me.Modulus.Location = New System.Drawing.Point(124, 39)
        Me.Modulus.Name = "Modulus"
        Me.Modulus.Size = New System.Drawing.Size(646, 20)
        Me.Modulus.TabIndex = 9
        '
        'Generator
        '
        Me.Generator.Location = New System.Drawing.Point(124, 13)
        Me.Generator.Name = "Generator"
        Me.Generator.Size = New System.Drawing.Size(646, 20)
        Me.Generator.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Modulus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Generator"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.saveToKeyBtn)
        Me.GroupBox3.Controls.Add(Me.saveToIVBtn)
        Me.GroupBox3.Controls.Add(Me.GAB)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 44)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Private values (DO NOT SHARE)"
        '
        'saveToKeyBtn
        '
        Me.saveToKeyBtn.Location = New System.Drawing.Point(614, 14)
        Me.saveToKeyBtn.Name = "saveToKeyBtn"
        Me.saveToKeyBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveToKeyBtn.TabIndex = 14
        Me.saveToKeyBtn.Text = "Save to Key"
        Me.saveToKeyBtn.UseVisualStyleBackColor = True
        '
        'saveToIVBtn
        '
        Me.saveToIVBtn.Location = New System.Drawing.Point(695, 14)
        Me.saveToIVBtn.Name = "saveToIVBtn"
        Me.saveToIVBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveToIVBtn.TabIndex = 13
        Me.saveToIVBtn.Text = "Save to IV"
        Me.saveToIVBtn.UseVisualStyleBackColor = True
        '
        'GAB
        '
        Me.GAB.Location = New System.Drawing.Point(124, 16)
        Me.GAB.Name = "GAB"
        Me.GAB.Size = New System.Drawing.Size(484, 20)
        Me.GAB.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Final Shared Secret"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GA)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.GB)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 74)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exchangable values(can be shared publically)"
        '
        'GA
        '
        Me.GA.Location = New System.Drawing.Point(124, 42)
        Me.GA.Name = "GA"
        Me.GA.Size = New System.Drawing.Size(646, 20)
        Me.GA.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Your public number"
        '
        'GB
        '
        Me.GB.Location = New System.Drawing.Point(124, 16)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(646, 20)
        Me.GB.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Friend's public number"
        '
        'DiffieHellman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 221)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(816, 260)
        Me.MinimumSize = New System.Drawing.Size(816, 260)
        Me.Name = "DiffieHellman"
        Me.Text = "DiffieHellman"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Modulus As TextBox
    Friend WithEvents Generator As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GAB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents saveToKeyBtn As Button
    Friend WithEvents saveToIVBtn As Button
End Class
