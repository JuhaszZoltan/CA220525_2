using System.Text;
using CA220525_2;

//Iras();
//Olvasas();

using StreamReader sr = new(
    path: "../../../res/diakok.txt",
    encoding: Encoding.UTF8);

var diakok = new Diak[1000];
int index = 0;

while (!sr.EndOfStream)
{
    string sor = sr.ReadLine();
    diakok[index] = new Diak(sor);
    index++;
}

Array.Resize(ref diakok, index);

int sum = 0;
for (int i = 0; i < diakok.Length; i++)
{
    sum += diakok[i].Magassag;
}

Console.WriteLine($"diákok átlagos magassága: {sum/(float)diakok.Length} cm");

Console.WriteLine("\n\nkész vagyok!");


void Iras()
{
    using StreamWriter sw = new(
        path: @"../../../res/file.txt",
        append: false,
        encoding: Encoding.UTF8);

    sw.WriteLine($"Mostmár");
    sw.WriteLine($"csak ez");
    sw.WriteLine($"van benne");
}

void Olvasas()
{
    using StreamReader sr = new(
        path: @"../../../res/nevek.txt",
        Encoding.UTF8);

    while (!sr.EndOfStream)
    {
        string sor = sr.ReadLine();
        Console.WriteLine(sor);
    }
}

