namespace Top150;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class _2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode();
        var carry = 0;
        var tempResult = result;
        while (l1 != null && l2!=null)
        {
            var tempVal = 0;
            if (l1.val + l2.val +carry > 9)
            {
                
                tempVal = (l1.val + l2.val+carry) - 10;
                carry = 1;
            }
            else
            {
                
                tempVal = l1.val + l2.val+carry;
                carry = 0;
            }
           
            result.val = tempVal;
            if (l1.next != null || l2.next != null)
            {
                result.next = new ListNode();
                result = result.next;
            }
            l1 = l1.next;
            l2 = l2.next;
        }

        while (l1 != null)
        {
            var tempVal = 0;
            if (l1.val + carry > 9)
            {
                
                tempVal = (l1.val +carry) - 10;
                carry = 1;
            }
            else
            {
                tempVal = l1.val + carry;
                carry = 0;
            }
           
            result.val = tempVal;
            if (l1.next != null)
            {
                result.next = new ListNode();
                result = result.next;
            }
            l1 = l1.next;
        }

        while (l2 != null)
        {
            var tempVal = 0;
            if (l2.val + carry > 9)
            {
                
                tempVal = (l2.val +carry) - 10;
                carry = 1;
            }
            else
            {
                tempVal = l2.val + carry;
                carry = 0;
            }
           
            result.val = tempVal;
            if (l2.next != null)
            {
                result.next = new ListNode();
                result = result.next;
            }
            l2 = l2.next;
        }

        if (carry == 1)
        {
            result.next = new ListNode(1);
        }
        return tempResult;
    }
}