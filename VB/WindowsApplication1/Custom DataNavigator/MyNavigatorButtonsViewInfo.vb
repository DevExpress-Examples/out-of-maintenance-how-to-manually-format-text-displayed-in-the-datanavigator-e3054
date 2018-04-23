Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class MyNavigatorButtonsViewInfo
		Inherits NavigatorButtonsViewInfo
		Public Sub New(ByVal buttons As NavigatorButtonsBase)
			MyBase.New(buttons)

		End Sub

		Protected Overrides Function CreateTextViewInfo() As NavigatorTextViewInfo
			Return New MyNavigatorTextViewInfo(Me)
		End Function

	End Class
End Namespace
