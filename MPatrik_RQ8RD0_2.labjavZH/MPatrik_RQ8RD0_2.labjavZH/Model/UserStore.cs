using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MolnarPatrik_RQ8RD0_2.javitolaborZH.Model
{
    public class UserStore : ContentPage
    {
        public static List<User> Users { get; } = new List<User>();
        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public static bool ValidateUser(string username, string password)
        {
            return Users.Exists(u => u.Username == username && u.Password == password);
        }
    }
}