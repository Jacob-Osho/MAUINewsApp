using MAUINewsApp.Models;
using MAUINewsApp.Services;

namespace MAUINewsApp;

public partial class NewsListPage : ContentPage
{
    List<Article> articlesList;

    public NewsListPage(string category)
    {
        InitializeComponent();
        Title = category;
        articlesList =new List<Article>();
        GetNews(category);
      
    }

    private async void GetNews(string category)
    {
        var api = new ApiService();
        var news = await api.GetNews(category);
        if (news == null) return;
        foreach (var item in news.Articles) { articlesList.Add(item); }
        CvNews.ItemsSource = articlesList;

    }

    private void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)

    {
        var article = e.CurrentSelection.FirstOrDefault() as Article;
        if (article == null) return;
        Navigation.PushAsync(new NewsDetailPage(article));
        ((CollectionView)sender).SelectedItem = null;
    }
}