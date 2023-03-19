/*

Two-pointers is a common technique used to solve array and string problems.

Steps:

1- Initialize two pointers at the ends of the array.
2- Move the pointers towards the center of the array while a certain condition is met.
3- If the condition is met, process the pair of elements.
4- Repeat steps 2 and 3 until the pointers cross or all pairs of elements satisfying the condition have been processed.

Three Types of Pointers Used in the Two Pointers Technique:

1- Same Direction and Speed Pointers
2- Opposite Direction and Same Speed Pointers
3- Opposite Direction and Different Speed Pointers

Example:

You want to return the index of 2 numbers in this array [2,6,3,8,7,4] that if added together are equal to a target X, let's say it's 11.

 2 + 4 = 11? No, move the pointers (L++) and (R--).
[2,6,3,8,7,4]
L^         ^R 

 6 + 7 = 11? No, move the pointers (L++) and (R--).
[2,6,3,8,7,4]
  L^     ^R 

 3 + 8 = 11? Yes, we return the index of the two value that are aqueal to the target..
[2,6,3,8,7,4]
    L^ ^R 

Result: [2,3]

Problems for practice:

Maximum Subarray - Problem No. 53 LeetCode.
Longest Common Subsequence - Problem No. 1143 LeetCode.
Intersection of Two Arrays II - Problem No. 350 LeetCode.

*/

// Space: O(n)
// Time: O(n)
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {

        if (numbers == null || numbers.Length <= 0) return new int[] { };

        int L = 0, R = numbers.Length - 1;

        while (L < R)
        {
            if (numbers[L] + numbers[R] == target)
            {
                return new int[] { L + 1, R + 1 };
            }
            else if (numbers[L] + numbers[R] < target)
            {
                L++;
            }
            else
            {
                R--;
            }
        }

        return new int[] { };
    }
}

