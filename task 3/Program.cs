 int MinDigit(int n)
 {
    int min=999999999,a;
    for (int i = n; i > 0; i /= 10)
    {
     a = i%10;   
     if(a < min) min = a;
    }
    return min;
 }

  int MiaxDigit(int n)
 {
    int max=-999999999,a;
    for (int i = n; i > 0; i /= 10)
    {
     a = i%10;   
     if(a > max) max = a;
    }
    return max;
 }

 int n = Convert.ToInt32(System.Console.ReadLine());
 int s = MinDigit(n) + MiaxDigit(n);
 Console.WriteLine(MinDigit(n) + " + " + MiaxDigit(n) + " = " + s);