using System.Collections.Generic;

namespace DigitizingSolution
{
    public class CategorizationService
    {
        public string Categorize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "Uncategorized";
            }

            var keywords = new Dictionary<string, string[]>
            {
                { "Invoice", new[] { "invoice", "bill", "receipt" } },
                { "Contract", new[] { "contract", "agreement", "terms" } },
                { "Report", new[] { "report", "summary", "analysis" } }
            };

            foreach (var category in keywords)
            {
                foreach (var keyword in category.Value)
                {
                    if (text.ToLower().Contains(keyword))
                    {
                        return category.Key;
                    }
                }
            }

            return "Uncategorized";
        }
    }
}
