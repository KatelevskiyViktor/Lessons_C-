// ex1:
// int countOfNumMoreThanZero = 0;
// while (true)
// {
//     Console.WriteLine("Enter number or \"end\" to output result");
// 
//     string userEnter = Console.ReadLine();
//     if (userEnter == "end") 
//     {
//         Console.Write("Result: " +  countOfNumMoreThanZero);
//         break;
//     }
//     try
//     {
//         int userNumber = int.Parse(userEnter);
//         if (userNumber > 0) countOfNumMoreThanZero++;
//     }
//     catch
//     {
//         Console.WriteLine("You enter not a number, please try again.");
//         continue;
//     }
// }




// ex2:

while(true){
    try{
        Console.WriteLine("Enter b1, or \"end\" to exit: ");
        string value = Console.ReadLine();
        if(value == "end")break;
        int b1 = int.Parse(value);
        Console.WriteLine("Enter k1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b2: ");
        int b2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k2: ");
        int k2 = int.Parse(Console.ReadLine()); 
        var x =(double) (b2 - b1) / (k1 - k2);
         
        var y = (k1 * x) + b1;

        Console.WriteLine($"Your point is: ({x};{y})");
        continue;
    }catch{
        Console.WriteLine("You enter not a number, please try again.");
        continue;
    }
    
    
    
}
    




