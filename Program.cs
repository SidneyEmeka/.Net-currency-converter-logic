double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd); //We had to cast the usd with an int data type so we can perform calcs on it with a rate thats an int too
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}
