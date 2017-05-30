<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aukera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aukera))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAtk = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTaldea = New System.Windows.Forms.Label()
        Me.lblMov = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblAlk = New System.Windows.Forms.Label()
        Me.btnPl1 = New System.Windows.Forms.Button()
        Me.btnPl2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(443, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "HP:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDef
        '
        Me.lblDef.AutoSize = True
        Me.lblDef.BackColor = System.Drawing.Color.Gold
        Me.lblDef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDef.Location = New System.Drawing.Point(73, 322)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(2, 19)
        Me.lblDef.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DEF:"
        '
        'lblAtk
        '
        Me.lblAtk.AutoSize = True
        Me.lblAtk.BackColor = System.Drawing.Color.Gold
        Me.lblAtk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAtk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtk.Location = New System.Drawing.Point(73, 286)
        Me.lblAtk.Name = "lblAtk"
        Me.lblAtk.Size = New System.Drawing.Size(2, 19)
        Me.lblAtk.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gold
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ATK:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(340, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 250)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Gold
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 202)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gold
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "MOV:"
        '
        'lblTaldea
        '
        Me.lblTaldea.AutoSize = True
        Me.lblTaldea.BackColor = System.Drawing.Color.Gold
        Me.lblTaldea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaldea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaldea.Location = New System.Drawing.Point(244, 250)
        Me.lblTaldea.Name = "lblTaldea"
        Me.lblTaldea.Size = New System.Drawing.Size(2, 19)
        Me.lblTaldea.TabIndex = 21
        '
        'lblMov
        '
        Me.lblMov.AutoSize = True
        Me.lblMov.BackColor = System.Drawing.Color.Gold
        Me.lblMov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMov.Location = New System.Drawing.Point(244, 286)
        Me.lblMov.Name = "lblMov"
        Me.lblMov.Size = New System.Drawing.Size(2, 19)
        Me.lblMov.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gold
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(154, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ALK:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gold
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(154, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "TALDEA:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHp
        '
        Me.lblHp.AutoSize = True
        Me.lblHp.BackColor = System.Drawing.Color.Gold
        Me.lblHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHp.Location = New System.Drawing.Point(73, 250)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(2, 19)
        Me.lblHp.TabIndex = 23
        '
        'lblAlk
        '
        Me.lblAlk.AutoSize = True
        Me.lblAlk.BackColor = System.Drawing.Color.Gold
        Me.lblAlk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlk.Location = New System.Drawing.Point(244, 322)
        Me.lblAlk.Name = "lblAlk"
        Me.lblAlk.Size = New System.Drawing.Size(2, 19)
        Me.lblAlk.TabIndex = 24
        '
        'btnPl1
        '
        Me.btnPl1.BackColor = System.Drawing.Color.YellowGreen
        Me.btnPl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPl1.Location = New System.Drawing.Point(13, 378)
        Me.btnPl1.Name = "btnPl1"
        Me.btnPl1.Size = New System.Drawing.Size(97, 71)
        Me.btnPl1.TabIndex = 25
        Me.btnPl1.Text = "1 Jokalaria Gehitu"
        Me.btnPl1.UseVisualStyleBackColor = False
        '
        'btnPl2
        '
        Me.btnPl2.BackColor = System.Drawing.Color.YellowGreen
        Me.btnPl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPl2.Location = New System.Drawing.Point(132, 378)
        Me.btnPl2.Name = "btnPl2"
        Me.btnPl2.Size = New System.Drawing.Size(97, 71)
        Me.btnPl2.TabIndex = 26
        Me.btnPl2.Text = "2 Jokalaria Gehitu"
        Me.btnPl2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 26)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Pertsonaia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gold
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 26)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Zailtasuna"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Gold
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 125)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(217, 24)
        Me.ComboBox2.TabIndex = 29
        '
        'Aukera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 460)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPl2)
        Me.Controls.Add(Me.btnPl1)
        Me.Controls.Add(Me.lblAlk)
        Me.Controls.Add(Me.lblHp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTaldea)
        Me.Controls.Add(Me.lblMov)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAtk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDef)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aukera"
        Me.Text = "Champ Select"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAtk As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTaldea As System.Windows.Forms.Label
    Friend WithEvents lblMov As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblHp As System.Windows.Forms.Label
    Friend WithEvents lblAlk As System.Windows.Forms.Label
    Friend WithEvents btnPl1 As System.Windows.Forms.Button
    Friend WithEvents btnPl2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
