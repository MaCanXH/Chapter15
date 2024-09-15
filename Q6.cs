class Q6
{
    static void ans()
    {
        try
        {
        string path = "Q6a.txt";
        string ans = "Q6b.txt";
        StreamReader nameList = new StreamReader(path);
        StreamWriter sortList = new StreamWriter(ans);


        string name = nameList.ReadLine();
        string[] arr = name.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(arr);
        nameList.Close();

        using(sortList)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                sortList.WriteLine(arr[i]);
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