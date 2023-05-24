
int GetNaturalNumberReverse(int N)
{
    
    if (N == 0) return 1; 
     if(N - 1 == 0) Console.WriteLine($"{N}");
     else Console.Write($"{N}, ");
    return N - GetNaturalNumberReverse(N-1);

}

int GetNaturalNumberSum(int M, int N)
{
   if (M == N) return N;
   return N += GetNaturalNumberSum(M,N - 1);
}


int  AkkermanFinction (int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0 && M > 0) return AkkermanFinction(M -1,1);
    else return (AkkermanFinction(M -1, AkkermanFinction(M, N -1)));
}
   


Console.WriteLine(AkkermanFinction(3,2));
