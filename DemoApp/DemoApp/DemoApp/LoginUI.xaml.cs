using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoApp

{
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string userEmail = emailEntry.Text;
            string userPassword = passwordEntry.Text;

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPassword))
            {
                DisplayAlert("Error", "Please enter email and password", "OK");
            }
            else if (userEmail == "ankikrai16@gmail.com" && userPassword == "Ondot@123")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Invalid email or password", "OK");
            }
        }
    }

}







