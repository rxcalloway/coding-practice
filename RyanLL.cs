 public class Node
{
    public int number;
    public Node next;

    public Node()
    {
        number = 0;
        next = null;
    }
}
            
public class RyanLL
{
    public Node head;
    public Node tail;

    public RyanLL()
    {
        head = null;
        tail = null;
    }

    public RyanLL(int head_number)
    {
        Node n = new Node();
        n.number = head_number;
        n.next = null;
        head = n;
        tail = n;
    }

    public void AddNode(int local_number)
    {
        Node n = new Node();
        n.number = local_number;

        if (head == null)
        {
            head = n;
            tail = n;
            return;
        }

        tail.next = n;
        tail = n;
    }

public bool RemoveNode(int target)
{
    if (head == null) return false;
    if (head == tail)
    {
        head = null;
        tail = null;
        return true;
    }

    //TODO: Clean up code, looks messy

    Node n = head;
    if (n.number == target)
    {
        head = head.next;
        return true;
    }

    while (n != null && n.next.number != target)
    {
        n = n.next;
    }

    if (n == null) return false;
    if (n.next == tail)
    {
        n.next = null;
        tail = n;
        return true;
    }

    Node temp = n.next.next;
    n.next.next = null;
    n.next = temp;

    return true;
}

    public void PrintValues()
    {
        Node n = new Node();
        n = head;

        while (n != null)
        {                        
            Console.WriteLine(n.number);
            n = n.next;
        }
    }                                                                                                    
}
