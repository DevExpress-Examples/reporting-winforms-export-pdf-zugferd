Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting

' ...
Namespace ZUGFeRD_sample

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim report = New ZUGFeRD_sample.XtraReport1()
            report.XmlDataPath = "ZUGFeRD-invoice.xml"
            Dim additionalMetadata As String = System.IO.File.ReadAllText("ZUGFeRD_DocumentInfo.txt") & System.IO.File.ReadAllText("ZUGFeRD_PdfASchema.txt")
            Dim options As DevExpress.XtraPrinting.PdfExportOptions = New DevExpress.XtraPrinting.PdfExportOptions() With {.PdfACompatible = True, .AdditionalMetadata = additionalMetadata}
            options.Attachments.Add(New DevExpress.XtraPrinting.PdfAttachment() With {.FilePath = "ZUGFeRD-invoice.xml", .Type = "text/xml"})
            report.ExportToPdf("result.pdf", options)
            Call System.Diagnostics.Process.Start("result.pdf")
        End Sub
    End Class
End Namespace
