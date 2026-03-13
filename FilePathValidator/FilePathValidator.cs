using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
        
        
    }
    // 확장자 검증
    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        
        string extension = Path.GetExtension(path);
    }
}
