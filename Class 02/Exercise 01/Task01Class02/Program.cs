using ClassLibrary1;

public class Program
{
    static void Main()
    {
        Document doc = new Document("This is a sample document.");
        doc.Search("sample");
        doc.Search("docs");

        WebPage webpage = new WebPage("https://www.example.com", "This is a sample webpage.");
        webpage.Search("example");
        webpage.Search("dontexist");
    }
}