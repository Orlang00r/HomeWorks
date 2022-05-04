

string Sys2Metod(int dex, string binary)
{
    if (dex <= 1)
    {
        string d = Convert.ToString(dex);
        binary = d + binary;
        return binary;
    }
    return Sys2Metod(dex / 2, Convert.ToString(dex - 2 * (dex / 2)) + binary);
}

Console.WriteLine("Input DEX number: ");
int input = Convert.ToInt32(Console.ReadLine());
string bin = "";
Console.WriteLine("Number in  binary system:  " + Sys2Metod(input, bin));

