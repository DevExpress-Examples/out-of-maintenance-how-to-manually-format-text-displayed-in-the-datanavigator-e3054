Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myDataNavigator1 = New WindowsApplication1.MyDataNavigator()
			Me.SuspendLayout()
			' 
			' myDataNavigator1
			' 
			Me.myDataNavigator1.Location = New System.Drawing.Point(12, 12)
			Me.myDataNavigator1.Name = "myDataNavigator1"
			Me.myDataNavigator1.Size = New System.Drawing.Size(372, 24)
			Me.myDataNavigator1.TabIndex = 0
			Me.myDataNavigator1.Text = "myDataNavigator1"
			Me.myDataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			Me.myDataNavigator1.TextStringFormat = "The TextStringFormat property is not used"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(528, 325)
			Me.Controls.Add(Me.myDataNavigator1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myDataNavigator1 As MyDataNavigator


	End Class
End Namespace

