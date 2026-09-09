public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new();

        
        for(int i = 0; i < nums.Length; i++){
            if(!set.Add(nums[i]))
                return true;
        }
        return false;
    }
}










        // List<int> list = new List<int>();

        // foreach (int num in nums) {
        //    if (list.Contains(num))
        //         return true;

        //     list.Add(num);
        // }
        // return false;



// return false;

// public class Solution {
//     public bool hasDuplicate(int[] nums) {
//         for(int i = 0; i < nums.Length; i++) {
//             for (int j = i + 1; j < nums.Length; j++){ 
//                 if(nums[i] == nums[j]) { 
//                     return true;
//                 }
//             }
//         }
//         return false;
//     }
// }