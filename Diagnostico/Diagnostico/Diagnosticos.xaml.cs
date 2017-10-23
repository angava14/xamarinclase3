using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diagnostico
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Diagnosticos : ContentPage
	{
        private Pacientes pacienteenviar;

		public Diagnosticos (Pacientes paciente)
		{
            pacienteenviar = paciente;
            BindingContext = paciente.diagnosticos;
			InitializeComponent ();
		}

        public void agregardiag(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NuevoDiag(pacienteenviar));

        }
        public void inicio(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());

        }

        public void editardiag(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Pacientes data = e.SelectedItem as Pacientes;
            Navigation.PushModalAsync(new Editar(data));

        }


    }
}