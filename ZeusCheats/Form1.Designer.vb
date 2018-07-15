<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbDracmas = New System.Windows.Forms.TextBox()
        Me.btnHack = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblDracmas = New System.Windows.Forms.Label()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ZeusHack.My.Resources.Resources.dracma
        Me.PictureBox2.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'tbDracmas
        '
        Me.tbDracmas.Location = New System.Drawing.Point(69, 25)
        Me.tbDracmas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbDracmas.Name = "tbDracmas"
        Me.tbDracmas.Size = New System.Drawing.Size(266, 26)
        Me.tbDracmas.TabIndex = 3
        '
        'btnHack
        '
        Me.btnHack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHack.Location = New System.Drawing.Point(166, 92)
        Me.btnHack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHack.Name = "btnHack"
        Me.btnHack.Size = New System.Drawing.Size(166, 69)
        Me.btnHack.TabIndex = 4
        Me.btnHack.Text = "Hack"
        Me.btnHack.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(18, 123)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(128, 38)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblDracmas
        '
        Me.lblDracmas.AutoSize = True
        Me.lblDracmas.BackColor = System.Drawing.Color.Transparent
        Me.lblDracmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDracmas.ForeColor = System.Drawing.Color.White
        Me.lblDracmas.Location = New System.Drawing.Point(63, 54)
        Me.lblDracmas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDracmas.Name = "lblDracmas"
        Me.lblDracmas.Size = New System.Drawing.Size(282, 20)
        Me.lblDracmas.TabIndex = 6
        Me.lblDracmas.Text = "Insert here number of Drachmas"
        '
        'lblProceso
        '
        Me.lblProceso.AutoSize = True
        Me.lblProceso.BackColor = System.Drawing.Color.Transparent
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.ForeColor = System.Drawing.Color.LightGreen
        Me.lblProceso.Location = New System.Drawing.Point(110, 92)
        Me.lblProceso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(0, 20)
        Me.lblProceso.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Process"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.ZeusHack.My.Resources.Resources.Zeus_Defeat
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(351, 180)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.lblDracmas)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHack)
        Me.Controls.Add(Me.tbDracmas)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zeus-Hack by Hackpuntes.com"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tbDracmas As System.Windows.Forms.TextBox
    Friend WithEvents btnHack As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblDracmas As System.Windows.Forms.Label
    Friend WithEvents lblProceso As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
