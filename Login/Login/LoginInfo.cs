using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    public class LoginInfo
    {
        public string name { get; set; }
        public string password { get; set; }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var info = (LoginInfo)BindingContext;
            message.Text = "Hai New User! " + "Your name is " + info.name;

        }
    }
}
