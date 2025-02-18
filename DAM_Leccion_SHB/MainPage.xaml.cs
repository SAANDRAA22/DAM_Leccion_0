using DAM_Leccion_SHB.Model;
using DAM_Leccion_SHB.ViewModel;

namespace DAM_Leccion_SHB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public PersonasModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Ejecutar()
        {
            personaModel = new PersonasModel()
            {
                Nombre = "Sandra",
                Apellido = "Hernandez",
                Edad = "22",
            };

            BindingContext = personaModel;

            //Binding personaBinding = new Binding();

            //personaBinding.Source = personaModel;//Origen
            //personaBinding.Path = "Nombre";//Ruta
            //txtNombre.SetBinding(Entry.TextProperty,personaBinding);//Destino final
            //txtNombre.Text = personaModel.Nombre;
        }
        //Evento Aceptar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema ","Se ha guardado el registro en la BD","Aceptar");
            //personasModel.Nombre = "sa";
            //personasModel.Apellido = "he";
            //personasModel.Edad = "19";
        }
    }

}
