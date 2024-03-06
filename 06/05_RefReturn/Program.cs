// 6.5 메서드의 결과를 참조로 반환하기

// 참조 반환값(ref return)
// 메서드의 호출자로 하여금 반환받은 결과를 참조로 다룰 수 있도록 한다.

namespace _05_RefReturn
{
    // 참조로 반환하는 메서드 선언 방법
#if Example
    class SomeClass
    {
        int SomeValue = 10;
 
        public ref int SomeMethod() // ref 키워드로 메서드를 한정한다.
        {
            // 이런 일 저런 일
            return ref SomeValue;
            // return 문을 사용할 때 ref 키워드를 반환할 필드나 객체 앞에 붙여 준다.
        }
    }
#endif

    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
#if Example
            SomeClass obj = new SomeClass();
            int result = obj.SomeMethod();
            // 값으로 반환받고자 할 때는 여느 때와 다름없이 메서드를 호출하면 된다.
            ref int result2 = ref obj.SomeMethod(); 
            // 메서드의 반환 결과를 호출자가 참조로 넘겨받고 싶다면
            // 결과를 담는 지역 변수와 호출할 메서드의 이름 앞에 ref 키워드를 위치시켜야 한다.

            // 참조 지역 변수(ref local) : 메서드에서 참조로 반환받은 결과를 담는 지역 변수
#endif

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            // ref_local_price를 수정하면 carrot.price의 내용도 바뀐다.
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            // Price : 100
            // Ref Local Price : 100
            // Normal Local Price : 100
            // Price : 200
            // Ref Local Price : 200
            // Normal Local Price : 100
        }
    }
}
