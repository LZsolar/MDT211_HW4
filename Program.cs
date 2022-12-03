class Program
{
    static void Main(string[] args)
    {
        Tree<string> tree = new Tree<string>();
        tree.addRoot();

        int countMember=0;
        while(true){
            string name = Console.ReadLine();
            int node = int.Parse(Console.ReadLine());

            tree.addToTree(name,node);

            countMember++;
            if(tree.GetLength()==countMember){break;}
        }
        string vacationName = Console.ReadLine();
        Stack<string> boss = new Stack<string>();
        bool isFind = false;
        tree.FindVacation(tree.getRoot(),vacationName,ref boss,ref isFind);
    }
}