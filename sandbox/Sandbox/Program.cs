using System.IO;

static void writeJoke()
{string fileName = "myFile.txt";

using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        outputFile.WriteLine("Joke File");
        outputFile.WriteLine("Why did the chicken cross the road?");
        outputFile.WriteLine("To get to the other side hahahaha!");
    }}


static void readJoke()
{
    string filename = "myFile.txt";
    string[] lines= System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}

writeJoke();
readJoke();