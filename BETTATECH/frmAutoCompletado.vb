
Imports System.IO
Imports System.Windows.Forms

Class frmAutoCompletado
	Private _ListaPalabras As List(Of String)
	Private Sub frmAutoCompletado_Load(sender As Object, e As EventArgs) Handles Me.Load
		_LimpiarPalabras_PasarALista()
	End Sub
	Private Sub _LimpiarPalabras_PasarALista()
		'Limpieza de caracteres molestos (Solo he limpiado los que he ido encontrando)
		Dim _CadenaPalabras As String
		_CadenaPalabras = My.Resources.palabras.ToString
		_CadenaPalabras = _CadenaPalabras.Replace(Environment.NewLine, ",")
		_CadenaPalabras = _CadenaPalabras.Replace(" ", ",")
		_CadenaPalabras = _CadenaPalabras.Replace("`", "")
		_CadenaPalabras = _CadenaPalabras.Replace($"\", "")
		_ListaPalabras = _CadenaPalabras.Split(",").ToList
		_ListaPalabras.Sort()
	End Sub
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Cursor = Cursors.WaitCursor
		ListBox1.Items.Clear()
		ListBox1.Items.AddRange(FiltrarPalabras(TextBox1.Text).ToArray)
		ListBox1.SelectedItem = -1
		Cursor = Cursors.Default
	End Sub
	Private Function FiltrarPalabras(texto As String) As List(Of String)
		Return _ListaPalabras.FindAll(Function(x) x.StartsWith(texto))
	End Function
	Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
		If ListBox1.SelectedIndex <> -1 Then
			TextBox1.Text = ListBox1.SelectedItem
		End If
	End Sub
End Class