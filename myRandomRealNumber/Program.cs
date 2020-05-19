using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRandomRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num=random.Next(10,100);

            while(true)
            {
                Console.Write("숫자를 입력해주세요: ");
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum > num)
                {
                    Console.WriteLine(inputNum + "보다는 작은 숫자입니다.");
                }
                else if(inputNum<num)
                {
                    Console.WriteLine(inputNum + "보다는 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
