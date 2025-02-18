using DAM_Leccion_SHB.ViewModel;
using DAM_Leccion_SHB.Model;
namespace DAM_Leccion_SHB.View;

public partial class PersonasView : ContentPage
{
    public PersonasView()
    {
        InitializeComponent();
        BindingContext = new PersonasViewModel();
    }
} 