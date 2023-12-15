void ChangePlace(ref int x, ref int y)
{
    int x1 = x;
    x = y;
    y = x1;
    
}

int x = Convert.ToInt32(System.Console.ReadLine());
int y = Convert.ToInt32(System.Console.ReadLine());
ChangePlace(ref x,ref y);

System.Console.WriteLine("x = " + x);
System.Console.WriteLine("y = " + y);
