using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Diagnostico
{
	public partial class MainPage : ContentPage
	{
        public static IList<Pacientes> pacientes = new ObservableCollection<Pacientes>();

        public MainPage()
		{
            
            BindingContext = pacientes;
            InitializeComponent();
        }

        public void clicked(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Registro());

        }

        public void seleccionado(object sender , Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Pacientes data = e.SelectedItem as Pacientes;           
            Navigation.PushModalAsync(new Diagnosticos(data));
        }


    }
}
