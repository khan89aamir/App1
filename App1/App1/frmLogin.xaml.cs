using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmLogin : ContentPage
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pass = txtPassword.Text;

            if (ValidateUser(userName, pass))
            {

                // creating object
                frmHome ObjHome = new frmHome();

                //setting data
                ObjHome.strLoginUserName = userName;

                // calling the form
                App.Current.MainPage= ObjHome; // on apprearing

            }
            else
            {
                 await  DisplayAlert("Login", "Incorrect user name and password", "OK");

               
            }
        }
        private bool ValidateUser(string userName, string pass)
        {
            bool result = false;
            if (userName=="admin" && pass=="123")
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        
        }
    }
}