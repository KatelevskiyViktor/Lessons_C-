﻿int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result)result = arg2;
    if(arg3 > result)result = arg3;
    return result;
}

int a1 = 15, b1 = 21, c1 = 39, 
a2 = 12, b2 = 23, c2 = 87, 
a3 = 13, b3 = 45, c3 = 33;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);