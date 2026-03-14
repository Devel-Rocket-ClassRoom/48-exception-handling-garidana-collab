using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;



class FilePathValidator
{
    // 경로 검증
    public void ValidatePath(string path)
    {
        // 예외처리의 순서도 중요
        // 세세한 검증부터 광범위 검증순으로 예외 처리
        if (path == null || path == string.Empty)
        {
            throw new ArgumentNullException();
        }
        char[] forbiddenchars = { '<', '>', '|', '"', '*', '?' };
        foreach (char c in forbiddenchars)
        {
            if (path.Contains(c))
            {
                throw new ArgumentException($"경로에 금지문자 '{c}'가 포함되어 있습니다.");
            }

        }
        if (path.Length > 260)
        {
            throw new ArgumentOutOfRangeException("경로 길이가 260자를 초과합니다.");
        }
        WriteLine($"경로가 유효합니다: {path}");
        
    }
    // 확장자 검증
    // . 뒤의 텍스트를 검증
    // string 메서드 사용
    // 혀용된 확장자 배열을 매개변수로 받음 (매개변수 path의 검증용)
    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        int dotIndex = path.LastIndexOf('.'); // 마지막 점 위치의 인덱스
        string extension = path.Substring(dotIndex);  // 그 인덱스부터 끝까지 자르기
        bool IsFound = false;

        foreach (string ex in allowedExtensions)
        {
            if (ex == extension)
            {
                IsFound = true;
                
                break;
            }
        }
        if (!IsFound)
        {
            throw new ArgumentException($"허용되지 않은 확장자입니다: {extension}");
        }
        WriteLine($"확장자가 유효합니다: {extension}");
    }
}
