// ex1, ex2:
// void IntervalOfNumbers(int startInterval, int endInterval)
// {    int sum = 0;
//     if(startInterval < endInterval)
//     {
//         Console.Write($"Numbers of interval form {startInterval} to {endInterval} is: ");
//         for (int i = startInterval; i <= endInterval; i++)
//         {
//             sum += i;
//             Console.Write(i + ", ");
//         }
//         Console.WriteLine("Sum of this interval is: " + sum);
//     }
//     if(startInterval > endInterval)
//     {
//         Console.Write($"Numbers of interval form {endInterval} to {startInterval} is: ");
//         for (int i = startInterval; i >= endInterval; i--)
//         {
//             sum += i;
//             Console.Write(i + ", ");
//         }
//     }      
// }

// IntervalOfNumbers(startInterval: 4, endInterval: 8);

// ex3:
int Foo(int number, int argument)
{
    if(number == 0)return argument + 1;

    if(number > 0 && argument == 0)return Foo(number - 1, 1);
    
    if(number > 0 && argument > 0)return Foo(number - 1, Foo(number, argument - 1));

return 4;
}
    
Console.WriteLine(Foo(3, 2));



