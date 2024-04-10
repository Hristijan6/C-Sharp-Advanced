namespace ClassLibrary1
{
    public class WebPage : Searchable
    {
        private string url;
        private string content;

        public WebPage(string url, string content)
        {
            this.url = url;
            this.content = content;
        }

        public void Search(string word)
        {
            if (content.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found on webpage '{url}'.");
            }
            else
            {
                Console.WriteLine($"Word '{word}' not found on webpage '{url}'.");
            }
        }
    }
}

