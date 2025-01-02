public static class Globals
{
    // Define static fields or properties
    public static string IronLicenseKey = "Insert Your License Key Here";
    
    public static string inputHtmlFilePath                = "input/TestHtmlFile.htm";
    public static string inputWebUrlPath                  = "https://en.wikipedia.org/wiki/Jensen_Huang";
    public static string inputImageFilePath               = "input/ImageWithText.jpg";
    public static string inputBlankFilePath               = "input/BlankPdf.pdf";
    public static string inputWatermarkFilePath           = "input/TestWatermark.pdf";
    public static string inputMergeFirstFilePath          = "input/FirstPdfForMerge.pdf";
    public static string inputMergeSecondFilePath         = "input/SecondPdfForMerge.pdf";
    public static string inputSecureFilePath              = "input/TestPdfSecurity.pdf";
    public static string inputExtractImageAndTextFilePath = "input/TestPdfWithImages.pdf";
    public static string inputFormFilePath                = "input/FormPdfInput.pdf";

    public static string digitalSignatureFilePath = "input/DigitalSignature.pfx";
    public static string cryptoSignatureFilePath  = "input/TestSignature.p7c";
    public static string signatureImageFilePath   = "input/TestSign.png";
    public static string digitalSignaturePassword = "Aquarium201@";

    public static string outputHtmlToPdfPath      = "output/HtmlToPdfOutput.pdf";
    public static string outputUrlToPdfPath       = "output/UrlToPdfOutput.pdf";
    public static string outputImageToPdfPath     = "output/ImageToPdfOutput.pdf";
    public static string outputAnnotationPdfPath  = "output/AnnotationOutput.pdf";
    public static string outputWaterMarkPdfPath   = "output/WaterMarkOutput.pdf";
    public static string outputMergedPdfPath      = "output/MergedPdfOutput.pdf";
    public static string outputFirstSplitPdfPath  = "output/SplitPdfOutput1.pdf";
    public static string outputSecondSplitPdfPath = "output/SplitPdfOutput2.pdf";
    public static string outputSignedPdfPath      = "output/DigitallySignedOutput.pdf";
    public static string outputAllImagesPdfPath   = "output/AllImagePdfOutput.pdf";
    public static string outputFormPdfPath        = "output/FormPdfOutput.pdf";
    public static string outputEditedFormPdfPath  = "output/FormEditedPdfOutput.pdf";
    public static string outputExtractedTextPath  = "output/ExtractedTextFromPdfOutput.txt";

    public static string watermarkHtml = @"
    <img style='width: 200px;' src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>
    <h1>Iron Software</h1>";

    public static string createFormHtml = @"
    <html>
     <body>
        <h2>Editable PDF Form</h2>
        <form>
            First name: <br> <input type='text' name='firstname' value=''> <br>
            Last name: <br> <input type='text' name='lastname' value=''> <br>
            Address: <br> <textarea name='address' rows='4' cols='50'></textarea>
            <h2>Task Completed</h2>
            <label>
            <input type='checkbox' id='taskCompleted' name='taskCompleted'> Mark task as completed
            </label>
            <h2>Select Priority</h2>
            <label for='priority'>Choose priority level:</label>
            <select id='priority' name='priority'>
              <option value='high'>High</option>
              <option value='medium'>Medium</option>
              <option value='low'>Low</option>
            </select>
        </form>
     </body>
    </html>
    ";
}


