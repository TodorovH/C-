namespace Problem7ImplementALinkedList
{
    public class ListNode
    {
        private object data;
        private ListNode next;

        public ListNode(object data, ListNode next)
        {
            this.data = data;
            this.next = next;
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public ListNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}