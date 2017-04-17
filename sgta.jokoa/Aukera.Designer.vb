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
        Me.btnPersonaje = New System.Windows.Forms.Button()
        Me.lblAtk = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.lblMov = New System.Windows.Forms.Label()
        Me.txtHp = New System.Windows.Forms.TextBox()
        Me.txtDef = New System.Windows.Forms.TextBox()
        Me.txtAtk = New System.Windows.Forms.TextBox()
        Me.txtMov = New System.Windows.Forms.TextBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPersonaje2 = New System.Windows.Forms.Button()
        Me.btnPersonaje3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPersonaje
        '
        Me.btnPersonaje.Location = New System.Drawing.Point(13, 12)
        Me.btnPersonaje.Name = "btnPersonaje"
        Me.btnPersonaje.Size = New System.Drawing.Size(75, 136)
        Me.btnPersonaje.TabIndex = 0
        Me.btnPersonaje.Text = "Personaje"
        Me.btnPersonaje.UseVisualStyleBackColor = True
        '
        'lblAtk
        '
        Me.lblAtk.AutoSize = True
        Me.lblAtk.Location = New System.Drawing.Point(150, 194)
        Me.lblAtk.Name = "lblAtk"
        Me.lblAtk.Size = New System.Drawing.Size(26, 13)
        Me.lblAtk.TabIndex = 1
        Me.lblAtk.Text = "Atk:"
        Me.lblAtk.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 154)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(130, 20)
        Me.txtName.TabIndex = 2
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName.Visible = False
        '
        'lblHp
        '
        Me.lblHp.AutoSize = True
        Me.lblHp.Location = New System.Drawing.Point(51, 194)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(24, 13)
        Me.lblHp.TabIndex = 3
        Me.lblHp.Text = "Hp:"
        Me.lblHp.Visible = False
        '
        'lblDef
        '
        Me.lblDef.AutoSize = True
        Me.lblDef.Location = New System.Drawing.Point(51, 227)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(27, 13)
        Me.lblDef.TabIndex = 4
        Me.lblDef.Text = "Def:"
        Me.lblDef.Visible = False
        '
        'lblMov
        '
        Me.lblMov.AutoSize = True
        Me.lblMov.Location = New System.Drawing.Point(145, 227)
        Me.lblMov.Name = "lblMov"
        Me.lblMov.Size = New System.Drawing.Size(31, 13)
        Me.lblMov.TabIndex = 5
        Me.lblMov.Text = "Mov:"
        Me.lblMov.Visible = False
        '
        'txtHp
        '
        Me.txtHp.Location = New System.Drawing.Point(84, 191)
        Me.txtHp.Name = "txtHp"
        Me.txtHp.ReadOnly = True
        Me.txtHp.Size = New System.Drawing.Size(36, 20)
        Me.txtHp.TabIndex = 6
        Me.txtHp.Visible = False
        '
        'txtDef
        '
        Me.txtDef.Location = New System.Drawing.Point(84, 224)
        Me.txtDef.Name = "txtDef"
        Me.txtDef.ReadOnly = True
        Me.txtDef.Size = New System.Drawing.Size(36, 20)
        Me.txtDef.TabIndex = 7
        Me.txtDef.Visible = False
        '
        'txtAtk
        '
        Me.txtAtk.Location = New System.Drawing.Point(182, 191)
        Me.txtAtk.Name = "txtAtk"
        Me.txtAtk.ReadOnly = True
        Me.txtAtk.Size = New System.Drawing.Size(36, 20)
        Me.txtAtk.TabIndex = 8
        Me.txtAtk.Visible = False
        '
        'txtMov
        '
        Me.txtMov.Location = New System.Drawing.Point(182, 224)
        Me.txtMov.Name = "txtMov"
        Me.txtMov.ReadOnly = True
        Me.txtMov.Size = New System.Drawing.Size(36, 20)
        Me.txtMov.TabIndex = 9
        Me.txtMov.Visible = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(104, 263)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 10
        Me.btnPlay.Text = "Jokatu"
        Me.btnPlay.UseVisualStyleBackColor = True
        Me.btnPlay.Visible = False
        '
        'btnPersonaje2
        '
        Me.btnPersonaje2.Location = New System.Drawing.Point(104, 12)
        Me.btnPersonaje2.Name = "btnPersonaje2"
        Me.btnPersonaje2.Size = New System.Drawing.Size(75, 136)
        Me.btnPersonaje2.TabIndex = 11
        Me.btnPersonaje2.Text = "Personaje 2"
        Me.btnPersonaje2.UseVisualStyleBackColor = True
        '
        'btnPersonaje3
        '
        Me.btnPersonaje3.Location = New System.Drawing.Point(197, 12)
        Me.btnPersonaje3.Name = "btnPersonaje3"
        Me.btnPersonaje3.Size = New System.Drawing.Size(75, 136)
        Me.btnPersonaje3.TabIndex = 12
        Me.btnPersonaje3.Text = "Personaje 3"
        Me.btnPersonaje3.UseVisualStyleBackColor = True
        '
        'Aukera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.Controls.Add(Me.btnPersonaje3)
        Me.Controls.Add(Me.btnPersonaje2)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtMov)
        Me.Controls.Add(Me.txtAtk)
        Me.Controls.Add(Me.txtDef)
        Me.Controls.Add(Me.txtHp)
        Me.Controls.Add(Me.lblMov)
        Me.Controls.Add(Me.lblDef)
        Me.Controls.Add(Me.lblHp)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAtk)
        Me.Controls.Add(Me.btnPersonaje)
        Me.Name = "Aukera"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPersonaje As System.Windows.Forms.Button
    Friend WithEvents lblAtk As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblHp As System.Windows.Forms.Label
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents lblMov As System.Windows.Forms.Label
    Friend WithEvents txtHp As System.Windows.Forms.TextBox
    Friend WithEvents txtDef As System.Windows.Forms.TextBox
    Friend WithEvents txtAtk As System.Windows.Forms.TextBox
    Friend WithEvents txtMov As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPersonaje2 As System.Windows.Forms.Button
    Friend WithEvents btnPersonaje3 As System.Windows.Forms.Button
End Class
