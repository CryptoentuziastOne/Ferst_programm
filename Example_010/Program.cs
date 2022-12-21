 Console.Clear();
 int[] array = { 1, 15, 24, 78, 17, 94 };

 int n = array.Length;
 int find = 2;

 int index = 0;

 while (index < n)
 {
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
 }