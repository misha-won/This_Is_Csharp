// 6.9 명명된 인수
// 메서드를 호출할 때 매개변수 목록 중 어느 매개변수에 데이터를 할당할지 지정하는 것은 '순서'이다.
// 그와 달리, 명명된 인수(Named Argument)는 메서드를 호출할 때 인수의 이름에 근거해서 데이터를
// 할당할 수 있게 한다.

// 명명된 인수를 사용하기 위해서는 메서드 호출 시 인수의 이름 뒤에 콜론(:)을 붙인 다음 그 뒤에
// 할당할 데이터를 넣어 주면 된다.

// 명명된 인수는 코드의 가독성을 높여 준다.
// 인수가 너무 많아 어느 매개변수에 어느 인수를 할당하고 있는지 분간이 어려운 경우에 특히 유용하다.

namespace _09_NamedParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");

            // Name: 박찬호, Phone: 010-123-1234
            // Name: 박지성, Phone: 010-987-9876
            // Name: 박세리, Phone: 010-222-2222
            // Name: 박상현, Phone: 010-567-5678
        }
    }
}
