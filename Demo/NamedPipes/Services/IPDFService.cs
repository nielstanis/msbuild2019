using System.IO;

namespace Service
{
    public interface IPDFService
    {
        string GeneratePDF(string title, string image, string text);
    }
}