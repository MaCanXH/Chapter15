class Q12
{
    static void ans()
    {
        string wordFile = "words.txt";
        string textFile = "text.txt";
        string result = "Q12.txt";
        //declare an array with initial size 10 to store the words
        //better solution is using alist
        string[] wordArr = new string[10];

        StreamReader words = new StreamReader(wordFile);

        using(words)
        {
            string line = words.ReadLine();
            int counter = 0;
            //loop to store the words in the words.txt in the wordArr 
            while(line != null)
            {
                wordArr[counter] = line;
                counter++;
                line = words.ReadLine();
            }
            //using temp array to resize the wordArr length exactly equal to the size of words.txt
            string[] temp = new string[counter];
            for(int i = 0; i < counter; i++)
            {
                temp[i] = wordArr[i];
            }
            wordArr = temp;
        }

        StreamReader texts = new StreamReader(textFile);
        StreamWriter ans = new StreamWriter(result);

        using(texts)
        {
            using(ans)
            {
                string line = texts.ReadLine();
                //loop to delete (replace words with "") the word in text.txt according to the element in wordArr
                while(line != null)
                {
                    foreach(string s in wordArr)
                    {
                        line = line.Replace(s, "");
                    }
                    ans.WriteLine(line);
                    line = texts.ReadLine();
                }
            }
        }
        try
        {
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("cannot find the file");
        }
        catch(IOException)
        {
            Console.WriteLine("cannot read/write the file");
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("the index out of range");
        }
    }
}