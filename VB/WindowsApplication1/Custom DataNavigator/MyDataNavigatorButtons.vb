Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1
	Public Class MyDataNavigatorButtons
		Inherits DataNavigatorButtons
		Public Sub New(ByVal owner As INavigatorOwner)
			MyBase.New(owner)

		End Sub

		Protected Overrides Function CreateViewInfo() As NavigatorButtonsViewInfo
			Return New MyNavigatorButtonsViewInfo(Me)
		End Function



	End Class
End Namespace
