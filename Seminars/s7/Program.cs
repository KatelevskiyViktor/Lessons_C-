// ex1-2:
// double[,] myArray = new double[3, 4];
// 
// double[,] CreateArray(double[,] myArr){
//     Random rnd = new Random();
//     for (int i = 0; i < myArr.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArr.GetLength(1); j++)
//         {
//             myArr[i, j] = Convert.ToDouble(rnd.Next(-1000, 1000) / 10.0);  
//         }
//     }
//     return myArr;
// }
//  
// void PrintArray(double[,] arr){
//    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//        for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// 
// void SearchElement(double[,] arr)
// {
//     PrintArray(arr);
//     while(true){
//         try{
//             Console.WriteLine("Enter 1-3 to first position in array  or 'q', to exit:");
//             var value = Console.ReadLine();
//             if(value == "q")break;
//             int firstPosition = int.Parse(value);
// 
//             Console.WriteLine("Enter 1-4 to second position in array:");
//             int secondPosition = int.Parse(Console.ReadLine());
// 
//             if(firstPosition > 0 && firstPosition < 4 && secondPosition > 0 && secondPosition < 5)
//             {
//                 Console.WriteLine("Your number is: " + arr[firstPosition - 1, secondPosition - 1]);
//             }
//             else Console.WriteLine("Out of size array! Try again, please");
//         }catch{
//             Console.WriteLine("You enter not a number, please try again.");
//             continue;
//         }
//         Console.WriteLine();
//     }  
// }
// 
// SearchElement(CreateArray(myArray));


// ex3:
int[,] myIntArray = new int[3, 4];

void PrintIntArray(int[,] arr){
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateIntArray(int[,] myArr){
    Random rnd = new Random();
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i, j] = rnd.Next(1, 20);
        }
    }
    PrintIntArray(myArr);
    return myArr;
}

void Average(int[,] arr){
    double average = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            average += arr[j, i];
        }
        Console.WriteLine($"Column {i + 1} average is: " + Math.Round(average /= 3, 1));
    }
}

Average(CreateIntArray(myIntArray));