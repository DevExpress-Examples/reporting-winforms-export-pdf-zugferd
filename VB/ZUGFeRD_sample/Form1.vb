Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace ZUGFeRD_sample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim report = New XtraReport1()
            report.XmlDataPath = "ZUGFeRD-invoice.xml"

            Dim additionalMetadata As String = File.ReadAllText("ZUGFeRD_DocumentInfo.txt") & _
                File.ReadAllText("ZUGFeRD_PdfASchema.txt")

            Dim options As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA3b, _
                                                        .AdditionalMetadata = additionalMetadata}

            options.Attachments.Add(New PdfAttachment() With {.FilePath = "ZUGFeRD-invoice.xml", _
                                                              .Type = "text/xml", _
                                                              .Description = "Rechnungsdaten im ZUGFeRD-XML-Format"})

            report.ExportToPdf("result.pdf", options)
            Process.Start("result.pdf")
        End Sub
    End Class
End Namespace
