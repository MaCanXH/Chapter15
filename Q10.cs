using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Transactions;

class Q10
{
    static void Main()
    {
        try
        {
            string path = "Q10a.txt";
            StreamReader file = new StreamReader(path);
            StreamWriter temp = new StreamWriter("Q10b.txt");
            int startidx = 0;
            int endidx = 0;

            using(temp)
            {
                using(file)
                {
                    string line = file.ReadLine();
                    while(line != null)
                    {
                        int currentidx = 0;
                        string outputText;
                        while(currentidx != -1)
                        {
                            currentidx = line.IndexOf('>', currentidx);
                            Console.WriteLine(currentidx);
                            if(currentidx < line.Length - 1)
                            {
                                if(line[currentidx + 1] != '<')
                                {
                                    startidx = currentidx + 1;
                                    endidx = line.IndexOf('<', currentidx + 1);
                                    outputText = line.Substring(startidx, endidx - startidx + 1);
                                    temp.WriteLine(outputText);
                                    currentidx = endidx;
                                }
                                else if(line[currentidx + 1] == '<')
                                {
                                    currentidx++;
                                }
                            }
                        }
                        line = file.ReadLine();
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