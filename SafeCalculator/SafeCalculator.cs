using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
class SafeCalculator
{
    public void Divide(string num1, string num2)
    {
        // Divide 메서드 내용을 try안에 넣고, 발생할 가능성이 있는
        // 예외들을 catch안에 넣어서 처리
        try
        {
            int Num1 = int.Parse(num1);
            int Num2 = int.Parse(num2);
            WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
        }
        catch (DivideByZeroException e)
        {
            WriteLine($"0으로 나눌 수 없습니다.");
        }
        catch (FormatException e)
        {
            WriteLine("올바른 숫자를 입력하세요");
        }
        finally
        {
            WriteLine("계산기를 종료합니다.");
        }
    }


}
