// 5.4 패턴 매칭(Pattern Matching)
// 어떤 식(Expression)이 특정 패턴(Pattern) 혹은 형태와 일치(Matching)하는지 검사한다.
// 패턴 매칭을 이용하면 장황하고 거추장스러운 분기문을 간결하고 읽기 쉬운 코드로 대체할 수 있다.

// 식(Expression) ---> 패턴 매칭 ---> 결과(bool)

// 리터럴과 상수, 변수는 연산자 없이 식이 될 수 있다.

// '어떤 식이 특정 패턴과 일치'한다는 것은 무슨 의미인가?
// '식의 패턴'이라는 말은 '식 결과의 패턴'이라는 말과 같다.

// C#이 지원하는 패턴의 종류
// - 선언 패턴
// - 형식 패턴
// - 상수 패턴
// - 프로퍼티 패턴
// - 관계 패턴
// - 논리 패턴
// - 괄호 패턴
// - 위치 패턴
// - var 패턴
// - 무시 패턴
// - 목록 패턴

namespace _15_PatternMatching
{
    #region 5.4.2 Type Pattern Ex2 Classes
    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }
    #endregion 5.4.2 Type Pattern Ex2 Classes

    #region 5.4.4 Property Pattern Ex Class
    class Car
    {
        public string? Model { get; set; }
        public DateTime ProducedAt { get; set; }
    }
    #endregion 5.4.4 Property Pattern Ex Class

    internal class Program
    {
        #region 5.4.2 Type Pattern Ex2 Method
        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException(
                    $"Prohibited age : {visitor.GetType()}", nameof(visitor))
            };
        }
        #endregion 5.4.2 Type Pattern Ex2 Method

        #region 5.4.4 Property Pattern Ex Methods
        static string GetNickname(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
                $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";
            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
                return GenerateMessage(car, "Fastback");
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMessage(car, "Cobra II");
            else
                return GenerateMessage(car, "Unknown");
        }

        // VITAMIN QUIZ 5-1
        // GetNickname() 메서드를 is 연산자 대신 switch 식을 이용해서 다시 구현해 보세요.
        static string GetNickname2(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
                $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";
            switch (car)
            {
                case Car { Model: "Mustang", ProducedAt.Year: 1967 }:
                    return GenerateMessage(car, "FastBack");
                case Car { Model: "Mustang", ProducedAt.Year: 1976 }:
                    return GenerateMessage(car, "Cobra II");
                default:
                    return GenerateMessage(car, "Unknown");
            }
        }
        #endregion 5.4.4 Property Pattern Ex Methods

        #region 5.4.5 Relational Pattern

        // 관계 패턴 매칭
        // 관계 연산자(>, >=, ==, !=, <, <=)를 이용하여 입력받은 식을 상수와 비교한다.

        static bool IsPassed(double score) => score switch
        {
            < 60 => false,
            _ => true
        };

        static string GetGrade(double score) => score switch
        {
            < 60 => "F",
            >= 60 and < 70 => "D",
            >= 70 and < 80 => "C",
            // 
        };

        #endregion 5.4.5 Relational Pattern

        static void Main(string[] args)
        {
            #region 5.4.1 Declaration Pattern

            // 선언 패턴은 다음 두 가지를 수행한다.
            // 1. 식이 주어진 형식과 일치하는지 테스트
            // 2. 테스트가 성공하면 식을 주어진 형식으로 변환

            object foo = 23;
            if (foo is int bar) // 1. foo가 int인 경우 2. foo를 int 형식으로 변환하여 bar에 할당한다.
            {
                Console.WriteLine(bar);
            }

            // foo is int가 true를 반환하는 경우, bar 변수가 if 블록 안에 생성되고 23이 출력된다.
            // foo is int가 false를 반환하는 경우, bar 변수는 생성되지도 출력되지도 않는다.

            #endregion 5.4.1 Declaration Pattern

            #region 5.4.2 Type Pattern

            // 형식 패턴은 변수 생성 없이 형식 일치 여부만 테스트한다.
            // C# 9.0에서 더 간략한 형식 패턴 매칭을 지원하기 위해 도입되었다.

            // Ex1. 선언 패턴의 변형
            object foo2 = 23;
            if (foo2 is int)
            {
                Console.WriteLine(foo2);
            }
            
            // Ex2. 요금 계산
            Console.WriteLine($"Fee for a senior : {CalculateFee(new Senior())}");
            Console.WriteLine($"Fee for an adult : {CalculateFee(new Adult())}");
            Console.WriteLine($"Fee for an underage : {CalculateFee(new Underage())}");
            Console.WriteLine(
                $"Fee for a preschooler : {CalculateFee(new Preschooler())}");

            #endregion 5.4.2 Type Pattern

            #region 5.4.3 Constant Pattern

            // 상수 패턴
            // - 식이 특정 상수와 일치하는지를 검사한다.
            // - 가장 많이 사용하는 패턴이다.
            // - 정수 리터럴과 문자열 리터럴뿐 아니라 null과 enum 등 모든 상수와 매칭할 수 있다.

            // Ex1. 문자열 리터럴에 대한 상수 패턴 매칭

            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException("Not Supported Code")
            };

            Console.WriteLine(GetCountryCode("KR"));
            Console.WriteLine(GetCountryCode("US"));
            Console.WriteLine(GetCountryCode("UK"));
            Console.WriteLine(GetCountryCode("JP"));

            // Ex2. 객체가 null인지 확인하기

            object? obj = null;

            if (obj is null)        // obj == null
            {

            }

            if (obj is not null)    // obj != null
            {

            }

            #endregion 5.4.3 Constant Pattern

            #region 5.4.4 Property Pattern

            // 프로퍼티 패턴
            // - 식의 속성이나 필드가 패턴과 일치하는지 검사한다(프로퍼티는 9장에서 자세히 다룬다).
            // - 입력된 식이 int, double 같은 기본 데이터 형식이 아닌 경우에 특히 유용하게 사용한다.

            // Ex. 연도별 머스탱 모델명 찾기

            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));

            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 6, 7) }));

            Console.WriteLine(
                GetNickname2(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(2099, 12, 25) }));

            #endregion 5.4.4 Property Pattern

            
        }
    }
}
