Namespace ZUGFeRD_sample
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
			Me.ButtonExportFacturX = New System.Windows.Forms.Button()
			Me.ButtonExportZugferd = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			'
			'ButtonExportFacturX
			'
			Me.ButtonExportFacturX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.ButtonExportFacturX.Location = New System.Drawing.Point(13, 124)
			Me.ButtonExportFacturX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ButtonExportFacturX.Name = "ButtonExportFacturX"
			Me.ButtonExportFacturX.Size = New System.Drawing.Size(418, 100)
			Me.ButtonExportFacturX.TabIndex = 1
			Me.ButtonExportFacturX.Text = "French Specific"
			Me.ButtonExportFacturX.UseVisualStyleBackColor = True
			'
			'ButtonExportZugferd
			'
			Me.ButtonExportZugferd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.ButtonExportZugferd.Location = New System.Drawing.Point(13, 14)
			Me.ButtonExportZugferd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.ButtonExportZugferd.Name = "ButtonExportZugferd"
			Me.ButtonExportZugferd.Size = New System.Drawing.Size(418, 100)
			Me.ButtonExportZugferd.TabIndex = 0
			Me.ButtonExportZugferd.Text = "German Specific"
			Me.ButtonExportZugferd.UseVisualStyleBackColor = True
			'
			'Form1
			'
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(444, 238)
			Me.Controls.Add(Me.ButtonExportFacturX)
			Me.Controls.Add(Me.ButtonExportZugferd)
			Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Name = "Form1"
			Me.Text = "ZUGFeRD Report Example"
			Me.ResumeLayout(False)

		End Sub
		Private WithEvents ButtonExportFacturX As Button
		Private WithEvents ButtonExportZugferd As Button

#End Region
	End Class
End Namespace

