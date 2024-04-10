namespace ClassLibrary1
{
    public class Document : Searchable
    {
        private string content;

        public Document(string content)
        {
            this.content = content;
        }

        public void Search(string word)
        {
            if (content.Contains(word))
            {
                Console.WriteLine($"Word '{word}' found in document.");
            }
            else
            {
                Console.WriteLine($"Word '{word}' not found in document.");
            }
        }
    }
}

