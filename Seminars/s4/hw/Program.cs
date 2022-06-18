// Ex1:
// while(true){
//     try{
//         Console.Write("Enter first num, or nah if you want to end: ");
//         string str = Console.ReadLine();
// 
//         if(str == "nah")break;
// 
//         int fn = int.Parse(str);
// 
//         Console.Write("Enter second num: ");
//         int sn = int.Parse(Console.ReadLine());
// 
//         Console.WriteLine("Your res: " + Math.Pow(fn,sn));
//         continue;
//     }catch{
//         Console.WriteLine("Enter noraml num dude not some f.. string or nah! ");
//         continue;
//     }
// }



// Ex2:
// while(true){
//     try{
//         Console.Write("Enter num, or nah if you want to end: ");
//         string str = Console.ReadLine();
// 
//         if(str == "nah")break;
// 
//         char[] sa = str.ToCharArray();
//         int res = 0;
// 
//         for (int i = 0; i < sa.Length; i++)
//         {
// 
//             res  += int.Parse(Convert.ToString(sa[i]));
// 
//         }
//         Console.WriteLine("Sum: " + res);
//     }catch{
//         Console.WriteLine("Enter noraml num dude not some f.. string or nah! ");
//         continue;
//     }
// }


// Ex3:
int[] CreateArr(){
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rnd.Next();
    }
    
    return arr;
}

void ViewArr(int[] arr){
    for (int i = 0; i < 8; i++)
    {
        Console.Write(arr[i] + ", ");
    }
}

ViewArr(CreateArr());