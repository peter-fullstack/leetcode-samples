using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Practice
{
    /*
    Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they
    add up to a specific target number. 
    Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
    Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
    The tests are generated such that there is exactly one solution. You may not use the same element twice.
    Your solution must use only constant extra space.
    
    Example 1:

    Input: numbers = [2,7,11,15], target = 9
    Output: [1,2]
    Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
    Example 2:

    Input: numbers = [2,3,4], target = 6
    Output: [1,3]
    Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
    Example 3:

    Input: numbers = [-1,0], target = -1
    Output: [1,2]
    Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
 

    Constraints:

    2 <= numbers.length <= 3 * 104
    -1000 <= numbers[i] <= 1000
    numbers is sorted in non-decreasing order.
    -1000 <= target <= 1000
    The tests are generated such that there is exactly one solution.

     */
    public class TwoSumSolution
    {
        // 1. This looks like a prefix sum problem

        // 2. Look for any 2 elements in the array that sum to the target number

        // 3. For a given element in the array sum it with each of the other elements and check if that equals the target

        // 4. Iterate until a match is found or no match is found.

        /*
         Explanation:
         Initialize two pointers, one at the start (left) and one at the end (right) of the array.
         Check the sum of the elements at the two pointers.
         If the sum equals the target, return the indices.
         If the sum is less than the target, move the left pointer to the right.
         If the sum is greater than the target, move the right pointer to the left.
         */

        public int[] TwoSum(int[] numbers, int target)
        {

            var leftIndex = 0;
            var rightIndex = numbers.Length - 1;    

            for (var i = 0; i <= numbers.Length - 1; i++)
            {
                var sum = numbers[leftIndex] + numbers[rightIndex];
                if (sum == target)
                {
                    return [leftIndex + 1, rightIndex + 1];
                }
                else if (sum < target)
                {
                    leftIndex++;
                }
                else if (sum > target)
                {
                    rightIndex--;
                }

                if (leftIndex >= rightIndex)
                {
                    return [];
                }
            }

            return [];
        }
    }
}
