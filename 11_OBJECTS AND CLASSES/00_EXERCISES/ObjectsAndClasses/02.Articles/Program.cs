using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] incomeArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(incomeArticle[0], incomeArticle[1], incomeArticle[2]);

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (arguments[0])
                {
                    case "Edit":
                        article.Edit(arguments[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(arguments[1]);
                        break;
                    case "Rename":
                        article.Rename(arguments[1]);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title{ get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string content)
        {
            Content = content;
        }
        public void ChangeAuthor (string author)
        {
            Author = author;
        }
        public void Rename (string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
