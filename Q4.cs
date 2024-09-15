class Q4
{
    static void ans()
    {   
        string path1 = "Q4a.txt";
        string path2 = "Q4b.txt";
        int counterSame = 0;
        int counterDiff = 0;
        
        StreamReader file1 = new StreamReader(path1);
        StreamReader file2 = new StreamReader(path2);

        using(file1)
        {
            using(file2)
            {
                string line1 = file1.ReadLine();
                string line2 = file2.ReadLine();

                while(line1 != null || line2 != null)
                {
                    if(line1 == line2)
                    {
                        counterSame++;
                    }
                    else
                    {
                        counterDiff++;
                    }
                    line1 = file1.ReadLine();
                    line2 = file2.ReadLine();
                }
                if(line1 != null)
                {
                    counterDiff++;
                    line1 = file1.ReadLine();
                }
                else if(line2 != null)
                {
                    counterDiff++;
                    line2 = file2.ReadLine();
                }
            }
        }
        Console.WriteLine("The number of same line is " + counterSame);
        Console.WriteLine("The number of different line is " + counterDiff);
    }
}