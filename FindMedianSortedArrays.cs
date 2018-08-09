/*
There are two sorted arrays nums1 and nums2 of size m and n respectively.
Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
You may assume nums1 and nums2 cannot be both empty.

Example 1:
nums1 = [1, 3]
nums2 = [2]
The median is 2.0

Example 2:
nums1 = [1, 2]
nums2 = [3, 4]
The median is (2 + 3)/2 = 2.5
*/


public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int length1 = nums1.Length;
        int length2 = nums2.Length;
        int[] a = new int[length1+length2];
        int curr1 = 0; // current index of nums1
        int curr2 = 0; // current index of nums2
        int index = 0; // current index of the output array
        double median;
        
            
        if (length1 == 0 || nums1 == null)
        {
            if (length2 % 2 == 0)
            {
            int mid_index = length2 / 2;
            median = (double)(nums2[mid_index] + nums2[mid_index - 1]) / 2;
            }
            else median = nums2[length2/2];
            return median;
        }
        else if (length2 == 0 || nums2 == null)
        {
            if (length1 % 2 == 0)
            {
            int mid_index = length1 / 2;
            median = (double)(nums1[mid_index] + nums1[mid_index - 1]) / 2;
            }
            else median = nums1[length1/2];
            return median;
        }
            
        int holding = nums2[0]; // last highest number
        
        while (index < length1+length2)
        {
            while(curr1 < length1 && nums1[curr1] <= holding)
            {
				if (index < length1+length2 && curr1 < length1)
				{
					a[index] = nums1[curr1];
					curr1++;
					index++;
					if (curr1 == length1) break;					}
				else break;
            }
            
            if (curr1 < length1) holding = nums1[curr1];
			else holding = Int32.MaxValue;
            
            while(curr2 < length2 && nums2[curr2] <= holding)
            {
				if (index < length1+length2 && curr2 < length2)
				{
					a[index] = nums2[curr2];
					curr2++;
					index++;
					if (curr2 == length2) break;
				}
				else break;
            }
            if (curr2 < length2) holding = nums2[curr2];
			else holding = Int32.MaxValue;
        }
        
        if (a.Length % 2 == 0)
        {
            int mid_index = a.Length / 2;
            median = (double)(a[mid_index] + a[mid_index - 1]) / 2;
        }
        else median = a[a.Length/2];
        
        return median;
    }
