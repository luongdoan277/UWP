using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP42.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Lorem ipsum dolor sit amet consectetuer", Subhead = "Nunc tristique nec", DateLine = "now", Image = "Assets/Financial1.png" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Headline = "Eodem modo typi, qui nunc nobis", Subhead = "tortor porttitor, eu fermentum ante congue", DateLine = "now", Image = "Assets/Financial2.png" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Headline = "In but weary deadly so to domestic into felt forgot", Subhead = "in viverra metus facilisis", DateLine = "now", Image = "Assets/Financial3.png" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Headline = "Eodem modo typi, qui nunc nobis", Subhead = "Nunc tristique nec", DateLine = "now", Image = "Assets/Financial4.png" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Headline = "Lorem ipsum dolor sit amet consectetuer", Subhead = "Curabitur dictum augue vitae elementum", DateLine = "now", Image = "Assets/Financial5.png" });

            items.Add(new NewsItem() { Id = 6, Category = "Food", Headline = "Lorem ipsum dolor sit amet consectetuer", Subhead = "Nunc tristique nec", DateLine = "now", Image = "Assets/Food1.png" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Headline = "Eodem modo typi, qui nunc nobis", Subhead = "tortor porttitor, eu fermentum ante congue", DateLine = "now", Image = "Assets/Food2.png" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Headline = "In but weary deadly so to domestic into felt forgot", Subhead = "in viverra metus facilisis", DateLine = "now", Image = "Assets/Food3.png" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Headline = "Eodem modo typi, qui nunc nobis", Subhead = "Nunc tristique nec", DateLine = "now", Image = "Assets/Food4.png" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Headline = "Lorem ipsum dolor sit amet consectetuer", Subhead = "Curabitur dictum augue vitae elementum", DateLine = "now", Image = "Assets/Food5.png" });

            return items;
        }
    }
}
