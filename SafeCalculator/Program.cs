using System;
using static System.Console;


SafeCalculator calc = new SafeCalculator();

WriteLine("=== 테스트1: 정상 입력 ===");
calc.Divide("10", "2");
WriteLine();
WriteLine("=== 테스트2: 0으로 나누기 ===");
calc.Divide("2", "0");
WriteLine();
WriteLine("=== 테스트3: 잘못된 형식 ===");
calc.Divide("김", "경일");


