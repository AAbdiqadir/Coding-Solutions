// See https://aka.ms/new-console-template for more information


using System.Security.AccessControl;

public class Node {
    public int data;
    public Node next;
    public Node(int d) {
        data = d;
        next = null;
    }
}

public class SingleLinkedList { 
    private Node head;

    
    public void InsertInOrder(int data)
    {
        Node newNode = new Node(data);

        if (head == null )
        {
            head = newNode;
            return;
        }
            // Case 2: Traverse the list to find the correct position for the new node
        Node current = head;

        while (current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;

        // Insert the new node at the correct position

        }

    public void remove(int data)
    {
        Node slow = head;
        Node fast = slow.next;

        // if (head.data == data)
        // {
        //     head = null;
        //     return;
        // }

        while ( fast.data != data)
        {
            slow = slow.next;
            fast = fast.next;
        }

        if (fast != null)
        {
            slow.next = fast.next;
            fast = null;
        }
       


    }

    public Node reverse(Node head)
    {
        Node prev = null;
        

        while (head != null)
        {
            Node next = head.next;

            head.next = prev;

            prev = head;
            
            
            
            
            head = next;
           

        }

      

        return prev;


    }

    public void reorderList()
    {
        Stack<Node> q = new Stack<Node>();

        Node current = head;
        Node prev = null;
        Node slow = head;
        Node fast = head;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next; 
        }

        prev.next = null;

        Node reverse_ = reverse(slow);
       
       while ( current != null && reverse_ != null)
        {
            Node reverse = reverse_.next;
            Node cunext = current.next;

            current.next = reverse_;

            if (cunext == null)
            {
                break;
            }

            

            reverse_.next = cunext;
            
            
            current = cunext;
            
            reverse_ = reverse;


        }

    }

    public void RemoveNode(int data)
    {
        List<Node> list = new List<Node>();
        Node current = head;
        Node prev = null;
        Node slow = head;
        
        

        while (current != null)
        {
            list.Add(current);
            current = current.next;
        }
        
        int count =(list.Count()) - data;

        if (count == 0)
        {
            head = slow.next;

            slow = null;
            
        
            return;
            
        }
       
        while (count > 0)
        {
            prev = slow;
            slow = slow.next;
            count--;
        
        }

        prev.next = slow.next;
        
        slow = null;
        
        
        



    }
    

    public void print(Node head)
    {
        Node current = head;

        while ( current!= null)
        {
            System.Console.WriteLine(current.data);
            current = current.next;
            
            
        }
    }
    
    //
    // public static void Main(String[] args)
    // {
    //     SingleLinkedList list = new SingleLinkedList();
    //
    //     // Insert numbers in the list
    //     list.InsertInOrder(1);
    //     list.InsertInOrder(2);
    //     list.InsertInOrder(3);
    //     list.InsertInOrder(4);
    //     list.InsertInOrder(5);
    //     
    //     
    //     
    //     list.RemoveNode(1);
    //     
    //     list.print(list.head);
    //     
    //
    // }


}