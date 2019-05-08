
using System;
using System.IO;
using Service;

namespace PDFService
{
    public class PDFGenerator : IPDFService
    {
        public string GeneratePDF(string title, string image, string text)
        {
            string outputPath = System.IO.Path.Combine(AppContext.BaseDirectory, "PDF");
            AwesomePDF.PDFGenerator generator = new AwesomePDF.PDFGenerator(outputPath);
            return generator.GeneratePDF(title, image, text);
        }
    }
}