// Ex1
// void Method1(){
//     Console.WriteLine("Author ...");
// }
// 
// Method1();


// Ex2:
// void Method2(string str){
//     Console.WriteLine(str);
// }
// 
// Method2("Hi!");


// Ex3:
// void Method3(string str, int count){
//     int i = 0;
//     while(i < count){
//         Console.WriteLine(str);
//         i++;
//     }
// }
// 
// Method3("Hi!", 4);


// Ex4:
// int Method4(){
//     return DateTime.Now.Year;
// }
// 
// int year = Method4();
// Console.WriteLine(year);


// Ex5:
// string Method5(int count, string str){
// 
//     int i = 0;
//     string result = String.Empty;
//     while(i < count){
//         result += str;
//         i++;
//     }
//     return result;
// }
// 
// string res = Method5(10, "Hi! ");
// Console.WriteLine(res);


// Ex6:
// string Method6(int count, string str){
// 
//     string result = String.Empty;
// 
//     for(int i = 0;i < count; i++){
//         result += str;
//     }
// 
//     return result;
// }
// 
// string res = Method6(10, "Hi! ");
// Console.WriteLine(res);


// ex7:
// void Method7(){
// 
//     for(int i = 2; i <= 10; i++){
//         for(int j = 2; j <= 10; j++){
//             Console.WriteLine($"{i} x {j} = {i * j}");
//         }
//         Console.WriteLine();
//     }
// 
// }
// 
// Method7();


// ex8:
// string str = "Идейные соображения - высшего порядка, а также дальнейшее"
// + " развитие различных форм деятельности требуют  - от нас анализа дальнейших"
// + " направлений - развития. Идейные соображения высшего порядка, а также" 
// + " укрепление и развитие структуры требуют определения и уточнения "
// + "направлений прогрессивного развития.";
// 
// string Replace(string str, char oldValue, char newValue){
// 
//     string result = String.Empty;
// 
//     int length = str.Length;
// 
//     for(int i = 0; i < length; i++)
//     {
//         if(str[i] == oldValue) result += $"{newValue}";
//         else result += $"{str[i]}";
//     }
// 
//     return result;
// 
// }
// 
// string newText = Replace(str, ' ', '|');
// Console.WriteLine(newText);


// ex9:
// string str = "Идейные соображения - высшего порядка, а также дальнейшее"
// + " развитие различных форм деятельности требуют  - от нас анализа дальнейших"
// + " направлений - развития. Идейные соображения высшего порядка, а также" 
// + " укрепление и развитие структуры требуют определения и уточнения "
// + "направлений прогрессивного развития.";
// 
// string Replace(string str, char oldValue, char newValue){
// 
//     string result = String.Empty;
// 
//     int length = str.Length;
// 
//     for(int i = 0; i < length; i++)
//     {
//         if(str[i] == oldValue) result += $"{newValue}";
//         else result += $"{str[i]}";
//     }
// 
//     return result;
// 
// }
// 
// string newText = Replace(str, ' ', '|');
// Console.WriteLine(newText);


// ex10:
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArr(int[] arr){

    int count = arr.Length;

    for(int i = 0; i < count; i++){
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
       int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPosition])  minPosition = j;
        }

       int temp = arr[i];
       arr[i] = arr[minPosition];
       arr[minPosition] = temp;
    }
}

PrintArr(arr);

SelectionSort(arr);

PrintArr(arr);