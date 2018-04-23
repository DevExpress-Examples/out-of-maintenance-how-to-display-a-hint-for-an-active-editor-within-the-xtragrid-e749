Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub


		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.ShownEditor
			Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
			If gridView.ActiveEditor.ToolTipController IsNot Nothing Then
				AddHandler gridView.ActiveEditor.ToolTipController.GetActiveObjectInfo, AddressOf ToolTipController_GetActiveObjectInfo
			End If
		End Sub

		Private Sub ToolTipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			Dim o As Object = gridView1.ActiveEditor.ToString()
			Dim text As String = "Test"
			e.Info = New ToolTipControlInfo(o, text)
		End Sub
	End Class
End Namespace