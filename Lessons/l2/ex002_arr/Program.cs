﻿int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2 > result)result = arg2;
    if(arg3 > result)result = arg3;
    return result;
}

int[] arr = {14, 23, 35, 41, 59, 63, 78, 83, 19};

int max = Max(Max(arr[0], arr[1], arr[2]), Max(arr[3], arr[4], arr[5]), Max(arr[6], arr[7], arr[8]));

Console.WriteLine(max);
