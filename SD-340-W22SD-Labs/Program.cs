using System.Text;

string WordConcatenate(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }

    return sb.ToString();
}

string testString = "hello world";

stringDelegate newDel = new stringDelegate(WordConcatenate);
Console.WriteLine(newDel(testString, 5));

newDel = (string wordArg, int numArg) =>
{
    string subWord = wordArg.Substring(0, wordArg.Length - numArg);
    return subWord;
};

Console.WriteLine(newDel("catastrophe", 4));

delegate string stringDelegate(string wordArg, int numArg);