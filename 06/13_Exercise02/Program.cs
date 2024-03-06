// 연습문제 02

// 다음 코드에서 Mean() 메서드를 실행한 후 mean의 값이 3이 아니라 0인 원인은 무엇이며,
// 이를 바로잡으려면 다음 코드에서 어떤 부분을 고쳐야 할까요?

// 정답 : 참조에 의한 매개변수나 출력 전용 매개변수를 사용하지 않고 Mean() 메서드에 변수 mean의
// 데이터만 복사해서 전달하면, Mean() 메서드 안에서 일어난 변화가 메서드 밖의 원본 변수 mean에
// 아무런 영향도 미치지 못한다. 이와 같은 코드에는 참조에 의한 매개변수(ref)보다는 출력 전용
// 매개변수(out)를 사용하는 것이 더 적절하다.

namespace _13_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double mean = 0;
            // 출력 전용 매개변수는 메서드를 호출할 때 매개변수 목록 안에서 즉석으로 선언해도 된다.
            // 그러므로 위의 double mean = 0;처럼 굳이 먼저 선언해 둘 필요가 없다.

            // Mean(1, 2, 3, 4, 5, mean);
            // 호출부의 매개변수 앞에 out 키워드를 붙인다.
            Mean(1, 2, 3, 4, 5, out double mean);

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
            // double a, double b, double c, double d, double e, double mean)
            // 선언부의 매개변수 앞에 out 키워드를 붙인다.
            double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
