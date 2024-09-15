using System.Diagnostics;
using System.Text;

class Q7
{
    static void ans()
    {
        try
        {
            string path = "Q7a.txt";
            string ans = "Q7b.txt";
            StreamReader file1 = new StreamReader(path);
            StreamWriter file2 = new StreamWriter(ans);

            using(file1)
            {
                using(file2)
                {
                    string line = file1.ReadLine();
                    while(line != null)
                    {
                        file2.WriteLine(line.Replace("start", "finish"));
                        line = file1.ReadLine();
                    }
                }
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("cannot find the file");
        }
        catch(IOException)
        {
            Console.WriteLine("cannot read the file");
        }
    }
}