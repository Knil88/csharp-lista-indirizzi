// Open the file to read from.
FileStream file = File.Open("Desktop\\addresses.csv", FileMode.Open);
while (!file.EndOfStream)
{

    string riga = file.ReadLine();
    Console.WriteLine(riga);

}
file.Close();