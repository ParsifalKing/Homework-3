void Divisors(int n)
{

 for(int i=1; i<=n; i++ )
 {
   if(n%i == 0) System.Console.Write(i + " ");
 }

}

int n = Convert.ToInt32(System.Console.ReadLine());
Divisors(n);

