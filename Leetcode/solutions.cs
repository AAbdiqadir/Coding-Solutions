namespace Linked_listSolution;


//maximum product subarray
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
//39 Combination sum 
public class solutions
{
/39 Combination sum 
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

//295. Find Median from Data Stream
public class MedianFinder {
    
    private PriorityQueue<int, int> minHeap;
  
    private PriorityQueue<int, int> maxHeap;

    public MedianFinder() {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    }

    public void AddNum(int num) {
        
        maxHeap.Enqueue(num, num);

        
        if (minHeap.Count > 0 && maxHeap.Peek() > minHeap.Peek()) {
            int toMinHeap = maxHeap.Dequeue();
            minHeap.Enqueue(toMinHeap, toMinHeap);
        }

        if (maxHeap.Count > minHeap.Count + 1) {
            int toMinHeap = maxHeap.Dequeue();
            minHeap.Enqueue(toMinHeap, toMinHeap);
        }
        else if (minHeap.Count > maxHeap.Count) {
            int toMaxHeap = minHeap.Dequeue();
            maxHeap.Enqueue(toMaxHeap, toMaxHeap);
        }
    }

    public double FindMedian() {
        if (maxHeap.Count > minHeap.Count) {
            // maxHeap has one more element, so the median is the top of maxHeap
            return maxHeap.Peek();
        }
        else {
            // Both heaps are balanced, so the median is the average of both tops
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }
    }
    
}

//424. Longest Repeating Character Replacement
public class solution
{

    public int CharacterReplacement(string s, int k)
    {
        int pointer1 = 0;

        int maxcount = 0;

        int maxLength = 0;
        int[] char_ = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            char_[s[i] - 'A']++;

            maxcount = Math.Max(maxcount, char_[s[i] - 'A']);


            while ((i - pointer1 + 1) - maxcount > k)
            {
                char_[s[pointer1] - 'A']--;
                pointer1++;



            }

            maxLength = Math.Max(maxLength, i - pointer1 + 1);

        }


        return maxLength;
    }
    
}

//300. Longest Increasing Subsequence
public class Solution {
    public int LengthOfLIS(int[] nums) {
        
        
        int pointer1= nums.Length-1;
        int maxlength = 0;
        int n = nums.Length;
        int[] num = Enumerable.Repeat(1, n).ToArray();
        int latest = 0;
        

        while (pointer1 >=0)
        {
            for (int i = pointer1+1; i < nums.Length; i ++){
                
                //Console.WriteLine(nums[pointer1] + " "+ nums[i]);
                if (nums[pointer1]< nums[i] )
                {
                    
                    num[pointer1] = Math.Max(num[i]+1,num[pointer1]);
                    Console.WriteLine(nums[pointer1] +" "+ nums[i] + " "+ num[pointer1]);
                    
                    

                }
                
            
                
            }
            
            pointer1--;

        }
        return num.Max();
    }

    public static void Main(String[] args)
    {
        Solution solution = new Solution();

        int[] nums = [2,5,3,7];
        
        Console.WriteLine(solution.LengthOfLIS(nums));
    }
}