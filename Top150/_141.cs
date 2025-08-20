namespace Top150;

public class _141
{
  
        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null || fast.next != null)
            {
                if (slow == fast)
                {
                    return true;
                }
                fast = fast.next.next;
                slow = slow.next;
            }

            return false;
        
    }
}

 
