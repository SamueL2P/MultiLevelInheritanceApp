using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceApp.Models
{
    internal class BoardGame : Game
    {
        public int turn = 2;
        public string MovePiece()
        {
            return "The piece is being moved";
        }
    }
}
