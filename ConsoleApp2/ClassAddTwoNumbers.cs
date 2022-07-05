using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ClassAddTwoNumbers
    {
        public static ListNode head = new ListNode();
        public static ListNode list = new ListNode();
        public static ClassAddTwoNumbers GetSet()
        {
            ClassAddTwoNumbers classAdd= new ClassAddTwoNumbers();
          
            list.val = 3;
            list.val = 4;
            list.val = 5;
          
            head.val = 4;
            head.val = 1;
            head.val = 2;

            ListNode list2 = classAdd.AddTwoNumbers(list, head);

            Console.WriteLine(list2.next.val);
            return classAdd;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            while (l1.next!=null && l2.next!=null)
            {
                result.val = (l1.val + l2.val) % 10;
            }
           
            return result;
        }
    }

    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}
