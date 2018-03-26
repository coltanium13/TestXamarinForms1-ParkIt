using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestXamarinForms1.Model;

namespace TestXamarinForms1
{
	public partial class MainPage : ContentPage
	{
        public User CurrentUser;


        public MainPage()
		{
			InitializeComponent();
            CurrentUser = new MockDataSource().FakeUser;
		}

        public void OnSave(object sender, EventArgs e)
        {
            if(CurrentUser != null)
                LabelMessage.Text = $"You clicked the damn button...{CurrentUser.Name}";
        }
	}
}
