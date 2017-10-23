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
	public partial class Editar : ContentPage
	{
		public Editar (Pacientes diagnostico)
		{
            Pacientes abc = diagnostico;
			InitializeComponent ();
		}
	}
}