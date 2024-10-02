namespace Linked_listSolution;

public class solutions
{
    public int getmax(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        int max = nums[0];

        int max_begin = nums[0];
        int min_begin = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                
                int temp = max_begin;
                max_begin = min_begin;
                min_begin = temp;
            }
            
            max_begin = Math.Max(nums[i], nums[i] * max_begin);
            
            min_begin = Math.Min(nums[i], nums[i] * min_begin);
            
            Console.WriteLine(max_begin + ", " + min_begin);
            
            
            max = Math.Max(max, max_begin);
            
            
        }

        return max;
        
    }
    

    
}

public class solutions
{

    public List<List<int>> CombinationSum(int[] candidates, int target)
    {

        List<List<int>> Res = new List<List<int>>();

        void Dfs(int i, List<int> current, int total)
        {
            if (total.Equals(target))
            {
                Res.Add(new List<int>(current));
                return;
            }

            if (i >= candidates.Length || total > target)
            {
                return;
            }
            current.Add(candidates[i]);
            
           
            Dfs(i, current, total + candidates[i]);
            current.RemoveAt(current.Count- 1);
            
            
            
            
            Dfs(i + 1, current, total);
            
            
        }
         
        Dfs(0, [], 0);




        return Res;
    }

    public static void Main(string[] args)
    {
        solutions solutions = new solutions();

        int[] current = new int[] { 2, 3, 6, 7 };
        
        List<List<int>> Res =solutions.CombinationSum(current, 7);

        foreach (var res in Res)
        {
            Console.WriteLine(string.Join(", ", res));
        }
        
        
       
        
        
        
    }

}