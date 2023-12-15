int Max(int a, int b) 
{
int max=0 ;
if(a>b) max=a; 
if(b>a) max=b;

return max;
}

int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(Max(a,b));
