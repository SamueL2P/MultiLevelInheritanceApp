using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceApp.Models
{
    internal class Chess : BoardGame
    {
        public string GiveCheck()
        {
            return "Giving Check";
        }
    }
}
