using System;
using System.Globalization;
using static System.Console;

namespace _30_StringFormatDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 날짜 및 시간 서식화

            DateTime dt = new DateTime(203, 03, 04, 23, 18, 22);
            // 2023년 03월 04일 23시 18분 22초

            WriteLine("{0}", dt);
            // 국가 및 지역 설정에 따라 다른 결과 출력

            // y : 연도 (yy : 두 자릿수 연도, yyyy : 네 자릿수 연도)
            // M : 월 (M : 한 자릿수, MM : 두 자릿수)
            // d : 일 (d : 한 자릿수, dd : 두 자릿수)
            // h : 시(1~12) (h : 한 자릿수, hh : 두 자릿수)
            // H : 시(0~23) (H : 한 자릿수, HH : 두 자릿수)
            // m : 분 (m : 한 자릿수, mm : 두 자릿수)
            // s : 초 (s : 한 자릿수, ss : 두 자릿수)
            // tt : 오전/오후
            // ddd : 요일 (ddd : 약식 요일, dddd : 전체 요일)

            // 12시간 형식: 2023-03-04 오후 11:18:22 (토)
            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);

            // 24시간 형식: 2023-03-04 23:18:22 (토요일)
            WriteLine("12시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            // CultureInfo : 문화권 정보를 나타내는 클래스
            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();

            // 2023-03-04 오후 11:18:22 (토)
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            // 2023-03-04 23:18:22 (토요일)
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            // 2023-03-04 오후 11:18:22
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();

            // 2023-03-04 PM 11:18:22 (Sat)
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            // 2023-03-04 23:18:22 (Saturday)
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            // 2023-03-04 11:18:22 PM
            WriteLine(dt.ToString(ciEn));
        }
    }
}
