using System; //
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____Practice //namespace는 클래스를 특정 키워드로 묶어주는 역할
                        //namespace도 using처럼 구현되어있음 -> 즉 내가 만드는 클래스 라이브러리
{
    public class Program //public생략해도 자동으로 public class로 인식
    {
        static void Main()//svm : 자동완성 키워드 //(string[] args) 생략가능 // 뒤에 가서 용도공부
        {
            // Console.OutputeEncoding = system.Text.Encoding.UTF8 터미널로 돌릴 떄 인코딩문제 해결
            int number = 72;
            int number2 = 4;
            Console.WriteLine("Nunber = {0} {1}", number, number2); //cw자동완성 키워드
            //System.Console.WriteLine("Nunber = {0} {1}", number, number2); using system 네임스페이스 선언해주면 system안써도됨
        }
    }
}


