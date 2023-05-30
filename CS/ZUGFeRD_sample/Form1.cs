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

        private void button1_Click(object sender, EventArgs e) {
            var report = new XtraReport1();
            report.XmlDataPath = "ZUGFeRD-invoice.xml";

            string additionalMetadata =
                File.ReadAllText("ZUGFeRD_DocumentInfo.txt") +
                File.ReadAllText("ZUGFeRD_PdfASchema.txt");

            PdfExportOptions options = new PdfExportOptions() {
                PdfACompatibility = PdfACompatibility.PdfA3b,
                AdditionalMetadata = additionalMetadata
            };

            options.Attachments.Add(new PdfAttachment() {
                FilePath = "ZUGFeRD-invoice.xml",
                Type = "text/xml",
                Description = "Rechnungsdaten im ZUGFeRD-XML-Format",
            });

            report.ExportToPdf("result.pdf", options);
            Process.Start("result.pdf");
        }
    }
}
