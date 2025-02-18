using DAM_Leccion_SHB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAM_Leccion_SHB.ViewModel
{
    public class MainPageViewModel
    {
        public PersonasModel personasModel { get; set; }

        public MainPageViewModel()

        {
            Consultar();
        }

        public void Consultar()
        {
            personasModel = new PersonasModel()
            {

                Nombre = "Sandra",
                Apellido = "Hernandez",
                Edad = "22",

            };


        }
    }
}



