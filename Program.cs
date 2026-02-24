int result;

Calculate(out result);

Console.WriteLine($"결과: {result}");

void Calculate(out int value)
{
    value = 1234;  // 반드시 값을 할당해야 함
    Console.WriteLine($"메서드 내부: {value}");
}