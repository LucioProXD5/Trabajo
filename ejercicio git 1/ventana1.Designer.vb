<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventana1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnvent1 = New System.Windows.Forms.Button()
        Me.btnend1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnvent1
        '
        Me.btnvent1.Location = New System.Drawing.Point(62, 12)
        Me.btnvent1.Name = "btnvent1"
        Me.btnvent1.Size = New System.Drawing.Size(131, 23)
        Me.btnvent1.TabIndex = 0
        Me.btnvent1.Text = "Cerrar ventana 1"
        Me.btnvent1.UseVisualStyleBackColor = True
        '
        'btnend1
        '
        Me.btnend1.Location = New System.Drawing.Point(62, 91)
        Me.btnend1.Name = "btnend1"
        Me.btnend1.Size = New System.Drawing.Size(131, 23)
        Me.btnend1.TabIndex = 1
        Me.btnend1.Text = "Cerrar ambas ventanas"
        Me.btnend1.UseVisualStyleBackColor = True
        '
        'ventana1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 136)
        Me.Controls.Add(Me.btnend1)
        Me.Controls.Add(Me.btnvent1)
        Me.Location = New System.Drawing.Point(400, 100)
        Me.Name = "ventana1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnvent1 As Button
    Friend WithEvents btnend1 As Button
End Class
