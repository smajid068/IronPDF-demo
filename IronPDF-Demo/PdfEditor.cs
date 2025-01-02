using IronPdf;
using IronPdf.Annotations;

namespace IronPDF_Demo;

internal class PdfEditor
{
    PdfDocument inputPdf { get; set; } = null!;

   internal void AddAnnotation()
   {
        try
        {
            inputPdf = PdfDocument.FromFile(Globals.inputBlankFilePath);
            // Create a PDF annotation object on a specified page index
            TextAnnotation annotation = new TextAnnotation(0)
            {
                Title = "This is the title",
                Contents = "This is the long 'sticky note' comment content...",
                X = 50,
                Y = 700,
            };

            // Add the annotation
            inputPdf.Annotations.Add(annotation);
            inputPdf.SaveAs(Globals.outputAnnotationPdfPath);
            Console.WriteLine("Added Annotation\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    internal void AddWaterMark()
    {
        try
        {
            inputPdf = PdfDocument.FromFile(Globals.inputWatermarkFilePath);

            // Apply watermark with 45 degrees rotation and 70% opacity
            inputPdf.ApplyWatermark(Globals.watermarkHtml, rotation: 45, opacity: 70);
            inputPdf.SaveAs(Globals.outputWaterMarkPdfPath);
            Console.WriteLine("Added Watermark\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void MergePdf()
    {
        try
        {
            var firstPdf = PdfDocument.FromFile(Globals.inputMergeFirstFilePath);
            var secondPdf = PdfDocument.FromFile(Globals.inputMergeSecondFilePath);

            var mergedPdf = PdfDocument.Merge(firstPdf, secondPdf);
            mergedPdf.SaveAs(Globals.outputMergedPdfPath);
            Console.WriteLine("Merged Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void SplitPdf()
    {
        try
        {
            inputPdf = PdfDocument.FromFile(Globals.inputMergeSecondFilePath);

            var firstSplitPdf = inputPdf.CopyPages(0, 2);
            var secondSplitPdf = inputPdf.CopyPages(3, 6);

            firstSplitPdf.SaveAs(Globals.outputFirstSplitPdfPath);
            secondSplitPdf.SaveAs(Globals.outputSecondSplitPdfPath);
            Console.WriteLine("Splitted Pdf\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    internal void FillForm()
    {
        try
        {
            inputPdf = PdfDocument.FromFile(Globals.inputFormFilePath);
            var pdfForm = inputPdf.Form;

            pdfForm.FindFormField("firstname").Value = "John";
            pdfForm.FindFormField("lastname").Value = "Smith";

            // Set text area form values
            pdfForm.FindFormField("address").Value = "Iron Software LLC\r\n205 N. Michigan Ave.";
            var checkboxForm = pdfForm.FindFormField("taskCompleted");
            // Check the checkbox form
            checkboxForm.Value = "Yes";
            var comboboxForm = pdfForm.FindFormField("priority");
            // Set the combobox value
            comboboxForm.Value = "Low";

            inputPdf.SaveAs(Globals.outputEditedFormPdfPath);
            Console.WriteLine("Filled Pdf Form with Data\n");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}
