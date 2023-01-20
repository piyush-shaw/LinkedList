using LinkedListProblem;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Problem");
        Console.WriteLine("\n1.CreateLinkedList \n2.AddFirstLinkedList");
        LinkedList list = new LinkedList();
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Creating a linked list to add data");
                list.Add(56);
                list.Add(30);
                list.Add(70);
                list.Display();
                break;
            case 2:
                Console.WriteLine("Adding Data in Linked List in first position");
                list.AddFirst(70);
                list.AddFirst(30);
                list.AddFirst(56);
                list.Display();
                break;
            default:
                Console.WriteLine("Please enter correct option ");
                break;
        }
    }
}