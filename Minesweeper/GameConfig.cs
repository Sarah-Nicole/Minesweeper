using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameConfig
    {
        public int SelectedLevel { get; set; }
        public int BombCount { get; set; }
        public int LifeCount { get; set; }
        public int BoardSize { get; set; }
    }
}
