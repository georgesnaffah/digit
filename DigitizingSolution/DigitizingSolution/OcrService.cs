using System;
using System.Drawing;
using Tesseract;

namespace DigitizingSolution
{
    public class OcrService
    {
        public string PerformOcr(string imagePath, string language)
        {
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", language, EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            return page.GetText();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }
    }
}
