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
            StreamWriter temp = new StreamWriter("Q10b.txt"); //create a file to store the answer
            //declare variables to store the index of the first and end of the output text
            int startidx = 0;
            int endidx = 0;

            using(temp)
            {
                using(file)
                {
                    string line = file.ReadLine();
                    //a loop to read every single line of the file
                    while(line != null)
                    {
                        int currentidx = 0;
                        string outputText; //temp string to store the output
                        //a loop to search the output text
                        while(currentidx != -1)
                        {
                            //ending condition of the loop (e.g. the went it reaches the end index of the line in case '>' is at the end)
                            if(currentidx >= line.Length - 1)
                            {
                                break;
                            }
                            //check if the currentidx is '<' or not, if not, record the output text
                            if(line[currentidx] != '<')
                            {
                                int len;
                                startidx = currentidx;
                                //the end of the output text is right before '<'
                                endidx = line.IndexOf('<', currentidx + 1);
                                len = endidx - startidx;
                                //a special case where output text is at the end, '<' cannot be found and may cause the OutOfRange error
                                if(endidx == -1)
                                {
                                    endidx = line.Length - 1;
                                    len = line.Length - startidx;
                                }
                                outputText = line.Substring(startidx, len);
                                //write the text in the result file
                                temp.WriteLine(outputText);
                                currentidx = endidx;
                            }
                            //in case currentidx is '<', continue the checking
                            else if(line[currentidx] == '<')
                            {
                                currentidx++;
                            }
                            currentidx = line.IndexOf('>', currentidx);
                            //condition for special case where output text at the end, if not, continue the checking from next index
                            if(currentidx != -1)
                            {
                                currentidx++;
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