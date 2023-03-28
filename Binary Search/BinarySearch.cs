/*

Binary search is a method for searching an element in a sorted list by cutting the list in half at each iteration until the desired element is found.

Complexity: O(log n)

Note: You have to keep in mind that the elements must be ordered for the binary search to be effective.

Why? The reason why elements must be sorted in binary search is because this algorithm is based on comparing the searched element with the middle element 
     of the list and discarding half of the list in each iteration.

Steps:

1- Set the LEFT and RIGTH boundaries of the search range. For a given array arr, initialize LEFT to 0 and RIGTH to arr.Count - 1.
2- While the search range is valid (LEFT <= RIGTH):
   1- Compute the middle index of the search range: mid =  LEFT + (RIGTH - LEFT) / 2.
   2- If the middle element of the search range is equal to the target element, return its index.
   3- If the middle element is less than the target element, update the search range to the RIGTH half by setting LEFT = mid + 1.
   4- If the middle element is greater than the target element, update the search range to the LEFT half by setting RIGTH = mid - 1.
3- If the target element is not found in the array, return -1.

Problems for practice:

Search Insert Position - Problem No. 35 LeetCode
Missing Number - Problem No. 268 Leetcode
Arranging Coins - Problem No. 441 LeetCode

*/

public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0) return -1;

        int L = 0, R = nums.Length - 1;

        while (L <= R)
        {
            int mid = L + (R - L) / 2;

            if (nums[mid] == target) return mid;

            if (nums[mid] < target)
            {
                L = mid + 1;
            }
            else
            {
                R = mid - 1;
            }
        }

        return -1;
    }
}