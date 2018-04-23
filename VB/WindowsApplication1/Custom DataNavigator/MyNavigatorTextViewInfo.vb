Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class MyNavigatorTextViewInfo
		Inherits NavigatorTextViewInfo
		Public Sub New(ByVal viewInfo As NavigatorButtonsViewInfo)
			MyBase.New(viewInfo)

		End Sub

		Protected Overrides Function GetText(ByVal currentRecord As Integer, ByVal count As Integer) As String
			Return String.Format("Total = {0}; Current = {1}", count.ToString("c"), currentRecord - 1)
		End Function
		Public Overrides ReadOnly Property MinSize() As Size
			Get
				Dim size As Size = MyBase.MinSize
				size.Width = 180
				Return size
			End Get
		End Property
	End Class
End Namespace
