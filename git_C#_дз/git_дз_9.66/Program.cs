using System; 
class New_Project  
{
  public void Main()  
  {
    uint i, M, N;
    ulong s, S, t;
    while (true) 
    {
      s = 0;
      Console.Write("M N: ");
      var line = Console.ReadLine().Split(" ");
      M = uint.Parse(line[0]);
      N = uint.Parse(line[1]); 
      t = N + 1;
      t *= N;
      S = t;
      t = M - 1;
      t *= M;
      S = (S - t) / 2;
      for (i = M; i <= N; ++i) s += i;
      Console.WriteLine(s + " " + S);
    }
  }
}