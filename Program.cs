// using System.Text;
// string path = @"exercise.txt";
// string text = "is";

// try
// {
//     StreamWriter writer = new StreamWriter(path);

//     using (writer)
//     {
//         writer.WriteLine("this is Max trial");
//         writer.WriteLine("this Max is Max trial");
//         writer.WriteLine("this is Max trial");
//         writer.WriteLine("Max this is Max trial");
//     }

//     StreamReader reader = new StreamReader(path);

//     using (reader)
//     {
//         int counter = 0;

//         string line = reader.ReadLine();

//         while(line != null)
//         {
//             int index = line.IndexOf(text);
//             Console.WriteLine(line);

//             while(index != -1)
//             {
//                 counter++;
//                 index = line.IndexOf(text, index + 1);
//             }
//             line = reader.ReadLine();
//         }
//         Console.WriteLine("The occurance of {0} is {1}", text, counter);

//     }
// }
// catch(FileNotFoundException)
// {  
//     Console.Error.WriteLine("Cannot find the file {0}", path);
// }
// catch(IOException)
// {
//     Console.Error.WriteLine("Cannot read the file {0}", path);
// }


