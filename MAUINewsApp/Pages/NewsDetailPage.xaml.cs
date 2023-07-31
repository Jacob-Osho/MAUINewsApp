using MAUINewsApp.Models;

namespace MAUINewsApp;

public partial class NewsDetailPage : ContentPage
{
    public NewsDetailPage(Article article )
    {
        InitializeComponent();
   
        imgNews.Source = article.Image; 
        lblBody.Text = article.Content; 
        lblTitle.Text = article.Title; 
    }
    
}