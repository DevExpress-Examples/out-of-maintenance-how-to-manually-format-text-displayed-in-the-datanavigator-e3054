Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim datasource As New List(Of Integer)()
			datasource.AddRange(New Integer() { 0, 1, 2, 3, 4 })
			myDataNavigator1.DataSource = datasource
		End Sub
	End Class
End Namespace