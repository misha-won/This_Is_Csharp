using System;

// object 형식은 참조 형식이기 때문에 힙에 데이터를 할당한다.
// int 형식이나 double 형식은 값이기 때문에 스택에 데이터를 할당한다.
// 그렇다면 값 형식의 데이터를 object 형식 객체에 담을 경우, 어느 메모리에 데이터가 할당되는가?
namespace _12_BoxingUnboxing
// object 형식은 값 형식의 데이터를 힙에 할당하기 위한 '박싱(Boxing)' 기능을 제공한다.
// 이때 object 형식의 객체는 박싱된 값의 주소를 '참조'한다.
// 한편, '언박싱(Unboxing)'은 박싱된 값을 꺼내 값 형식 변수에 저장하는 과정을 일컫는다.
// 다시 말해 힙에 있던 값 형식 데이터를 값 형식 객체에 다시 할당(복사)하는 것이다.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;   // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b;         // b에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x;           // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
