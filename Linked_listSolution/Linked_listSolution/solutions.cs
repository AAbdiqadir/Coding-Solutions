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