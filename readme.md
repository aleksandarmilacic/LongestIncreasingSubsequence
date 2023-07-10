# Longest Increasing Subsequence Problem
## Problem Description
The task is to find the longest increasing subsequence in a given array of integers. The subsequence does not have to be contiguous, but it must be increasing. In other words, each number in the subsequence must be larger than the one before it.

For example, given the array [10, 9, 2, 5, 3, 7, 101, 18], the longest increasing subsequence is [2, 3, 7, 101], so the function should return 4.

## Solution Explanation
The solution uses a dynamic programming approach. Here's how it works:

An array dp of the same size as the input is initialized with all elements set to 1. This represents that every element itself can be a subsequence of length 1.

For each element in the input array, we iterate through all previous elements.

If the current element is greater than a previous element (which means we can extend the increasing subsequence), we update dp[i] to be the maximum of its current value and the length of the increasing subsequence ending at the previous number plus one.

The answer will be the maximum value in the dp array, representing the length of the longest increasing subsequence in the input array.

## Code Execution
In order to run the C# code, you can paste the code into a C# environment like Visual Studio, .NET Fiddle, or similar. The code includes a Main method, which runs the algorithm on a test case: the array [10, 9, 2, 5, 3, 7, 101, 18]. The output of the program will be the length of the longest increasing subsequence, which for this test case is 4.


## License
### MIT License

Copyright (c) 2023 Aleksandar Milacic

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.