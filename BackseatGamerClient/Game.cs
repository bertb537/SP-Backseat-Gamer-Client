using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BackseatGamerClient
{
    public class Game: DataGridRow
    {
        private string user;
        public string User { get { return user; } set { user = value; } }

        private string map;
        public string Map { get { return map; } set { map = value; } }

        private string hero;
        public string Hero { get { return hero; } set { hero = value; } }

        private string eliminations;
        public string Eliminations { get { return eliminations; } set { eliminations = value; } }

        private string deaths;
        public string Deaths { get { return deaths; } set { deaths = value; } }

        private string result;
        public string Result { get { return result; } set { result = value; } }

        public Game(string _user, string _map, string _hero,
                string _eliminations, string _deaths, string _result)
        {
            user = _user;
            map = _map;
            hero = _hero;
            eliminations = _eliminations;
            deaths = _deaths;
            result = _result;
        }
    }
}
