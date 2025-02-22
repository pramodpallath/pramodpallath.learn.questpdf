using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace pramodpallath.learn.questpdf.samples
{
    public class MultipleOrientationPDFGenerator : IPDFGenerator
    {
        public string GeneratorName => "MultipleOrientation";

        public string Generate()
        {
            string newFile = $"{GeneratorName}.pdf";

            if(System.IO.File.Exists(newFile))
            {
                System.IO.File.Delete(newFile);
            }

            QuestPDF.Settings.License = LicenseType.Community;

            Document
           .Create(container =>
           {
               container.Page(page =>
               {
                   page.Size(PageSizes.A4.Landscape());
                   page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);

                   

                   page.Content()
                       .Text("Cover page");



                  
               });
               container.Page(page =>
               {
                   page.Size(PageSizes.A4);
                   page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);

                   page.Header()
                  .Text("My Custom Header")
                  .FontSize(18)
                  .SemiBold()
                  .AlignCenter();

                   page.Content()
                       .Text("Header Footer");



                   page.Footer()
                   .AlignRight() // Example alignment; can also center or left-align
                   .Text(text =>
                   {
                       text.Span("Page ");
                       text.CurrentPageNumber(); // QuestPDF will insert the current page number
                       text.Span(" of ");
                       text.TotalPages();        // QuestPDF will insert the total pages
                   });
               });
           })
           .GeneratePdf(newFile);

            return newFile;
        }
    }
}
