class Q9
{
    static void ans()
    {
        try
        {
            string path = "Q9a.txt";
            StreamReader file = new StreamReader(path);
            //create a temporary file to store the even line
            StreamWriter temp = new StreamWriter("temp.txt");

            //copy only the even line to the temp.txt (i.e. delete the odd line)
            using(temp)
            {
                using(file)
                {
                    int counter = 1;
                    string line = file.ReadLine();
                    while(line != null)
                    {
                        if(counter % 2 == 0)
                        {
                            temp.WriteLine(line);
                            line = file.ReadLine();
                            counter++;
                            continue;
                        }
                        line = file.ReadLine();
                        counter++;
                    }
                }
            }

            //copy the temp.txt to the original file (even line)
            StreamReader temp2 = new StreamReader("temp.txt");
            StreamWriter result = new StreamWriter(path);

            using(result)
            {
                using(temp2)
                {
                    string line = temp2.ReadLine();
                    while(line != null)
                    {
                        result.WriteLine(line);
                        line = temp2.ReadLine();
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