Imports System.Windows.Forms

Class frmAutoCompletado
	Private _ListaPalabras As List(Of String)
	Private _LetraInicial As New Letra
	Private _letraBusqueda As New Letra
	Private Sub frmAutoCompletado_Load(sender As Object, e As EventArgs) Handles Me.Load
		_ListaPalabras = _LimpiarPalabras_String()
		_LetraInicial.hijos = _LimpiarPalabras_Letra()
	End Sub
#Region "Primera parte - lista de strings"

#Region "Eventos de pantalla"
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		Cursor = Cursors.WaitCursor
		ListBox1.Items.Clear()
		If Not TextBox1.Text.Equals(String.Empty) Then
			ListBox1.Items.AddRange(FiltrarPalabras(TextBox1.Text).ToArray)
		End If
		ListBox1.SelectedItem = -1
		Cursor = Cursors.Default
	End Sub

	Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
		If ListBox1.SelectedIndex <> -1 Then
			TextBox1.Text = ListBox1.SelectedItem
		End If
	End Sub
#End Region
	Private Function _LimpiarPalabras_String() As List(Of String)
		'Limpieza de caracteres molestos (Solo he limpiado los que he ido encontrando)
		Dim pListaPalabras As New List(Of String)
		Dim _CadenaPalabras As String
		_CadenaPalabras = My.Resources.palabras.ToString
		_CadenaPalabras = _CadenaPalabras.Replace(Environment.NewLine, ",")
		_CadenaPalabras = _CadenaPalabras.Replace(" ", ",")
		_CadenaPalabras = _CadenaPalabras.Replace("`", "")
		_CadenaPalabras = _CadenaPalabras.Replace($"\", "")
		pListaPalabras = _CadenaPalabras.Split(",").ToList
		pListaPalabras.Sort()
		Return pListaPalabras
	End Function
	Private Function FiltrarPalabras(texto As String) As List(Of String)
		Return _ListaPalabras.FindAll(Function(x) x.StartsWith(texto, StringComparison.InvariantCultureIgnoreCase))
	End Function
#End Region
#Region "Segunda parte - Arbol"
#Region "Eventos de pantalla"
	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
		Cursor = Cursors.WaitCursor
		ListBox2.Items.Clear()
		If Not TextBox2.Text.Equals(String.Empty) Then
			ListBox2.Items.AddRange(damePalabrasHijas(TextBox2.Text, _BuscaUltimoNodoValido(TextBox2.Text)).ToArray)
		End If
		ListBox2.SelectedItem = -1
		Cursor = Cursors.Default
	End Sub
	Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
		If ListBox2.SelectedIndex <> -1 Then
			TextBox2.Text = ListBox2.SelectedItem
		End If
	End Sub
#End Region
	Private Function _LimpiarPalabras_Letra() As List(Of Letra)
		Dim _CadenaPalabras As String
		_CadenaPalabras = My.Resources.palabras.ToString
		_CadenaPalabras = _CadenaPalabras.Replace(Environment.NewLine, ",")
		_CadenaPalabras = _CadenaPalabras.Replace(" ", ",")
		_CadenaPalabras = _CadenaPalabras.Replace("`", "")
		_CadenaPalabras = _CadenaPalabras.Replace($"\", "")
		Dim pListaPalabrasOrdenar As List(Of String) = _CadenaPalabras.Split(",").ToList
		pListaPalabrasOrdenar.Sort()
		Return _CrearArbolDeNodos(pListaPalabrasOrdenar)
	End Function
	Private Function _CrearArbolDeNodos(listaPalabras As List(Of String)) As List(Of Letra)
		Dim letras As New Letra
		For Each palabra In listaPalabras
			letras = _creacionDeArbolRecursivo(letras, palabra, 0)
		Next
		Return letras.hijos
	End Function
	Private Function _creacionDeArbolRecursivo(letra As Letra, texto As String, indice As Integer) As Letra
		If indice <= texto.Length - 1 Then
			Dim l As Letra
			l = letra.hijos.Find(Function(x) x.id = texto(indice))
			If l Is Nothing Then
				l = New Letra
				l.id = texto(indice)
				letra.hijos.Add(l)
			End If
			indice += 1
			_creacionDeArbolRecursivo(l, texto, indice)
		Else
			letra.finalDePalabra = True
		End If
		Return letra
	End Function
	Private Function _BuscaUltimoNodoValido(ByVal raiz As String) As Letra
		Dim letras As New Letra
		letras = _BuscadorRecursivo(_LetraInicial, raiz, 0)
		Return letras
	End Function
	Private Function _BuscadorRecursivo(letra As Letra, texto As String, indice As Integer) As Letra
		Dim l As Letra
		If indice <= texto.Length - 1 Then
			l = letra.hijos.Find(Function(x) x.id = texto(indice))
			If l Is Nothing Then
				Return Nothing
			End If
			indice += 1
			letra = _BuscadorRecursivo(l, texto, indice)
		End If
		Return letra
	End Function
	Public Function damePalabrasHijas(raiz As String, padre As Letra) As List(Of String)
		Dim listaPalabras As New List(Of String)
		If padre IsNot Nothing Then
			For Each item As Letra In padre.hijos
				If item.finalDePalabra Then
					listaPalabras.Add(raiz & item.id)
				End If
				If item.hijos.Count > 0 Then
					listaPalabras.AddRange(damePalabrasHijas(raiz & item.id, item))
				End If
			Next
		End If
		Return listaPalabras
	End Function
#End Region
End Class
Public Class Letra
	'He hecho las variables públicas para simplificar, lo suyo sería con propiedades privadas y sus getters y setters
	Public id As Char
	Public finalDePalabra As Boolean 'He considerado poner este booleano porque hay palabras que están incluidas en otras palabras más largas y así no se omiten
	Public hijos As New List(Of Letra)
End Class