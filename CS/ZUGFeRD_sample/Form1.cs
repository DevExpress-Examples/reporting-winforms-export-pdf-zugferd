using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace ZUGFeRD_sample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Refer to chapter 6.2 of the FACTUR-X 1.08 specification
        private void ButtonExportGermany_Click(object sender, EventArgs e) {
            using (var report = new XtraReport1())
            {
                report.XmlDataPath = "German//xrechnung.xml";

                string additionalMetadata =
                    File.ReadAllText("German//ZUGFeRD_DocumentInfo.txt") +
                    File.ReadAllText("German//ZUGFeRD_PdfASchema.txt");

                PdfExportOptions options = new PdfExportOptions()
                {
                    PdfACompatibility = PdfACompatibility.PdfA3b,
                    AdditionalMetadata = additionalMetadata
                };

                // Refer to chapter 7.7 of the ZUGFeRD specification.
                options.Attachments.Add(new PdfAttachment()
                {
                    FilePath = "German//xrechnung.xml",
                    Type = "text/xml",
                    Relationship = PdfAttachmentRelationship.Alternative,
                    Description = "Rechnungsdaten im ZUGFeRD-XML-Format",
                });

                report.ExportToPdf("germanResult.pdf", options);
                Process.Start("germanResult.pdf");
            }
        }

        private void ButtonExportFrance_Click(object sender, EventArgs e) {
            using (var report = new XtraReport1())
            {
                report.XmlDataPath = "French//factur-x.xml";
                string additionalMetadata =
                    File.ReadAllText("French//ZUGFeRD_DocumentInfo.txt") +
                    File.ReadAllText("French//ZUGFeRD_PdfASchema.txt");

                PdfExportOptions options = new PdfExportOptions()
                {
                    PdfACompatibility = PdfACompatibility.PdfA3b,
                    AdditionalMetadata = additionalMetadata
                };

                // Refer to chapter 7.7 of the FACTUR-X 1.08 specification
                options.Attachments.Add(new PdfAttachment()
                {
                    FilePath = "French//factur-x.xml",
                    Type = "text/xml",
                    Relationship = PdfAttachmentRelationship.Data,
                    Description = "Facture XML conforme Factur-X",
                });

                report.ExportToPdf("frenchResult.pdf", options);
                Process.Start("frenchResult.pdf");
            }
        }
    }
}
