using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestXamarinForms1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        public void OnSave(object sender, EventArgs e)
        {
            LabelMessage.Text = "You clicked the damn button...";
        }
	}
}
