using DAM_Leccion_SHB.View;

namespace DAM_Leccion_SHB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new PersonasView();
        }
    }
}