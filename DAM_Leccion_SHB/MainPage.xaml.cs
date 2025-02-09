using DAM_Leccion_SHB.Model;

namespace DAM_Leccion_SHB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public PersonaModel PersonaModel { get; set; }



        public MainPage()

        {
            InitializeComponent();
            Ejecutar();

        }

        private void OnCounterClicked(object sender, EventArgs e )
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
            
            PersonaModel personaModel = new PersonaModel()

             {
                 Nombre = "Hola aqui estoy",
             };

            BindingContext = personaModel;

            //{

            //txtNombre.Text = "Hola aqui estoy";
            //}

            //BindingContext = personaModel.Nombre;



            //personaModel.Nombre = "Hola aqui estoy";

            //txtNombre.Text = personaModel.Nombre;




            //inding personaBinding = new Binding();

            //personaBinding.Source = personaModel; //Origen
            //personaBinding.Path = "Nombre"; //ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding);

        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            PersonaModel.Nombre = "Sandra Hernandez";

            //DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
            //PersonaModel.Nombre = "Sandra Hernandez";
            //PersonaModel personaModel = new PersonaModel();

        }
    }

}
