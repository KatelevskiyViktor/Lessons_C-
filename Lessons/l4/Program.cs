// ex1:
// string[,] table = new string[2, 5];
// 
// table[1, 2] = "word";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }


// ex2:
// void PrintArray(int[,] matr){
//    
//     for (int i = 0; i < 3; i++) // same: for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < 4; j++)// same: for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// 
// void FillArray(int[,] matr){
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// 
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// ex3:
// double Factorial(int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// 
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }


// ex4:
// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// 
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"f({i}): " + Fibonacci(i));
// }
