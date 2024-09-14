using System.Net.Sockets;

class Q2
{
    static void ans()
    {
        string path1 = "Q2a.txt";
        string path2 = "Q2b.txt";
        string path3 = "Q2c.txt";

        try
        {
        StreamReader file1 = new StreamReader(path1);
        StreamReader file2 = new StreamReader(path2);
        StreamWriter file3 = new StreamWriter(path3);

            using(file3)
            {
                using(file1)
                {
                    string line = file1.ReadLine();
                    while(line != null)
                    {
                        file3.WriteLine(line);
                        line = file1.ReadLine();
                    }
                }
                using(file2)
                {
                    string line = file2.ReadLine();
                    while(line != null)
                    {
                        file3.WriteLine(line);
                        line = file2.ReadLine();
                    }
                }
            }
        StreamReader join = new StreamReader(path3);

        using(join)
        {
            string line = join.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = join.ReadLine();
            }
        }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The files are not found");       
        }
        catch(IOException)
        {
            Console.WriteLine("Cannot read the files");
        }
    }
}