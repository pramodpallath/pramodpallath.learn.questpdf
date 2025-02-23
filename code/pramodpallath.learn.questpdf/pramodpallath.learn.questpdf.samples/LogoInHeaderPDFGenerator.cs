using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace pramodpallath.learn.questpdf.samples
{
    public class LogoInHeaderPDFGenerator : IPDFGenerator
    {
        public string GeneratorName => "LogoInHeader";

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
                   page.Size(PageSizes.A4);
                   page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);

                   page.Header().Row(row =>
                   {
                       // Fix the width for the image portion
                       row.ConstantItem(60) // 60 points wide (adjust as needed)
                       .Image("pramod-pallath-logo.png") // Add your image here
                            
                            
                          ;

                       // Add a little spacing between the image and text
                       row.Spacing(10);

                       // Fill remaining space with text
                       row.RelativeItem()
                           .Text("My PDF with an Image in the Header")
                           .FontSize(16)
                           .SemiBold();
                   });

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
