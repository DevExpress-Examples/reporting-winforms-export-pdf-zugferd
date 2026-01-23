Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting

Namespace ZUGFeRD_sample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		' Refer to chapter 7.7 of the FACTUR-X 1.08 specification
		Private Sub buttonExportZugferd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonExportZugferd.Click
			Using report As New XtraReport1()
				report.XmlDataPath = "German//xrechnung.xml"

				Dim additionalMetadata As String = File.ReadAllText("German//ZUGFeRD_DocumentInfo.txt") & File.ReadAllText("German//ZUGFeRD_PdfASchema.txt")

				Dim options As New PdfExportOptions() With {
					.PdfACompatibility = PdfACompatibility.PdfA3b,
					.AdditionalMetadata = additionalMetadata
				}

				options.Attachments.Add(New PdfAttachment() With {
					.FilePath = "German//xrechnung.xml",
					.Type = "text/xml",
					.Relationship = PdfAttachmentRelationship.Alternative,
					.Description = "Rechnungsdaten im ZUGFeRD-XML-Format"
				})

				report.ExportToPdf("germanResult.pdf", options)
			End Using
			Process.Start("germanResult.pdf")
		End Sub

		' Refer to chapter 6.2 of the FACTUR-X 1.08 specification
		Private Sub buttonExportFacturX_Click(sender As Object, e As EventArgs) Handles ButtonExportFacturX.Click
			Using report As New XtraReport1()
				report.XmlDataPath = "French//factur-x.xml"

				Dim additionalMetadata As String = File.ReadAllText("French//ZUGFeRD_DocumentInfo.txt") & File.ReadAllText("French//ZUGFeRD_PdfASchema.txt")

				Dim options As New PdfExportOptions() With {
					.PdfACompatibility = PdfACompatibility.PdfA3b,
					.AdditionalMetadata = additionalMetadata
				}

				options.Attachments.Add(New PdfAttachment() With {
					.FilePath = "French//factur-x.xml",
					.Type = "text/xml",
					.Relationship = PdfAttachmentRelationship.Data,
					.Description = "Rechnungsdaten im ZUGFeRD-XML-Format"
				})

				report.ExportToPdf("frenchResult.pdf", options)
			End Using
			Process.Start("frenchResult.pdf")
		End Sub
	End Class
End Namespace
