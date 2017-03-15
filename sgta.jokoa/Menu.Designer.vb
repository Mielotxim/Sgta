<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Jokatu = New System.Windows.Forms.Button()
        Me.Itxi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Jokatu
        '
        Me.Jokatu.BackColor = System.Drawing.SystemColors.InfoText
        Me.Jokatu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Jokatu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Jokatu.Location = New System.Drawing.Point(12, 12)
        Me.Jokatu.Name = "Jokatu"
        Me.Jokatu.Size = New System.Drawing.Size(115, 32)
        Me.Jokatu.TabIndex = 0
        Me.Jokatu.Text = "Jokatu"
        Me.Jokatu.UseVisualStyleBackColor = False
        '
        'Itxi
        '
        Me.Itxi.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Itxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Itxi.Location = New System.Drawing.Point(157, 12)
        Me.Itxi.Name = "Itxi"
        Me.Itxi.Size = New System.Drawing.Size(115, 32)
        Me.Itxi.TabIndex = 1
        Me.Itxi.Text = "Itxi"
        Me.Itxi.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sgta.jokoa.My.Resources.Resources.header
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Itxi)
        Me.Controls.Add(Me.Jokatu)
        Me.Name = "Menu"
        Me.Text = "JOKOA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Jokatu As System.Windows.Forms.Button
    Friend WithEvents Itxi As System.Windows.Forms.Button

End Class
