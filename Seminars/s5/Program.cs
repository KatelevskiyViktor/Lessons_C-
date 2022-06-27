// Ex1:
// 
// int[] CreateArr(){
//     int[] arr = new int[4];
//     Random rnd = new Random();
//     for (int i = 0; i < 4; i++)
//     {
//         arr[i] = rnd.Next(1, 999);
//     }
// 
//     return arr;
// }
// 
// void CountingEvenNumbers(int[] arr){
//     int EvNumCount = 0;
//     for (int i = 0; i < 4; i++)
//     {
//         if(arr[i] % 2 == 0)EvNumCount++;
//     }
//     Console.Write("Quantity of even numbers in array: " + EvNumCount);
// }
// 
// void ViewArr(int[] arr){
//     Console.Write("Arr is: ");
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine();
// }
// 
// int[] arr = CreateArr();
// ViewArr(arr);
// CountingEvenNumbers(arr);



// Ex2:
// 
// int[] CreateArr(){
//     int[] arr = new int[4];
//     Random rnd = new Random();
//     for (int i = 0; i < 4; i++)
//     {
//         arr[i] = rnd.Next(minValue: 0, 100);
//     }
// 
//     return arr;
// }
// 
// void CountingQuantityOddIndexNumbers(int[] arr){
//     int QOddNumCount = 0;
//     for (int i = 0; i < 4; i++)
//     {
//         if((i+1) % 2 == 0)QOddNumCount += arr[i];
//     }
//     Console.Write("Quantity of odd numbers in array: " + QOddNumCount);
// }
// 
// void ViewArr(int[] arr){
//     Console.Write("Arr is: ");
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine();
// }
// 
// int[] arr = CreateArr();
// ViewArr(arr);
// CountingQuantityOddIndexNumbers(arr);


// Ex3:
double[] CreateArr()
{
    double[] arr = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < 5; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(-1000, 1000) / 10.0);
    }

    return arr;
}

void ViewArr(double[] arr)
{
    Console.Write("Arr is: ");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine();
}

void MinMaxDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < 5; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    Console.WriteLine($"Difference between Max - {max} and Min - {min} num in arr = {max - min}");
}

double[] arr = CreateArr();
ViewArr(arr);
MinMaxDiff(arr);