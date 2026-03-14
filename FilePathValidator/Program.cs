using System;
using System.IO;
using System.Reflection.Metadata;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.
FilePathValidator fp = new FilePathValidator();
string[] allowedExtensions = { ".txt", ".csv" } ;
string path1 = "C:/Users/data/report.txt";
string path2 = "";
string path3 = "C:/Users/data/<report>.txt";
string path4 = new string('a', 300);

WriteLine("=== 경로 검증 오류 테스트 ===");
// path 1
try
{
    fp.ValidatePath(path1);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
// ArgumentExceptio이 가장 넓은 범주의 예외 이므로 가장 마지막에 catch해야함
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
try
{
    fp.ValidatePath(path2);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
// ArgumentExceptio이 가장 넓은 범주의 예외 이므로 가장 마지막에 catch해야함
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
try
{
    fp.ValidatePath(path3);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
// ArgumentExceptio이 가장 넓은 범주의 예외 이므로 가장 마지막에 catch해야함
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
try
{
    fp.ValidatePath(path4);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
// ArgumentExceptio이 가장 넓은 범주의 예외 이므로 가장 마지막에 catch해야함
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
//fp.ValidatePath(path1);
//fp.ValidateExtension(path1, allowedExtensions);
//// path 2
//fp.ValidatePath(path2);
//fp.ValidateExtension(path2, allowedExtensions);
//// path 3
//fp.ValidatePath(path3);
//fp.ValidateExtension(path3, allowedExtensions);
//// path 4
//fp.ValidatePath(path4);
//fp.ValidateExtension(path4, allowedExtensions);

WriteLine();

WriteLine("=== 확장자 검증 테스트 ===");
string path5 = "C:/Users/data/report.txt";
string path6 = "C:/Users/data/report.csv";
string path7 = "C:/Users/data/report.exe";
try
{
    fp.ValidateExtension(path5, allowedExtensions);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
// ArgumentExceptio이 가장 넓은 범주의 예외 이므로 가장 마지막에 catch해야함
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
try
{
    fp.ValidateExtension(path6, allowedExtensions);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}
try
{
    fp.ValidateExtension(path7, allowedExtensions);
}
catch (ArgumentNullException e)
{
    WriteLine($"[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
}
catch (ArgumentOutOfRangeException e)
{
    WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
}
catch (ArgumentException e)
{
    WriteLine("[Argument 오류] 경로에 금지 문자 '<'가 포함되어 있습니다.");
}