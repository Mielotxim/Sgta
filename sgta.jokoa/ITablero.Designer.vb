﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITablero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITablero))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblAkzio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTxanda = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblAtk = New System.Windows.Forms.Label()
        Me.lblMov = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.lblAlk = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.statPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.lblAkzio)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblTxanda)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblFase)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.statPanel)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 612)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(55, 573)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Musika Kendu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblAkzio
        '
        Me.lblAkzio.AutoSize = True
        Me.lblAkzio.Location = New System.Drawing.Point(105, 360)
        Me.lblAkzio.Name = "lblAkzio"
        Me.lblAkzio.Size = New System.Drawing.Size(43, 13)
        Me.lblAkzio.TabIndex = 14
        Me.lblAkzio.Text = "lblAkzio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "AKZIO KOP:"
        '
        'lblTxanda
        '
        Me.lblTxanda.AutoSize = True
        Me.lblTxanda.Location = New System.Drawing.Point(105, 304)
        Me.lblTxanda.Name = "lblTxanda"
        Me.lblTxanda.Size = New System.Drawing.Size(53, 13)
        Me.lblTxanda.TabIndex = 12
        Me.lblTxanda.Text = "lblTxanda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TXANDA: "
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Location = New System.Drawing.Point(105, 331)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(40, 13)
        Me.lblFase.TabIndex = 9
        Me.lblFase.Text = "lblFase"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FASE: "
        '
        'statPanel
        '
        Me.statPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.statPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.statPanel.ColumnCount = 4
        Me.statPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85792!))
        Me.statPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.22951!))
        Me.statPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.49727!))
        Me.statPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3224!))
        Me.statPanel.Controls.Add(Me.lblName, 0, 0)
        Me.statPanel.Controls.Add(Me.Label2, 0, 1)
        Me.statPanel.Controls.Add(Me.Label3, 0, 2)
        Me.statPanel.Controls.Add(Me.Label4, 0, 3)
        Me.statPanel.Controls.Add(Me.lblHp, 1, 1)
        Me.statPanel.Controls.Add(Me.lblAtk, 1, 2)
        Me.statPanel.Controls.Add(Me.lblMov, 1, 3)
        Me.statPanel.Controls.Add(Me.Label8, 2, 1)
        Me.statPanel.Controls.Add(Me.Label9, 2, 2)
        Me.statPanel.Controls.Add(Me.Label10, 2, 3)
        Me.statPanel.Controls.Add(Me.lblTeam, 3, 1)
        Me.statPanel.Controls.Add(Me.lblDef, 3, 2)
        Me.statPanel.Controls.Add(Me.lblAlk, 3, 3)
        Me.statPanel.Location = New System.Drawing.Point(14, 128)
        Me.statPanel.Name = "statPanel"
        Me.statPanel.RowCount = 4
        Me.statPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.statPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.statPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.statPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.statPanel.Size = New System.Drawing.Size(183, 161)
        Me.statPanel.TabIndex = 7
        Me.statPanel.Visible = False
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblName.AutoSize = True
        Me.statPanel.SetColumnSpan(Me.lblName, 4)
        Me.lblName.Location = New System.Drawing.Point(3, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "lblName"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HP: "
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ATK: "
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MOV: "
        '
        'lblHp
        '
        Me.lblHp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHp.AutoSize = True
        Me.lblHp.Location = New System.Drawing.Point(43, 53)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(39, 13)
        Me.lblHp.TabIndex = 4
        Me.lblHp.Text = "Label5"
        '
        'lblAtk
        '
        Me.lblAtk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAtk.AutoSize = True
        Me.lblAtk.Location = New System.Drawing.Point(43, 93)
        Me.lblAtk.Name = "lblAtk"
        Me.lblAtk.Size = New System.Drawing.Size(39, 13)
        Me.lblAtk.TabIndex = 5
        Me.lblAtk.Text = "Label6"
        '
        'lblMov
        '
        Me.lblMov.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMov.AutoSize = True
        Me.lblMov.Location = New System.Drawing.Point(43, 134)
        Me.lblMov.Name = "lblMov"
        Me.lblMov.Size = New System.Drawing.Size(39, 13)
        Me.lblMov.TabIndex = 6
        Me.lblMov.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Team: "
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DEF: "
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "ALK: "
        '
        'lblTeam
        '
        Me.lblTeam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(134, 53)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(45, 13)
        Me.lblTeam.TabIndex = 10
        Me.lblTeam.Text = "Label11"
        '
        'lblDef
        '
        Me.lblDef.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDef.AutoSize = True
        Me.lblDef.Location = New System.Drawing.Point(134, 93)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(45, 13)
        Me.lblDef.TabIndex = 11
        Me.lblDef.Text = "Label12"
        '
        'lblAlk
        '
        Me.lblAlk.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAlk.AutoSize = True
        Me.lblAlk.Location = New System.Drawing.Point(134, 134)
        Me.lblAlk.Name = "lblAlk"
        Me.lblAlk.Size = New System.Drawing.Size(45, 13)
        Me.lblAlk.TabIndex = 12
        Me.lblAlk.Text = "Label13"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(65, 511)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "EZEZTATU"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Txanda Bukatu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Eraso Fasea"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Mugimendu Fasea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 104)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1019, 612)
        Me.Panel2.TabIndex = 1
        '
        'ITablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1239, 608)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ITablero"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.statPanel.ResumeLayout(False)
        Me.statPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents statPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHp As System.Windows.Forms.Label
    Friend WithEvents lblAtk As System.Windows.Forms.Label
    Friend WithEvents lblMov As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents lblDef As System.Windows.Forms.Label
    Friend WithEvents lblAlk As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents lblTxanda As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblAkzio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
