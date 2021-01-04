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
    public partial class frmHome : ContentPage
    {
        public string strLoginUserName;
        public frmHome()
        {
            InitializeComponent();
          

        }

        // Load method 
        protected override void OnAppearing()
        {
            lblLoginBy.Text = "Login By : " + strLoginUserName;
            base.OnAppearing();
        }
       
    }
}