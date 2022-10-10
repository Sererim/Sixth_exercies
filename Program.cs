int Main()
{
    Console.WriteLine("Program is running.");
    string key;
    int num = 0;
    int[] arr = new int[2];
    while(true)
    {
        Console.WriteLine("Enter 1 to find out how many M entered numbers are bigger than zero.\n" +
        "Enter 2 to find a point of intersection of two lines.\n" +
        "Enter 0 to terminate a program.");

        key = Console.ReadLine();
        switch(key)
        {
            case "1":
                num = homework.M();
                Console.WriteLine($"|{num}|");
                break;
            case "2":
                arr = homework.Cross();
                Console.WriteLine($"The point of intersection is ({arr[0]}, {arr[1]}).");
                break;
            case "0":
                return 0;
            default:
                Main();
                break;
        }

    }
}

Main();

class homework
{
    static public int M()
    {
        int size = 0;
        string key = "2";
        Console.WriteLine("Enter M.");
        key = Console.ReadLine();
        size = System.Int32.Parse(key);
        int[] arr = new int[size];
        size = 0;
        for(int i = 0; i < arr.Length; i ++)
        {
            key = Console.ReadLine();
            arr[i] = System.Int32.Parse(key);
            if(arr[i] > 0) size++;
        }
        return size;

    }

    static public int[] Cross()
    {
        string word = "k1k2b1b2";
        string key = "";
        int[] arr = new int[4];
        int[] ans = new int[2];
        int j = 0;
        Console.WriteLine("Enter k1, k2, b1 and b2.");
        for(int i = 0; i < 8; i += 2)
        {
            Console.WriteLine($"Enter {word[i]}{word[i+1]}");
            key = Console.ReadLine();
            arr[j] = System.Int32.Parse(key);
            j++;
        }

        Console.WriteLine("Entered parametrs for two lines:\n" +
        $"y1 = {arr[0]}x + {arr[2]}\n" + 
        $"y2 = {arr[1]}x + {arr[3]}");

        ans[0] = (arr[3] - arr[2])/(arr[0] - arr[1]);
        ans[1] = (arr[0] * arr[3] - arr[1] * arr[2])/(arr[0] - arr[1]);

        return ans;
    }
}