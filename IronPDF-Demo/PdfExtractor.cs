using IronPdf;

namespace IronPDF_Demo;

internal class PdfExtractor
{
    PdfDocument inputPdf {  get; set; }

    public PdfExtractor()
    {
        inputPdf = PdfDocument.FromFile(Globals.inputExtractImageAndTextFilePath);
    }

    internal void ExtractImagesFromPdf()
    {
        try
        {
            var outputPdfWithImages = new PdfDocument(1000, 1000);
            var allImagesOfPdf = inputPdf.ExtractAllImages();

            foreach (var image in allImagesOfPdf)
            {
                var imageToPdf = ImageToPdfConverter.ImageToPdf(image);
                outputPdfWithImages = PdfDocument.Merge(outputPdfWithImages, imageToPdf);
            }

            outputPdfWithImages.RemovePage(0);
            outputPdfWithImages.SaveAs(Globals.outputAllImagesPdfPath);
            Console.WriteLine("Extracted All Images from Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void ExtractTextFromPdfPage()
    {
        try
        {
            // Extract all texts from the first page of pdf
            var allText = inputPdf.ExtractTextFromPage(0);
            File.WriteAllText(Globals.outputExtractedTextPath, allText);
            Console.WriteLine("Extracted All Text from First Page of Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
