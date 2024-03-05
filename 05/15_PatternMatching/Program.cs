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

    #region 5.4.6 Logical Pattern Ex Class
    class OrderItem
    {
        public int Amount { get; set; }
        public int Price { get; set; }
    }
    #endregion 5.4.6 Logical Pattern Ex Class

    #region 5.4.8 Positional Pattern Ex2 Struct
    struct Audience
    {
        public bool IsCitizen { get; init; }
        public int Age { get; init; }

        public Audience(bool isCitizen, int age)
        {
            IsCitizen = isCitizen;
            Age = age;
        }

        public void Deconstruct(out bool isCitizen, out int age)
        {
            isCitizen = IsCitizen;
            age = Age;
        }
    }
    #endregion 5.4.8 Positional Pattern Ex2 Struct

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
            >= 80 and < 90 => "B",
            _ => "A"
        };

        #endregion 5.4.5 Relational Pattern

        #region 5.4.6 Logical Pattern Ex Method
        static double GetPrice(OrderItem orderItem) => orderItem switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 }
                => 0.0,
            OrderItem { Amount: >= 100 } or OrderItem { Price: >= 10_000 }
                => orderItem.Amount * orderItem.Price * 0.8,
            not OrderItem { Amount: < 100 }
                => orderItem.Amount * orderItem.Price * 0.9,
            _ => orderItem.Amount * orderItem.Price
        };
        #endregion 5.4.6 Logical Pattern Ex Method

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

            #region 5.4.6 Logical Pattern

            // 패턴과 패턴을 패턴 논리 연산자(and(결합), or, not)로 조합해서
            // 하나의 논리 패턴으로 만들 수 있다.

            // Ex. 프로퍼티 패턴과 관계 패턴을 조합한 논리 패턴 매칭

            Console.WriteLine(GetPrice(new OrderItem() { Amount = 0, Price = 10_000 }));
            Console.WriteLine(GetPrice(new OrderItem() { Amount = 100, Price = 10_000 }));
            Console.WriteLine(GetPrice(new OrderItem() { Amount = 100, Price = 9_000 }));
            Console.WriteLine(GetPrice(new OrderItem() { Amount = 1, Price = 1_000 }));

            #endregion 5.4.6 Logical Pattern

            #region 5.4.7 Parenthesized Pattern

            // 괄호 패턴은 소괄호 ()로 패턴을 감싼다.
            // 보통 논리 패턴으로 여러 패턴을 조합한 뒤 이를 새로운 패턴으로 만드는 경우에 사용한다.

            object age = 30;

            if (age is (int and > 19))
                Console.WriteLine("Major");

            #endregion 5.4.7 Parenthesized Pattern

            #region 5.4.8 Positional Pattern

            // 위치 패턴
            // - 식의 결과를 분해(Deconstruct)하고, 분해된 값들이 내장된 복수의 패턴과 일치하는지
            //   검사한다.
            // - 안에 내장되는 패턴에는 형식 패턴, 상수 패턴 등 어떤 패턴이든 올 수 있다.

            // ※ 분해된 값들과 내장된 패턴의 개수, 순서가 일치해야 한다.

            // Ex1. 튜플 변수의 위치 패턴 매칭

            Tuple<string, int> itemPrice = new Tuple<string, int>("espresso", 3000);

            if (itemPrice is ("espresso", < 5000))
            {
                Console.WriteLine("The coffee is affordable");
            }

            // 위의 예제에서는 string과 int 요소로 이루어진 튜플 itemPrice를 상수 패턴("espresso")과
            // 관계 패턴(< 5000)으로 이루어진 위치 패턴으로 매칭하고 있다.

            // Ex2. switch 식 위치 패턴 매칭

            var CalculateFee2 = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400
            };

            var a1 = new Audience(true, 10);
            Console.WriteLine(
                $"내국인: {a1.IsCitizen} 나이: {a1.Age} 요금: {CalculateFee2(a1)}");

            var a2 = new Audience(false, 33);
            Console.WriteLine(
                $"내국인: {a2.IsCitizen} 나이: {a2.Age} 요금: {CalculateFee2(a2)}");

            #endregion 5.4.8 Positional Pattern

            #region 5.4.9 var Pattern

            // var 패턴
            // - null을 포함한 모든 식의 패턴 매칭을 성공시키고, 그 식의 결과를 변수에 할당한다.
            // - 어떤 식의 결과를 임시 변수에 할당한 뒤 추가적인 연산을 수행하고자 할 때 유용하다.

            // Ex. 진급/유급 평가

            // 모든 과목이 60점 이상이고, 평균도 60점 이상인 경우에만 Pass
            var IsPassed =
                (int[] scores) => scores.Sum() / scores.Length is var average
                && Array.TrueForAll(scores, (score) => score >= 60)
                && average >= 60;

            int[] scores1 = { 90, 80, 60, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores1)}: Pass:{IsPassed(scores1)}");

            int[] scores2 = { 90, 80, 59, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores2)}: Pass:{IsPassed(scores2)}");

            /* 결과
            90,80,70,80,70: Pass:True
            90,80,59,80,70: Pass:False
            */

            #endregion 5.4.9 var Pattern

            #region 5.4.10 Discard Pattern

            // 무시 패턴
            // - var 패턴처럼 모든 식과의 패턴 일치 검사를 성공시킨다.
            // - var 패턴과 달리 is 식에서는 사용할 수 없고, switch 식에서만 사용할 수 있다.
            // - '모든 식'을 매칭할 수 있기 때문에 switch 문의 default 케이스와 비슷한 용도로
            //   사용하면 된다.
            // - _ 기호를 이용한다.

            // Ex. 문자열 리터럴에 대한 상수 패턴 매칭 속의 무시 패턴 매칭

            var GetCountryCode2 = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException("Not Supported Code") // 무시 패턴 매칭
                // 세 개의 상수 "KR", "US", "UK"와 일치하지 않는 모든 식의 값을
                // _에 매칭시켜 ArgumentException을 던진다.
            };

            Console.WriteLine(GetCountryCode2("KR"));
            Console.WriteLine(GetCountryCode2("US"));
            Console.WriteLine(GetCountryCode2("UK"));
            Console.WriteLine(GetCountryCode2("JP"));

            #endregion 5.4.10 Discard Pattern

            #region 5.4.11 List Pattern

            // 목록 패턴은 배열이나 리스트(List)에서 패턴의 시퀀스가 일치하는지를 검사한다.
            // 패턴의 시퀀스는 대괄호의 [와 ] 사이에 패턴의 목록을 입력해서 만든다.

            var match = (int[] array) => array is [int, > 10, _];

            Console.WriteLine(match(new int[] { 1, 100, 3 }));      // True
            Console.WriteLine(match(new int[] { 100, 10, 999 }));   // False

            // 범위 패턴 ..을 함께 사용하면 식으로 입력되는 배열이나 리스트의 길이에 관계없이
            // 패턴 매칭을 수행할 수 있다.

            var match2 = (int[] array) => array is [int, > 10, ..];

            Console.WriteLine(match2(new int[] { 1, 100, 101, 102, 103, 104 }));    // True
            Console.WriteLine(match2(new int[] { 100, 10, 999 }));                  // False

            // 목록 패턴은 다량의 데이터를 처리할 때 매우 유용하다.
            // 특히 파일이나 데이터베이스에서 레코드를 읽어 처리하는 문제에 적합하다.

            var GetStatistics = (List<object[]> records) =>
            {
                var statistics = new Dictionary<string, int>();

                foreach (var record in records)
                {
                    var (contentType, contentViews) = record switch
                    {
                        [_, "COMEDY", .., var views] => ("COMEDY", views),
                        [_, "SF", .., var views] => ("SF", views),
                        [_, "ACTION", .., var views] => ("ACTION", views),
                        [_, .., var amount] => ("ETC", amount),
                        _ => ("ETC", 0)
                    };

                    if (statistics.ContainsKey(contentType))
                        statistics[contentType] += (int)contentViews;
                    else
                        statistics.Add(contentType, (int)contentViews);
                }

                return statistics;
            };

            List<object[]> MovieRecords = new List<object[]>()
            {
                new object[] { 0, "COMEDY", "Spy", 2015, 10_000 },
                new object[] { 1, "COMEDY", "Scary Movie", 20_000 },
                new object[] { 2, "SF", "Avengers: Infinite War", 100_000 },
                new object[] { 3, "COMEDY", "극한직업", 25_000 },
                new object[] { 4, "SF", "Star Wars: A New Hope", 200_000 },
                new object[] { 5, "ACTION", "Fast & Furious", 80_000 },
                new object[] { 6, "DRAMA", "Notting Hill", 1_000 }
            };

            var statistics = GetStatistics(MovieRecords);

            foreach (var s in statistics)
                Console.WriteLine($"{s.Key}: {s.Value}");

            /* 결과:
            COMEDY: 55000
            SF: 300000
            ACTION: 80000
            ETC: 1000
            */

            #endregion 5.4.11 List Pattern
        }
    }
}
