<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597453/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T234531)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reports for WinForms - Export a Report to ZUGFeRD (XRechnung and Factur-X)

This example exports a DevExpress report to a PDF/A-3b (ISO 19005-3) document and embeds an electronic invoice (e-invoice) XML file. The resulting PDF complies with ZUGFeRD requirements and can be validated as one of the following formats:

- German e-invoice: XRechnung (ZUGFeRD container)
- French e-invoice: Factur-X (ZUGFeRD container)

## Implementation Details 

The project includes standards-compliant sample XML files and XMP metadata for German (XRechnung) and French (Factur-X) e-invoice formats. Although both formats rely on the ZUGFeRD container, each country requires specific configuration settings (such as the PDF attachment relationship, the embedded XML file name, and required XMP metadata fields).

See the following specification for additional information about ZUGFeRD standarts: [What is ZUGFeRD / Factur-X?](https://www.ferd-net.de/en/standards/zugferd/factur-x)

### Export to ZUGFeRD (Germany)

When you click the "German Specific" button, the application does the following:

-	Loads two metadata fragments and concatenates them into `AdditionalMetadata`.
-	Sets **PDF/A-3b** compliance.
-	Attaches the `xrechnung.xml` file with the `Alternative` relationship.
-	Exports the report to PDF and opens the resulting PDF.

```cs
using System;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraPrinting;

void ButtonExportGermany_Click(object sender, EventArgs e) {
    // Create a report instance for PDF export.
    using (var report = new XtraReport1())
    {
        report.XmlDataPath = "German//xrechnung.xml";

        // Load ZUGFeRD XMP metadata fragments and concatenate them
        // into a single AdditionalMetadata block.
        string additionalMetadata =
            File.ReadAllText("German//ZUGFeRD_DocumentInfo.txt") +
            File.ReadAllText("German//ZUGFeRD_PdfASchema.txt");

        // Configure PDF export options:
        // - Enable PDF/A-3b compliance
        // - Inject ZUGFeRD-required XMP metadata
        var options = new PdfExportOptions {
            PdfACompatibility = PdfACompatibility.PdfA3b,
            AdditionalMetadata = additionalMetadata
        };

        // Attach 'xrechnung.xml' to the PDF and mark it
        // as an Alternative representation.
        options.Attachments.Add(new PdfAttachment {
            FilePath = "German//xrechnung.xml",
            Type = "text/xml",
            Relationship = PdfAttachmentRelationship.Alternative,
            Description = "Rechnungsdaten im ZUGFeRD-XML-Format",
        });

        // Export the report to a ZUGFeRD-compliant PDF file.
        report.ExportToPdf("germanResult.pdf", options);
        
        // Open the resulting PDF document.
        Process.Start("germanResult.pdf");
    }
}
```

#### XRechnung Resources (XML + XMP Metadata)

- [xrechnung.xml](./CS/ZUGFeRD_sample/German/xrechnung.xml)

    The UN/CEFACT Cross Industry Invoice payload is compliant with the German XRechnung profile. The report uses this file as its data source.

- [ZUGFeRD_DocumentInfo.txt](./CS/ZUGFeRD_sample/German/ZUGFeRD_DocumentInfo.txt)

    The XMP RDF fragment that contains ZUGFeRD/XRechnung metadata for the PDF document.

- [ZUGFeRD_PdfASchema.txt](./CS/ZUGFeRD_sample/German/ZUGFeRD_PdfASchema.txt)

    The XMP PDF/A extension schema that defines the `fx` namespace and its properties. The schema ensures that PDF/A validation correctly interprets `fx:*` fields defined in _ZUGFeRD_DocumentInfo.txt_.

#### Supported Standards (German Invoices)

- The embedded XML file relationship must be set to `ALTERNATIVE`.
- The embedded XML file name must be `xrechnung.xml`.
- The XMP `fx:Version` value must match the currently valid XRechnung version (this example uses `3.0`, valid as 2026-01-08).
- The XMP `fx:ConformanceLevel` value must be set to `XRECHNUNG`.

#### German Extension Schema (XRechnung):

```xml
<rdf:Description xmlns:fx="urn:factur-x:pdfa:CrossIndustryDocument:invoice:1p0#" rdf:about="">
      <fx:DocumentType>INVOICE</fx:DocumentType>
      <fx:DocumentFileName>xrechnung.xml</fx:DocumentFileName>
      <fx:Version>3.0</fx:Version>
      <fx:ConformanceLevel>XRECHNUNG</fx:ConformanceLevel>
</rdf:Description>
```

### Export to ZUGFeRD (France)

When you click the "French Specific" button, the application does the following:

-	Loads two metadata fragments and concatenates them into `AdditionalMetadata`.
-	Sets PDF/A-3b compliance.
-	Attaches the `factur-x.xml` file with the `Data` relationship (Factur-X 1.0x spec).
-	Exports the report and opens the resulting PDF.

```cs
using System;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraPrinting;

void ButtonExportFrance_Click(object sender, EventArgs e) {
    // Create a report.
    using (var report = new XtraReport1())
    {
        // Specify the Factur-X XML data source.
        report.XmlDataPath = "French//factur-x.xml";

        // Load ZUGFeRD XMP metadata fragments and concatenate them
        // into a single AdditionalMetadata block.
        string additionalMetadata =
            File.ReadAllText("French//ZUGFeRD_DocumentInfo.txt") +
            File.ReadAllText("French//ZUGFeRD_PdfASchema.txt");

        // Configure PDF export options:
        // - Enable PDF/A-3b compliance
        // - Inject ZUGFeRD/Factur-X XMP metadata
        var options = new PdfExportOptions {
            PdfACompatibility = PdfACompatibility.PdfA3b,
            AdditionalMetadata = additionalMetadata
        };

        // Attach the Factur-X XML file to the PDF.
        // Use the Data relationship.
        options.Attachments.Add(new PdfAttachment {
            FilePath = "French//factur-x.xml",
            Type = "text/xml",
            Relationship = PdfAttachmentRelationship.Data,
            Description = "Facture XML conforme Factur-X",
        });

        // Export the report to a Factur-X–compliant PDF file.
        report.ExportToPdf("frenchResult.pdf", options);
        
        // Open the resulting PDF document.
        Process.Start("frenchResult.pdf");
    }
}
```

#### Factur‑X Resources (XML + XMP Metadata)

File to Review:

- [factur-x.xml](./CS/ZUGFeRD_sample/French/factur-x.xml)

    Factur-X (EN 16931) invoice payload (UN/CEFACT Cross Industry Invoice). The report uses this file as its data source.

- [ZUGFeRD_DocumentInfo.txt](./CS/ZUGFeRD_sample/French/ZUGFeRD_DocumentInfo.txt)

    The XMP RDF fragment that contains Factur-X-specific metadata for the PDF document.

- [ZUGFeRD_PdfASchema.txt](./CS/ZUGFeRD_sample/French/ZUGFeRD_PdfASchema.txt)

    The PDF/A extension schema used by Factur-X in XMP. The schema ensures that PDF/A validation correctly interprets `fx:*` fields defined in _ZUGFeRD_DocumentInfo.txt_.

#### Supported Standards (French Invoices)

- The embedded XML file relationship must be set to `DATA`.
- The embedded XML file name must be `factur-x.xml`.
- The XMP `fx:Version` value must be `1.0`.
- The XMP `fx:ConformanceLevel` value must be set to `BASIC` (or another Factur-X profile based on your preferences).

#### French Extension Schema (Factur-X)

```xml
<rdf:Description xmlns:fx="urn:factur-x:pdfa:CrossIndustryDocument:invoice:1p0#" rdf:about="">
  <fx:DocumentType>INVOICE</fx:DocumentType>
  <fx:DocumentFileName>factur-x.xml</fx:DocumentFileName>
  <fx:Version>1.0</fx:Version>
  <fx:ConformanceLevel>BASIC</fx:ConformanceLevel>
</rdf:Description>
```


## Files to Review

- [Form1.cs](./CS/ZUGFeRD_sample/Form1.cs) (VB: [Form1.vb](./VB/ZUGFeRD_sample/Form1.vb))
- [factur-x.xml](./CS/ZUGFeRD_sample/French/factur-x.xml) (VB: [factur-x.xml](./VB/ZUGFeRD_sample/French/factur-x.xml))
- [ZUGFeRD_DocumentInfo.txt](./CS/ZUGFeRD_sample/French/ZUGFeRD_DocumentInfo.txt) (VB: [ZUGFeRD_DocumentInfo.txt](./VB/ZUGFeRD_sample/French/ZUGFeRD_DocumentInfo.txt))
- [ZUGFeRD_PdfASchema.txt](./CS/ZUGFeRD_sample/French/ZUGFeRD_PdfASchema.txt) (VB: [ZUGFeRD_PdfASchema.txt](./VB/ZUGFeRD_sample/French/ZUGFeRD_PdfASchema.txt))
- [xrechnung.xml](./CS/ZUGFeRD_sample/German/xrechnung.xml) (VB:[xrechnung.xml](./VB/ZUGFeRD_sample/German/xrechnung.xml))
- [ZUGFeRD_DocumentInfo.txt](./CS/ZUGFeRD_sample/German/ZUGFeRD_DocumentInfo.txt) (VB:[ZUGFeRD_DocumentInfo.txt](./VB/ZUGFeRD_sample/German/ZUGFeRD_DocumentInfo.txt) )
- [ZUGFeRD_PdfASchema.txt](./CS/ZUGFeRD_sample/German/ZUGFeRD_PdfASchema.txt) (VB:[ZUGFeRD_PdfASchema.txt](./VB/ZUGFeRD_sample/German/ZUGFeRD_PdfASchema.txt))


## Documentation 

* [Export to PDF](https://docs.devexpress.com/XtraReports/2574/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports/export-to-pdf)
* [Create a Report with a Visual PDF Signature](https://docs.devexpress.com/XtraReports/402208/create-reports/create-a-report-with-visual-pdf-signature)
* [Create an Invoice](https://docs.devexpress.com/XtraReports/117229/create-reports/create-an-invoice)
* [Create an Invoice from Templates](https://docs.devexpress.com/XtraReports/119811/create-reports/create-an-invoice-from-templates)
* [Create a Swiss QR Bill](https://docs.devexpress.com/XtraReports/400351/create-reports/create-a-swiss-qr-bill)

## More Examples

* [How to Export a Report to PDF and Specify Export Options](https://github.com/DevExpress-Examples/reporting-winforms-export-pdf)
* [How to use the digital signature options when exporting a report to PDF](https://github.com/DevExpress-Examples/Reporting_how-to-use-the-digital-signature-options-when-exporting-a-report-to-pdf-e4191)
* [How to Create a Custom DevExpress Report Control](https://github.com/DevExpress-Examples/Reporting-Custom-Controls)
* [Reporting for WinForms - How to Use MailKit to Send a Report as a Document in PDF](https://github.com/DevExpress-Examples/reporting-winforms-mailkit-email-report-pdf)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-export-pdf-zugferd&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-export-pdf-zugferd&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

