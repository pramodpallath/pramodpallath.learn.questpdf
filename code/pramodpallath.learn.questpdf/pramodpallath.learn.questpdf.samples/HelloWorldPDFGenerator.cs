using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace pramodpallath.learn.questpdf.samples
{
    public class HelloWorldPDFGenerator : IPDFGenerator
    {
        public string GeneratorName => "Hello World";

        public string Generate()
        {
            string newFile = $"HelloWorld-{Guid.NewGuid()}.pdf";
            QuestPDF.Settings.License = LicenseType.Community;

            Document
           .Create(container =>
           {
               container.Page(page =>
               {
                   page.Size(PageSizes.A4);
                   page.Content()
                       .Text("Hello World");
               });
           })
           .GeneratePdf(newFile);

            return newFile;
        }
    }
}
