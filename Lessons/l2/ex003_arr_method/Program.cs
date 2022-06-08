int[] arr = {1, 12, 31, 4, 15, 16, 17, 18};

int n = arr.Length;
int find = 4;

int i = 0;

while(i < n){
    if(arr[i] == find){ 
        Console.WriteLine(i);
        break;
        }
    i++;
}
