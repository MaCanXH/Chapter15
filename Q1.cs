class Q1
{
    static void ans()
    {
        string path = "Q1.txt";
        StreamReader oddLine = new StreamReader(path);

        try
        {
            using(oddLine)
            {
                int counter = 0;
                string line = oddLine.ReadLine();

                while(line != null)
                {
                    counter++;
                    if(counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                        line = oddLine.ReadLine();
                        continue;
                    }
                    line = oddLine.ReadLine();
                }
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("cannot find the file {0}", path);
        }
        catch(IOException)
        {
            Console.WriteLine("cannot read the file {0}", path);
        }
    }
}