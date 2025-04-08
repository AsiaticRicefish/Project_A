using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class Player // 게임 플레이어에 관한 설정
    {
        private int power;
        public int Power { get { return power; } set { power = value; } }

        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }
    }
}
