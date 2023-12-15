int Min(int a, int b) 
{
int min=0 ;
if(a<b) min=a; 
if(b<a) min=b;

return min;
}

int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(Min(a,b));
