# LinkedList_NumberAddition

## Question

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

 

### Example 1:

![image](https://github.com/JCQuacode/Linked_List_Number_Addition/assets/122890528/f100c7ec-6939-49e3-a24d-f3e07814f646)

Input: l1 = [2,4,3], l2 = [5,6,4]  
Output: [7,0,8]  
Explanation: 342 + 465 = 807.  

### Example 2:
Input: l1 = [0], l2 = [0]  
Output: [0]  

### Example 3:  
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]  
Output: [8,9,9,9,0,0,0,1]  
 

### Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.

## Solution

- Using 3 parameters (Node1, Node2, Carry)
- Using a recursive method to make the solution nice and compact.

- For a number such as 346 and 465 that would be stored as [6,4,3] and [5,6,4] in the linked list.
- Take the first digits of the numbers from the left, i.e, 6 and 5.
- Now add those digits, 6 + 5 = 11.
- Carry the 1 since it's greater than 9.
- Pass 1 in the parameter for the recursive method.
- Take the carried 1 and add it to the sum of the next two digits from the left.

- Check for null values later on.
