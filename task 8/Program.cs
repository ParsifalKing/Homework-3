int MinNumber(int a, int b, int c, int d) 
{
int min=0 ,min1=0, min2=0;
if(a<b) min1=a; 
if(b<a) min1=b;

if(c<d) min2=c; 
if(d<c) min2=d;

if(min1 < min2) min=min1; 
if(min2 < min1) min=min2;

return min;
}

int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());
int c = Convert.ToInt32(System.Console.ReadLine());
int d = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(MinNumber(a,b,c,d));
