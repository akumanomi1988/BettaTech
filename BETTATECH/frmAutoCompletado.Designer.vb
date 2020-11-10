<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoCompletado
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(12, 28)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(218, 20)
		Me.TextBox1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(13, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(101, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Comienza a escribir:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(14, 55)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(131, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Opciones autocompletado"
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(12, 71)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(218, 355)
		Me.ListBox1.TabIndex = 4
		'
		'frmAutoCompletado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(242, 450)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "frmAutoCompletado"
		Me.Text = "frmAutoCompletado"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents ListBox1 As Windows.Forms.ListBox
End Class
