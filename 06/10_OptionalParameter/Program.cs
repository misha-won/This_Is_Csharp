// 6.10 선택적 인수(Optional Argument)
// 메서드의 매개변수는 기본값을 가질 수 있다. 즉, 매개변수를 특정 값으로 초기화하듯 메서드를 선언할
// 수 있다. 이때 기본값을 가진 매개변수는 필요에 따라 인수를 할당하거나 할당하지 않을 수 있다.

// 선택적 인수의 특징
// 항상 필수 인수 뒤에 와야 한다(필수 인수가 없는 경우는 예외로 둔다).

// 선택적 인수의 장단점
// 장점 : 메서드의 사용자에게 신경 스고 싶지 않은 인수를 염두에 두지 않도록 편의를 제공한다.
// 단점 : 어느 매개변수에 어느 인수를 할당했는지 모호해진다.
// 보완 : 명명된 인수를 함께 사용하면 모호함을 줄일 수 있다.

namespace _10_OptionalParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");

            // Name: 중근, Phone: 
            // Name: 관순, Phone: 010-123-1234
            // Name: 봉길, Phone: 
            // Name: 동주, Phone: 010-789-7890
        }
    }
}
