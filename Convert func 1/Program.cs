
int N()
{
    Console.Write("n=");
    int n = int.Parse(Console.ReadLine());
    return n;
}
//Console.WriteLine(N());

int M = N();
int A()
{
    Console.Write("a=");
    int a = int.Parse(Console.ReadLine());
    return a;
}
//Console.WriteLine(A());

int K = A();

int B()
{
    Console.Write("b=");
    int b = int.Parse(Console.ReadLine());
    return b;
}
//Console.WriteLine(B());

int Z = B();
static int P(int M, int K, int Z)
{
    int p = M * K * Z * 2;
    return p;
}
Console.WriteLine(P(M, K, Z));

