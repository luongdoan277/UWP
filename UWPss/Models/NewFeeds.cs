using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPss.Models
{
    public class NewFeeds
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public NewsCategory Category { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }

        public NewFeeds(string name, NewsCategory category)
        {
            Name = name;
            Category = category;
            Image = String.Format("/Assets/Images/{0}/{1}.png", category, name);
        }
    }
    
    public enum NewsCategory
    {
        Education,
        Food
    }

    public class NewsManager
    {
        public static void GetAllNews(ObservableCollection<NewFeeds> newFeeds)
        {
            var allnews = GetNewFeeds();
            newFeeds.Clear();
            allnews.ForEach(p => newFeeds.Add(p));
        }
        public static void GetnewsByCategory(ObservableCollection<NewFeeds> newFeeds, NewsCategory newsCategory)
        {
            var allnews = GetNewFeeds();
            var filterednews = allnews.Where(p => p.Category == newsCategory).ToList();
            newFeeds.Clear();
            filterednews.ForEach(p => newFeeds.Add(p));
        }
        public static void GetnewsByName(ObservableCollection<NewFeeds> newFeeds, string title)
        {
            var allnews = GetNewFeeds();
            var filterednews = allnews.Where(p => p.Title == title).ToList();
            newFeeds.Clear();
            filterednews.ForEach(p => newFeeds.Add(p));
        }
        private static List<NewFeeds> GetNewFeeds()
        {
            var news = new List<NewFeeds>();

            news.Add(new NewFeeds("Primary", NewsCategory.Education));
            news.Add(new NewFeeds("Junior", NewsCategory.Education));
            news.Add(new NewFeeds("High", NewsCategory.Education));
            news.Add(new NewFeeds("University", NewsCategory.Education));

            news.Add(new NewFeeds("Street", NewsCategory.Food));
            news.Add(new NewFeeds("Restaurant ", NewsCategory.Food));

            return news;
        }
    }
}
