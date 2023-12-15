 int EvenCount(int n){
    int cnt=0;
    for(int i=n; i>0; i /= 10)
    {
        if(i%2==0) cnt++;
    }
    return cnt;
 }

 int OddCount(int n){
    int cnt=0;
    for(int i=n; i>0; i /= 10)
    {
        if(i%2!=0) cnt++;
    }
    return cnt;
 }

 int DigitCount(int n){
    int cnt=0;
    for(int i=n; i>0; i /=10)
    {
        cnt++;
    }
    return cnt;
 }

  int SumDigit(int n){
    int sum=0;
    for(int i=n; i>0; i /=10)
    {
        sum += (i%10);
    }
    return sum;
 }

int n = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Even:" + EvenCount(n));
Console.WriteLine("Odd:" + OddCount(n));
Console.WriteLine("Digit:" + DigitCount(n));
Console.WriteLine("Sum:" + SumDigit(n));