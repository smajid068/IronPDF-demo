using IronPdf;

namespace IronPDF_Demo;

internal class PdfConverter
{
    ChromePdfRenderer renderer { get; set; }

    public PdfConverter()
    {
        renderer = new ChromePdfRenderer();
    }

    internal void ConvertHtmlFileToPdf()
    {
        var convertedHtmlToPdf = renderer.RenderHtmlFileAsPdf(Globals.inputHtmlFilePath);
        try
        {
            convertedHtmlToPdf.SaveAs(Globals.outputHtmlToPdfPath);
            Console.WriteLine("Converted Html to Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void ConvertWebPageToPdf()
    {
        var convertedUrlToPdf = renderer.RenderUrlAsPdf(Globals.inputWebUrlPath);
        try
        {
            convertedUrlToPdf.SaveAs(Globals.outputUrlToPdfPath);
            Console.WriteLine("Converted URL to Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void ConvertImageToPdf()
    {
        var convertedImagetoPdf = ImageToPdfConverter.ImageToPdf(Globals.inputImageFilePath);
        try
        {
            convertedImagetoPdf.SaveAs(Globals.outputImageToPdfPath);
            Console.WriteLine("Converted Image to PDF\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void CreateFormPdfFromHtml()
    {
        try
        {
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            renderer.RenderHtmlAsPdf(Globals.createFormHtml)
                    .SaveAs(Globals.outputFormPdfPath);

            Console.WriteLine("Form Created from HTML\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
