using System.Data;

class Q5
{
    static void ans()
    {
        try
        {
            string path = "Q5a.txt";
            string ans = "Q5b.txt";
            int maxSum = 0;
            StreamReader matrix = new StreamReader(path);
            StreamWriter finalSum = new StreamWriter(ans);
            //read the size of the 2 dimensional sqaure matix first
            int size = int.Parse(matrix.ReadLine());
            int[,] arr = new int[size,size];
            //index of the row of the matrix
            int row = 0;

            using(matrix)
            {
                string line = matrix.ReadLine();
                while(line != null)
                {
                    //split the line of the text by " " and save them into an array
                    string[] temp = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    //store the temp arr element into an integer arr
                    for(int i = 0; i < size; i++)
                    {
                        arr[row, i] = int.Parse(temp[i]);
                    }
                    row++;
                    line = matrix.ReadLine();        
                }
            }
            //find the max matrix sum
            int tempSum = 0;
            for(int i = 0; i < size - 1; i++)
            {
                for(int j = 0; j < size - 1; j++)
                {
                    tempSum = arr[i,j] + arr[i + 1, j] + arr[i, j + 1] + arr[i + 1, j + 1];
                    if(tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }
            //print it maxSum into another file
            using(finalSum)
            {
                finalSum.WriteLine("The maximun matrix sum is " + maxSum);
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