using Ciortea_Trif_Bianca_Elena_Lab11.Data;

namespace Ciortea_Trif_Bianca_Elena_Lab11


{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService()); 
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
