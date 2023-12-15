void  IncrementArrayElements(ref int n, ref int[] arr ,ref int s)
{
  for (int i = 0; i < n; i++)
  {
    arr[i] = arr[i] + s;
  }
}

int n = Convert.ToInt32(System.Console.ReadLine()); 
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(System.Console.ReadLine());
}

int s = Convert.ToInt32(System.Console.ReadLine()); 

IncrementArrayElements(ref n,ref arr ,ref s);

System.Console.Write("[ ");
for (int i = 0; i < n; i++)
{
  System.Console.Write(arr[i] + " ");  
}
System.Console.Write("]");
