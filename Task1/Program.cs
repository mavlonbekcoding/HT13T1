int a = 5, b = 6, P, S;

GetArea(a, b,out P,out S);

static void GetArea(int a, int b, out int P,out int S)
{
    P = 2 * (a + b);
    S = a * b;
    Console.WriteLine($"Parametr:{P},Yuzasi:{S}");
}

