﻿// 5.2.3 for

// for 문은 while 문처럼 '조건식이 참(true)인 동안' 코드를 반복 실행하지만,
// while 문보다는 반복을 더 정교하게 제어할 수 있다는 차이가 있다.

// for 문의 형식

// for (초기화식; 조건식; 반복식)
//     반복_실행할_코드;

// 초기화식 : 반복을 실행하기 전에 가장 먼저, 딱 한 번만 실행되는 코드이다.
//            for 반복문에서 사용할 변수 등을 이곳에서 초기화한다.

// 조건식 : 반복을 계속 수행할지를 결정하는 식이다. 이 조건식의 결과가 false가 되면 반복을 중단한다.

// 반복식 : 반복이 끝날 때마다 실행된다. 주로 여기서 조건식에서 사용하는 변수의 값을 조정한다.
//          반복식이 실행된 후에는 조건식이 실행되어 반복을 계속 진행할지를 판단한다.

// 임의의 횟수만큼 반복을 수행하기에는 while 문보다 for 문이 편리하다.

namespace _08_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // 0
            // 1
            // 2
            // 3
            // 4
        }
    }
}
