using ReadGhost.ServiceReference;

namespace ReadGhost.src
{
    class MicroSoftTranslateService
    {
        public static string GetTranslateResult(string word)
        {
            string result;
            LanguageServiceClient client = new LanguageServiceClient();
            result = client.Translate("503BBB1CCBEDC4C8C246419445C05ABE11A9CF12", word, "en", "zh-CHS", "text/html", "general");
            return result;
        }
    }
}
