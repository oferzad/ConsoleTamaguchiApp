using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleTamaguchiApp.UI
{
    class MainMenu:Menu
    {
        public MainMenu() : base($"Main Menu - {UIMain.CurrentPlayer.PlayerName} is logged in")
        {
            //Build items in main menu!
            AddItem("Show Player", new PlayerScreen());
            //AddItem("Change Password", new ChangePasswordScreen());
        }

        
    }
}
