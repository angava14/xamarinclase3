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
	public partial class NuevoDiag : ContentPage
	{
        private Pacientes pacienteactivo ;
		public NuevoDiag ( Pacientes paciente)
		{
            pacienteactivo = paciente;
			InitializeComponent ();
		}


        public void agregardiag(Object sender, EventArgs e)
        {

            string patologia = diagnosticonuevo.Text;
            pacienteactivo.diagnosticos.Add(patologia);
            Navigation.PushModalAsync(new Diagnosticos(pacienteactivo));

        }

    }
}