// Program that sums two numbers that are stored in a singly linked list

using LinkedList_NumberAddition;
using System.Dynamic;
using System.Xml.Schema;

public class Demo
{
    public static void Main()
    {
        // The numbers to add stored in the form of an array
        int[] number1 = new int[] { 9, 9, 9, 9, 9, 9, 9 }; // {2,4,3}, {0}
        int[] number2 = new int[] { 9, 9, 9, 9 }; // {5,6,4}, {0}

        // Putting each number into a linked list
        ListNode l1 = new ListNode();
        l1 = ArrayToList(number1, l1);

        ListNode l2 = new ListNode();
        l2 = ArrayToList(number2, l2);

        // Addition and the final result
        ListNode result = AddNumbers(l1, l2);

        //Displaying the results
        ListNode temp = result;
        string answer = "";
        while(temp != null)
        {
            answer = temp.val + answer;
            temp = temp.next;
        }
        Console.WriteLine("Answer: " + answer);

    }

    // Method to convert the number stored in an array to a linked list
    public static ListNode ArrayToList(int[] array, ListNode l)
    {
        ListNode temp = l;
        temp.val = array[array.Length - 1];
        for (int i = array.Length - 2; i >= 0; i--)
        {
            temp.next = new ListNode();
            temp = temp.next;

            temp.val = array[i];
        }

        return l;
    }

    // Recursive method to add the numbers stored in the linked lists
    public static ListNode AddNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        // Check for nullity
        if (l1 == null && l2 == null && carry == 0)
            return null;

        // The sum of the two digits
        int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;

        // The new digit formed that is a part of the summed answer
        int total = sum % 10;

        // The number to be carried over to the next sum of the digits
        carry = (sum - total) / 10;

        // Call the method again to sum the next digits
        // Traverses to the next digits stored in the linked lists
        ListNode nextNum = AddNumbers(l1?.next, l2?.next, carry);

        return new ListNode(total, nextNum);
    }
}
