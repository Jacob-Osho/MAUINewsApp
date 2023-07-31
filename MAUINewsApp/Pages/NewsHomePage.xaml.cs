using MAUINewsApp.Models;
using MAUINewsApp.Services;

namespace MAUINewsApp;

public partial class NewsHomePage : ContentPage
{
    List<Article> articlesList;
    List<CategoryModel> categories;
    public NewsHomePage()
    {
        InitializeComponent();
        articlesList = new List<Article>();
        categories = new List<CategoryModel>()
        { 
            new CategoryModel(){Name="World", ImageUrl = "world.png"},
        new CategoryModel(){Name = "Nation" , ImageUrl="nation.png"},
        new CategoryModel(){Name = "Business" , ImageUrl="business.png"},
        new CategoryModel(){Name = "Technology" , ImageUrl="technology.png"},
        new CategoryModel(){Name = "Entertainment", ImageUrl = "entertainment.png"},
        new CategoryModel(){Name = "Sports" , ImageUrl="sports.png"},
        new CategoryModel(){Name = "Science", ImageUrl= "science.png"},
        new CategoryModel(){Name = "Health", ImageUrl="health.png"},
        };
        GetBreakingNews();
        CvCategories.ItemsSource = categories;
    }

    private async void GetBreakingNews()
    {
        var api = new ApiService();
        var newsResult = await api.GetNews("general");
        foreach (var item in newsResult.Articles)
        {
            articlesList.Add(item);

        }
        CvNews.ItemsSource = articlesList;
    }

    private  void CvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var category = e.CurrentSelection.FirstOrDefault() as CategoryModel;
        if (category == null) return;
        Navigation.PushAsync( new NewsListPage(category.Name) );
        ((CollectionView)sender).SelectedItem = null; 
    }
}