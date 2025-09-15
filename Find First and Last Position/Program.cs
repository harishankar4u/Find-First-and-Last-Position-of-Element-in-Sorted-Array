class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(string.Join(",", SearchRange([ 5, 7, 7, 8, 8, 10 ], 8))); // [3,4]
        Console.WriteLine(string.Join(",", SearchRange([5, 7, 7, 8, 8, 10 ], 6))); // [-1,-1]
        Console.WriteLine(string.Join(",", SearchRange(new int[] { }, 0)));             // [-1,-1]
        Console.WriteLine(string.Join(",", SearchRange(new int[] {0,1}, 1)));             // [1,1]
    }
    public static int[] SearchRange(int[] nums, int target)
    {
        int first = -1; int second = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==target)
            {
                if(first==-1)
                {
                    first = i;
                    second = i;
                }
                else
                {
                    second = i;
                }
            }
        }
        var resp= new int[] { first, second };
        return resp;

    }
}