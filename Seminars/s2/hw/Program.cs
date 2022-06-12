// Ex1:
// while(true){
//     Console.Write("Enter Num: ");
//     string s = Console.ReadLine();
//     char[] sa = s.ToCharArray();
//     if(sa.Length == 3){
//         Console.Write("Second num: " + sa[sa.Length - 2]);
//         break;
//     }
//     else if(sa.Length > 3 || sa.Length < 3){
//         Console.WriteLine("Your num have in itself more than 3 num, or less than 3 num, exemple: \"123\", please try again... ");
//         continue;
//     }
// }

// Ex3:
while(true){
    Console.Write("Enter Num: ");
    int a = int.Parse(Console.ReadLine());
    if(a == 6 || a == 7){
        Console.Write("It's weekends! Yeah, relax bro))))");
        break;
    }
    else if(a > 7 || a < 1){
        Console.WriteLine("Hay yo what shit do you enter, don't be fucking retard, try again, PLEEEAAAse =* ");
        continue;
    }
    else{
        string[] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        Console.WriteLine("It's still fucking " + day[a-1]);
        continue;
        }
}