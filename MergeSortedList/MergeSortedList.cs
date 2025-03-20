namespace LeetCode;

public class ListNode
{
    public int value { get; set; }
    public ListNode? next { get; set; }

    public ListNode()
    {
        
    }
    public ListNode(int value)
    {
        this.value = value;
        this.next = null;
    }

    public ListNode(int value, ListNode next)
    {
        this.value = value;
        this.next = next;
    }

   
}

public class MergeSortedList
{
    public ListNode MergeSortedLists2(ListNode? node1, ListNode? node2)
    {
        var head = node2;
        var temp = node2;
        if (node2 != null && node1 != null && node1.value <= node2.value)
        {
            head = node1;
            temp = node1;
            node1 = node1.next;
        }
        else
        {
            node2 = node2.next;
        }
        while (node2 != null && node1 != null)
        {
            if (node1.value <= node2.value)
            {
                temp.next = node1;
                node1 = node1.next;
                
            }

            else if (node1.value > node2.value)
            {
                temp.next = node2;
                node2 = node2.next;
            }
            temp = temp.next;
        }
        if (node1 != null)
        {
            temp.next = node1;
        }
        if (node2 != null)
        {
            temp.next = node2;
        }
        return head;
    }
    public ListNode MergeSortedLists(ListNode? node1, ListNode? node2)
    {
        ListNode ret = new ListNode();
        var temp = ret;
        while (node1 != null && node2 != null)
        {
            if (node1.value <= node2.value)
            {
                ret.value = node1.value;
                ret.next = new ListNode();
                node1 = node1.next;
                ret = ret.next;
            }

            else if (node1.value > node2.value)
            {
                ret.value = node2.value;
                ret.next = new ListNode();
                node2 = node2.next;
                ret = ret.next;
            }
            
        }

        if (node1 != null)
        {
            ret.value = node1.value;
            ret.next = node1.next;
        }
        if (node2 != null)
        {
            ret.value = node2.value;
            ret.next = node2.next;
        }
        
        return temp;
    }
}