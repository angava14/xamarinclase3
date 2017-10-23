using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diagnostico
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{



        public Registro ()
		{
			InitializeComponent ();
		}


        public void registrar (Object sender, EventArgs e)
        {

            string name = nombre.Text;
            string lastname = apellido.Text;
            string fullname = name + " " + lastname;
            string diagnostico = diagnosticoinicial.Text ;
            Pacientes nuevo =  new Pacientes(fullname, diagnostico);
            MainPage.pacientes.Add(nuevo);
            Navigation.PushModalAsync(new MainPage());


        }

 

    }
}