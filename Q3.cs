using System.IO.Compression;
using System.Text;
class Q3
{
    static void ans()
    {
        string path = "Q3.txt";
        
        try
        {
            StreamReader file = new StreamReader(path);
            StreamWriter temp = new StreamWriter("temp.txt");

            using(temp)
            {
                using(file)
                {
                    string line = file.ReadLine();
                    while(line != null)
                    {
                        temp.WriteLine(line);
                        line = file.ReadLine();
                    }
                }
            }

            StreamReader temp2 = new StreamReader("temp.txt");
            StreamWriter result = new StreamWriter(path);
            int counter = 0;

            using(result)
            {
                using(temp2)
                {
                    string line = temp2.ReadLine();
                    while(line != null)
                    {
                        counter++;
                        result.WriteLine("{0}. {1}",counter, line);
                        line = temp2.ReadLine();
                    }
                }
            }

            StreamReader print = new StreamReader(path);

            using(print)
            {
                string line = print.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = print.ReadLine();
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