class Q11
{
    static void ans()
    {
        string path = "Q11a.txt";
        StreamReader file = new StreamReader(path);
        StreamWriter ans = new StreamWriter("Q11b.txt");

        using(file)
        {
            using(ans)
            {
                string line = file.ReadLine();
                while(line != null)
                {
                    ans.WriteLine(line.Replace("test", ""));
                    line = file.ReadLine();
                }
            }
        }
    }
}