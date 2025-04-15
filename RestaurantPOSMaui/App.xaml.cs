using RestaurantPOSMaui.Data;

namespace RestaurantPOSMaui
{
    public partial class App : Application
    {
        private readonly DatabaseServices _databaseService;
        public App(DatabaseServices databaseService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            _databaseService = databaseService;
        }

        protected override async void OnStart()
        {
            base.OnStart();

            await _databaseService.InitializeDatabaseAsync();
            await _databaseService.SeedDataAsync();
        }
    }
}
