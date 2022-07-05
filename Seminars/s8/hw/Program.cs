//dear teacher, uncomment exercise that you want to check all of them mark like:ex1..n!!!


// ex1:
// int[,] myIntArray = new int[4, 4];

// ex2:
// int[,] myIntArray = new int[3, 4];

// ex3:
// int[,] myIntArray = new int[2, 3];
// int[,] myIntArray2 = new int[3, 2];

// ex4:
// int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
//                                        { { 7, 8, 9 }, { 10, 11, 12 } } };
// for (int i = 0; i < array3D.GetLength(0);i++)
// {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//         for (int k = 0; k < array3D.GetLength(2); k++)
//         {
//             Console.Write(array3D[i,j,k] + ", ");
//         }
//     }
//     Console.WriteLine();
// }


// ex5:
// int[,] circleArr = new int[4, 4];
// int Count = 1;
// int i = 0;
// int jl = 0;
// int kl = 0;
// int gl = 0;
// int ll = 0;
// 
// for (int j = 0; j < circleArr.GetLength(1); j++)
// {
//     circleArr[i, j] = Count;
//     Count++;
//     jl = j;
// }
//    
// for (int k = 1; k < 4; k++)
// {
//     circleArr[k, jl] = Count;
//     Count++;
//     kl = k;
// }
// 
// for (int g = 2; g >= 0; g--)
// {
//     circleArr[kl, g] = Count;
//     Count++;
//     gl = g;
// }
//                 
// for (int l = 3; l >= 1; l--)
// {
//     circleArr[l, gl] = Count;
//     Count++;
//     ll = l;
// }
// 
// for (int p = 1; p < 3; p++)
// {
//     circleArr[ll, p] = Count;
//     Count++;  
// }
// 
// circleArr[2, 2] = Count++;
// circleArr[2, 1] = Count++;
// PrintIntArray(circleArr);



int[,] CreateIntArray(int[,] myArr){
    Random rnd = new Random();
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            myArr[i, j] = rnd.Next(1, 99);
        }
    }
    Console.WriteLine();
    Console.WriteLine("Before: ");
    PrintIntArray(myArr);
    
    return myArr;
}


// ex1:
// int[,] SortStringsArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         List<int> tempList = new List<int>();
// 
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             tempList.Add(arr[i,j]);
//         }
// 
//         tempList.Sort();
//         tempList.Reverse();
// 
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             arr[i,k] = tempList[k];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine("After: ");
//     return arr;
// }

void PrintIntArray(int[,] arr){
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}


// ex2:
// int SmallestSum(int[,] arr)
// {
//     int smallestString = 0;
//     List<int> tempList = new List<int>();
// 
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int tempSum = 0;
// 
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             tempSum += arr[i, j];
//         }
// 
//         tempList.Add(tempSum);
//     }
// 
//     for (int i = 0; i < tempList.Count; i++)
//     {
//         Console.WriteLine("String №" + i + " have sum: " + tempList[i]);
//     }
//     Console.WriteLine();
//     return tempList.IndexOf(tempList.Min());
// }


// ex3:
// void MultiTwoNum(int[,] arrFirst, int[,] arrSecond)
// {
// 
//     List<int> multiTwoNum = new List<int>();
// 
//     for (int i = 0; i < arrFirst.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrFirst.GetLength(1); j++)
//         {
//             multiTwoNum.Add(arrFirst[i,j] * arrSecond[j,i]);
//         }
//     }
// 
//     for (int i = 0; i < multiTwoNum.Count; i++)
//     {
//         Console.WriteLine("Multiplication №" + i + " " + multiTwoNum[i]);
//     }
// }



// ex1:
// PrintIntArray(SortStringsArray(CreateIntArray(myIntArray)));

// ex2:
// Console.WriteLine("Smallest sum string have index: " 
//                     + SmallestSum(CreateIntArray(myIntArray)));
// Console.WriteLine();

// ex3:
// MultiTwoNum(CreateIntArray(myIntArray), 
//             CreateIntArray(myIntArray2));