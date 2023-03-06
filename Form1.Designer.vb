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
        Me.listSpeed = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listSpeed
        '
        Me.listSpeed.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSpeed.ItemHeight = 23
        Me.listSpeed.Location = New System.Drawing.Point(620, 84)
        Me.listSpeed.Name = "listSpeed"
        Me.listSpeed.Size = New System.Drawing.Size(148, 211)
        Me.listSpeed.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InternetSpeed.My.Resources.Resources.speed
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 449)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Internet Speed Test Survey"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSpeed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(397, 84)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(206, 49)
        Me.btnSpeed.TabIndex = 3
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(448, 385)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(274, 20)
        Me.lblAvg.TabIndex = 5
        Me.lblAvg.Text = "Average Internet Speed: 25.44 Mbps"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.listSpeed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents listSpeed As ListBox
    Friend WithEvents lblAvg As Label
End Class
