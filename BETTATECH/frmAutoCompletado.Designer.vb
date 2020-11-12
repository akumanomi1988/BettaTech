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
		Me.ListBox2 = New System.Windows.Forms.ListBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
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
		'ListBox2
		'
		Me.ListBox2.FormattingEnabled = True
		Me.ListBox2.Location = New System.Drawing.Point(317, 71)
		Me.ListBox2.Name = "ListBox2"
		Me.ListBox2.Size = New System.Drawing.Size(218, 355)
		Me.ListBox2.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(319, 55)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(131, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Opciones autocompletado"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(318, 8)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(101, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Comienza a escribir:"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(317, 28)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(218, 20)
		Me.TextBox2.TabIndex = 5
		'
		'frmAutoCompletado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(547, 450)
		Me.Controls.Add(Me.ListBox2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "frmAutoCompletado"
		Me.Text = "{ }; Formulario de autocompletado"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents ListBox1 As Windows.Forms.ListBox
	Friend WithEvents ListBox2 As Windows.Forms.ListBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents TextBox2 As Windows.Forms.TextBox
End Class
