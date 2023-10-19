// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

 

// Example 1:

// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
// Output: [[1,6],[8,10],[15,18]]
// Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
// Example 2:

// Input: intervals = [[1,4],[4,5]]
// Output: [[1,5]]
// Explanation: Intervals [1,4] and [4,5] are considered overlapping.

//Approach:
// The code is very simple at first we will sort the 2D array based on the first column. 
// after that we will create a list of array and add the first row from the sorted 2D array. 
// then we will just loop the 2D array and 
// check if the list last array's last element is greater than the current sorted array's first element 
// if yes then we will change the list element based on value, 
// else we will add the element to the list.

//[CODE]:
public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> res = new List<int[]>();
        Array.Sort(intervals, (a, b)=> {return a[0]-b[0];});
        res.Add(intervals[0]);
        for(int i = 1; i<intervals.Length;i++){
            if(res[res.Count-1][1]>=intervals[i][0]){
                if(res[res.Count-1][1] <= intervals[i][1]){
                    res[res.Count-1][1] = intervals[i][1];
                }    
            }
            else res.Add(intervals[i]);
        } 
        
        return res.ToArray();
    }
}