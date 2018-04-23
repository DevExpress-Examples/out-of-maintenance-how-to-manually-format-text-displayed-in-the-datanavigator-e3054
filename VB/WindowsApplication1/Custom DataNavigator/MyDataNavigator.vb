Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Public Class MyDataNavigator
		Inherits DataNavigator



		Protected Overrides Function CreateButtons() As NavigatorButtonsBase
			Return New MyDataNavigatorButtons(Me)
		End Function
	End Class
End Namespace
