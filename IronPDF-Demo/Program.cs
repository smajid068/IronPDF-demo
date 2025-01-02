using IronPDF_Demo;

IronPdf.License.LicenseKey = Globals.IronLicenseKey;

Console.WriteLine("===Welcome to IronPDF Demo===\n\n");

int demoOption = -1;

while (demoOption != 0)
{
    Console.WriteLine("");
    Console.WriteLine("1. Pdf Converter- Convert HTML, URL, Image and Forms to Pdf.\n");
    Console.WriteLine("2. Pdf Editor- Add Annotation, Watermark to PDF, Merge & Split Pdf, Fill Pdf Form.\n");
    Console.WriteLine("3. Pdf Extractor- Extract Text and Images from Pdf.\n");
    Console.WriteLine("4. Pdf Security- Digitally Sign a PDF with Signature Image.\n");
    Console.WriteLine("0. Exit\n");

    Console.WriteLine("Please choose which section you would like to check: ");

    string input = Console.ReadLine()!;
    demoOption = int.Parse(input);

    while (demoOption == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("==Pdf Converter==\n");
        Console.WriteLine("1. Html To Pdf\n");
        Console.WriteLine("2. URL To Pdf\n");
        Console.WriteLine("3. Image To Pdf\n");
        Console.WriteLine("4. HTML to PDF Form\n");
        Console.WriteLine("0. Go Back\n");
        Console.WriteLine("Please choose which feature you would like to check: ");

        string tempInput = Console.ReadLine()!;
        int pdfOption    = int.Parse(tempInput);

        // Pdf Converter
        var pdfConverter = new PdfConverter();

        switch (pdfOption)
        {
            case 1:
              pdfConverter.ConvertHtmlFileToPdf();
              break;

            case 2:
              pdfConverter.ConvertWebPageToPdf();
              break;
                
           case 3:
              pdfConverter.ConvertImageToPdf();
              break;
                
           case 4:
              pdfConverter.CreateFormPdfFromHtml();
              break; 
           default:
              demoOption = -1;
              break;
        }
    }

    while (demoOption == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("==Pdf Editor==\n");
        Console.WriteLine("1. Add Annotation\n");
        Console.WriteLine("2. Add Watermark\n");
        Console.WriteLine("3. Merge Pdf\n");
        Console.WriteLine("4. Split PDF\n");
        Console.WriteLine("5. Fill PDF Form\n");
        Console.WriteLine("0. Go Back\n");
        Console.WriteLine("Please choose which feature you would like to check: ");

        string tempInput = Console.ReadLine()!;
        int pdfOption    = int.Parse(tempInput);

        // Pdf Editor
        var pdfEditor = new PdfEditor();

        switch (pdfOption)
        {
            case 1:  
               pdfEditor.AddAnnotation();
               break;
                
            case 2:     
               pdfEditor.AddWaterMark();
               break;

            case 3:
               pdfEditor.MergePdf();
               break;

            case 4: 
               pdfEditor.SplitPdf();
               break;
                
            case 5:
               pdfEditor.FillForm();
               break;

            default: 
               demoOption = -1; 
               break;
        }
    }

    while (demoOption == 3)
    {
        Console.WriteLine("");
        Console.WriteLine("==Pdf Extractor==\n");
        Console.WriteLine("1. Extract Text from PDF Page\n");
        Console.WriteLine("2. Extract All Images from PDF\n");
        Console.WriteLine("0. Go Back\n");
        Console.WriteLine("Please choose which feature you would like to check: ");

        string tempInput = Console.ReadLine()!;
        int pdfOption = int.Parse(tempInput);

        // Pdf Extractor
        var pdfExtractor = new PdfExtractor();

        switch(pdfOption)
        { 
            case 1:
                pdfExtractor.ExtractTextFromPdfPage();
                break;

            case 2:
                pdfExtractor.ExtractImagesFromPdf();
                break;

            default:
                demoOption = -1;
                break;
        } 
    }

    while (demoOption == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("==Pdf Security==\n");
        Console.WriteLine("1. Add Digital Signature With Image\n");
        Console.WriteLine("0. Go Back\n");
        Console.WriteLine("Please choose which feature you would like to check: ");

        string tempInput = Console.ReadLine()!;
        int pdfOption = int.Parse(tempInput);

        // Pdf Security
        var pdfSecurity = new PdfSecurity();
        switch (pdfOption)
        {
            case 1:
             pdfSecurity.AddDigitalSignatureWithImage();
             break;

            default:
             demoOption = -1;
             break;
        }
    }
}

Console.WriteLine("Thank you from Iron Software for trying the demo\n");