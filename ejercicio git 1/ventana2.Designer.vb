<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana2
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
        Me.btnend2 = New System.Windows.Forms.Button()
        Me.btnvent2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnend2
        '
        Me.btnend2.Location = New System.Drawing.Point(58, 91)
        Me.btnend2.Name = "btnend2"
        Me.btnend2.Size = New System.Drawing.Size(131, 23)
        Me.btnend2.TabIndex = 3
        Me.btnend2.Text = "Cerrar ambas ventanas"
        Me.btnend2.UseVisualStyleBackColor = True
        '
        'btnvent2
        '
        Me.btnvent2.Location = New System.Drawing.Point(58, 12)
        Me.btnvent2.Name = "btnvent2"
        Me.btnvent2.Size = New System.Drawing.Size(131, 23)
        Me.btnvent2.TabIndex = 2
        Me.btnvent2.Text = "Cerrar ventana 2"
        Me.btnvent2.UseVisualStyleBackColor = True
        '
        'ventana2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 136)
        Me.Controls.Add(Me.btnend2)
        Me.Controls.Add(Me.btnvent2)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "ventana2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ventana2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnend2 As Button
    Friend WithEvents btnvent2 As Button
End Class
