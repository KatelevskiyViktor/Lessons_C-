// Ex1:
// while(true){
//     Console.Write("Enter Num: ");
//     string s = Console.ReadLine();
//     char[] sa = s.ToCharArray();
//     if(sa.Length == 5){
//         if((sa[0] + sa[1] + sa[2]) == (sa[2] + sa[3] + sa[4])){
//             Console.Write("Yes it's poliiiiiiIIIIIIIndrommm my boy: " + s);
//             break;
//         }else{
//             Console.WriteLine("Offff course! Who do you want to throw!? Try again beach!))");
//             continue;
//         }
// 
//     }
//     else if(sa.Length > 5 || sa.Length < 5){
//         Console.WriteLine("Hay yo what shit do you enter, don't be fucking retard, try again, PLEEEAAAse =* ");
//         continue;
//     }
// }


// Ex2:
// Console.WriteLine("Enter num x1: ");
// int x1 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine("Enter num x2: ");
// int x2 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine("Enter num y1: ");
// int y1 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine("Enter num y2: ");
// int y2 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine("Enter num z1: ");
// int z1 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine("Enter num z2: ");
// int z2 = int.Parse(Console.ReadLine());
// 
// Console.WriteLine(
//                     Math.Round(
//                 Math.Sqrt(
//                         Math.Pow(x2-x1,2) + 
//                             Math.Pow(y2-y1,2) + 
//                             Math.Pow(z2-z1,2)), 2)
//                 );



// Ex3:
while(true){
    Console.Write("Enter num or FUBIS if you want to GTFO: ");
    string s = Console.ReadLine();
    if(s == "FUBIS"){
        Console.Write("GTFO dude!");
        break;
    }
    else{
        try{
            int n = int.Parse(s);
            int count = 1;

            while(count <= n){
                Console.Write(Math.Pow(count, 3) + ", ");
                count++;
            }
            Console.WriteLine("");
            }
            catch{
                Console.WriteLine("You enter some shit, try again, please =*");
                continue;
            }
            
            

            
    }
    


}
 