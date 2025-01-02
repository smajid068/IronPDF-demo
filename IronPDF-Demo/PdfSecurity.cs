using IronPdf;

namespace IronPDF_Demo;

internal class PdfSecurity
{
    PdfDocument inputPdf { get; set; }

    public PdfSecurity()
    {
        inputPdf = PdfDocument.FromFile(Globals.inputSecureFilePath);
    }

    internal void AddDigitalSignatureWithImage()
    {
        try
        {
            /***** Adding Digital Signature *****/
            // Step 1. Create a Signature.
            // You may create a .pfx or .p12 PDF signing certificate using Adobe Acrobat Reader.
            // Read: https://helpx.adobe.com/acrobat/using/digital-ids.html
            var rectangle = new IronSoftware.Drawing.Rectangle(100, 100, 100, 100);

            // Step 2: Add the digital signature file and a password  
            // Add Optional signing options and a handwritten signature graphic
            var signature = new IronPdf.Signing.PdfSignature(Globals.digitalSignatureFilePath, Globals.digitalSignaturePassword)
            {
                SignatureImage = new IronPdf.Signing.PdfSignatureImage(Globals.signatureImageFilePath, 0, rectangle),
                SigningContact = "support@ironsoftware.com",
                SigningLocation = "US"
            };
            //Step 3. Sign the PDF with the PdfSignature. Multiple signing certificates may be used
            inputPdf.Sign(signature);

            //Step 4. Save to a File, stream or byte array.
            inputPdf.SaveAs(Globals.outputSignedPdfPath);
            Console.WriteLine("Added cryptographic signature with signature image\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        
    }
}
