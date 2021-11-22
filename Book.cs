using System.IO;
namespace bonus_lab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;
        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            isbn = tempIsbn;
            title = tempTitle;
            author = tempAuthor;
        }
        public void SetIsbn(string tempIsbn)
        {
            isbn = tempIsbn;
        }
        public string GetIsbn()
        {
            return isbn;
        }
        public void SetTitle(string tempTitle)
        {
            title = tempTitle;
        }
        public string GetTitle()
        {
            return title;
        } 
        public void SetAuthor(Author tempAuthor)
        {
            author = tempAuthor;
        }
        public Author GetAuthor()
        {
            return author;
        }
        public override string ToString()
        {
            return $"isbn = {this.GetIsbn()}, title = {this.GetTitle()}, author: {this.author.ToString()}";
        }
    }
}