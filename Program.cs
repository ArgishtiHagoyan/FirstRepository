using System.IO;
try
{
    string path = "/Users/artyom/Desktop/csharp/firstfile.txt";
    string path2 = "/Users/artyom/Desktop/csharp/secondfile.txt";
    string sms = "bla-bla";

    using (StreamWriter sw = new StreamWriter(path))
    {
        sw.WriteLine(sms);
        sw.WriteLine("2RD");
        sw.WriteLine("3ed");
    }
    using (StreamReader sr = new StreamReader(path, true))
    {
        string copy = sr.ReadLine();
        while (copy != null)
        {
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                sw.WriteLine(copy);
            }
            copy = sr.ReadLine();
        }
    }
    Console.WriteLine("Good job.");
}
catch(Exception e)
{
    Console.WriteLine(e);
}