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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Numero2 = New System.Windows.Forms.TextBox()
        Me.Numero1 = New System.Windows.Forms.TextBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.LABE = New System.Windows.Forms.HScrollBar()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora de Promedios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número2"
        '
        'Numero2
        '
        Me.Numero2.Location = New System.Drawing.Point(279, 141)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(100, 20)
        Me.Numero2.TabIndex = 3
        '
        'Numero1
        '
        Me.Numero1.Location = New System.Drawing.Point(279, 93)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(100, 20)
        Me.Numero1.TabIndex = 4
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(407, 110)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 5
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(171, 232)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(158, 24)
        Me.Label.TabIndex = 6
        Me.Label.Text = "El promedio es :  "
        '
        'LABE
        '
        Me.LABE.Location = New System.Drawing.Point(0, 0)
        Me.LABE.Name = "LABE"
        Me.LABE.Size = New System.Drawing.Size(80, 17)
        Me.LABE.TabIndex = 7
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(335, 243)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(0, 13)
        Me.Resultado.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.LABE)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.Numero1)
        Me.Controls.Add(Me.Numero2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Numero2 As TextBox
    Friend WithEvents Numero1 As TextBox
    Friend WithEvents calcular As Button
    Friend WithEvents Label As Label
    Friend WithEvents LABE As HScrollBar
    Friend WithEvents Resultado As Label
End Class
