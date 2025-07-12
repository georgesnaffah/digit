using System;
using System.Configuration;
using System.IO;

namespace DigitizingSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var databaseService = new DatabaseService(connectionString);
            databaseService.CreateTable();

            var ocrService = new OcrService();
            var categorizationService = new CategorizationService();

            var directoryPath = args.Length > 0 ? args[0] : ".";

            foreach (var filePath in Directory.GetFiles(directoryPath, "*.pdf"))
            {
                var text = ocrService.PerformOcr(filePath, "ara+eng");
                var category = categorizationService.Categorize(text);
                databaseService.InsertDocument(filePath, category);

                Console.WriteLine($"Processed {filePath} - Category: {category}");
            }
        }
    }
}
