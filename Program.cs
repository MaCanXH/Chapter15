using System.Text;

string path = @"exercise.txt";

StreamWriter writer = new StreamWriter(path, true);

using (writer)
{
    writer.WriteLine("中文嘗試");
}

StreamReader reader = new StreamReader(path);

using (reader)
{
    int linenumber = 0;

    string line = reader.ReadLine();

    while(line != null)
    {
        linenumber++;
        Console.WriteLine(line);
        line = reader.ReadLine();
    }

}

