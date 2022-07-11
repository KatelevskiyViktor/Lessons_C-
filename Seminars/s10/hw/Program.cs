//My ugly version, try not go crazy =))

List<List<int>> groups = new List<List<int>>();
List<int> group = new List<int>();
int mark = 0;

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    foreach(var gr in groups){
            foreach(var g in gr){
                if(g == i)mark = 1;
            }
        }
       if(mark == 1)
       {
        mark = 0;
        continue;
       }
    
    group = new List<int>();
    group.Add(i);
    for (int j = i; j <= n; j++)
    {
        foreach(var gr in groups){
            foreach(var g in gr){
                if(g == j || g == i)mark = 1;
            }
        }
       if(mark == 1)
       {
        mark = 0;
        continue;
       }
       else{
            for (int k = 0; k < group.Count; k++)
                {
                        if(j % group[k] == 0){
                            
                            break;
                            }
                            foreach(var gr in group){
                                if(j % gr == 0)mark = 1;       
                                }
                        if (mark == 0){
                            group.Add(j);
                            break;
                        }
                        mark = 0;
                }
        }
       mark = 0;
    }
    groups.Add(group); 
}

for (int i = 0; i < groups.Count; i++)            
        {         
            Console.Write("Группа №" + (i+1) + ": ");    
                for (int j = 0; j < groups[i].Count; j++)
                    Console.Write(groups[i][j] + ", ");
                Console.WriteLine();
        }

//second version(not my)

// int n = InputNumbers("Введите число N: ");

// int[] tempArray = CreateArray(n);
// CreateRows(tempArray);

// void CreateRows(int[] arrayCheck)
// {
//   int[] arrayTemp = new int[arrayCheck.Length];
//   int m = 1;
//   int count = 0;
//   int tempNumber = 0;
//   int tempNumber2 = 0;
//   int tempSwitch = 0;
  
//   for (int i = 0; i < arrayCheck.Length; i++)
//   {
//     Array.Clear(arrayTemp);
//     count = 0;
//     if (arrayCheck[i] != 0)
//     {
//       arrayTemp[count] = arrayCheck[i];
//       tempNumber2 = arrayCheck[i];

//       for (int j = i; j < arrayCheck.Length; j++)
//       {
//         if (arrayCheck[j] % tempNumber2 != 0 || arrayCheck[j] / tempNumber2 == 1)
//         {
//           tempSwitch = 0;
//           tempNumber = arrayCheck[j];
//           for (int k = 0; k < count; k++)
//           {
//             if (tempNumber % arrayTemp[k] == 0) tempSwitch++;
//           }
//           if (tempSwitch == 0)
//           {
//             arrayTemp[count] = arrayCheck[j];
//             count++;
//             arrayCheck[j] = 0;
//           }
//         }
//       }
//       Console.WriteLine($"Группа {m++}: {PrintIntArray(arrayTemp)}");
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// int[] CreateArray(int n)
// {
//   int[] temp = new int[n];
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = i + 1;
//   }
//   return temp;
// }

// string PrintIntArray(int[] array)
// {
//   string result = string.Empty;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] != 0) result += $"{array[i],1} ";
//   }
//   return result;
// }           