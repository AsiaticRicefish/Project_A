using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*        제목을 입력하시오         *");
            Console.WriteLine("************************************");
            Console.WriteLine("");
            Console.WriteLine("계속하려면 아무키나 누르십시오.");

        }

        public override void Input()
        {
           Console.ReadKey(true); // 무슨 키를 눌렀는지 안보이도록 함
        }

        public override void Update()
        {

        }

        public override void Result()
        {
            Game.ChangeScene("Hospital");
        }

     
    }
}
