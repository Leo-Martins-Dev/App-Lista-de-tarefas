using TodoListApp.Views;

namespace TodoListApp;

public partial class App 
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new TodoListPage());
    }
    
    
}