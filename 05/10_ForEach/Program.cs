// 5.2.5 foreach

// foreach 문을 사용하면 배열 또는 컬렉션을 순회하며 각 데이터 요소에
// 차례대로 접근할 수 있으며, 그 끝에 도달하면 자동으로 반복이 종료된다.

// foreach 문의 형식

// foreach (데이터_형식 변수명 in 배열_또는_컬렉션)
//     코드_또는_코드_블록;

// foreach 문은 in 키워드와 함께 사용한다.

namespace _10_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            // 0
            // 1
            // 2
            // 3
            // 4
        }
    }
}
