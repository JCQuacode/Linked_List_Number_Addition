using LinkedList_NumberAddition;

public class Demo
{
    public static void Main()
    {
        // The numbers to add stored in the form of an array

        int[] number1 = new int[] { 3,4,2 };
        int[] number2 = new int[] { 4,6,5 };

        // Putting each number into a linked list

        ListNode l1 = new ListNode();
        l1 = ArrayToList(number1, l1);

        ListNode l2 = new ListNode();
        l2 = ArrayToList(number2, l2);

        // Adding the numbers stored in the linked list


    }

    public static ListNode ArrayToList(int[] array, ListNode l)
    {
        ListNode temp = l;
        for (int i = 0; i < array.Length; i++)
        {
            temp.val = array[i];

            temp.next = new ListNode();
            temp = temp.next;
        }
        temp = null;

        return l;
    }

    public static ListNode AddNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();



    }
}
