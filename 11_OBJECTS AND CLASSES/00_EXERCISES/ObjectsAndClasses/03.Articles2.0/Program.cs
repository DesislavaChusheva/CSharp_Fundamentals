using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] incomeArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(incomeArticle[0], incomeArticle[1], incomeArticle[2]);
                listOfArticles.Add(article);
            }

            string criteria = Console.ReadLine();

            switch (criteria)
            {
                case "title":
                    listOfArticles = listOfArticles.OrderBy(a=>a.Title).ToList();
                    break;
                case "content":
                    listOfArticles = listOfArticles.OrderBy(a=>a.Content).ToList();
                    break;
                case "author":
                    listOfArticles = listOfArticles.OrderBy(a=>a.Author).ToList();
                    break;

                default:
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine, listOfArticles));
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

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
