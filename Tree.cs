class Tree<T>
{
    private TreeNode<T> root = null;
    private int length = 0;

    public int GetLength()
    {
        return this.length;
    }
    public void addRoot(){
        TreeNode<T> node = new TreeNode<T>(null);
        this.root = node;
        this.length++;
    }
    public TreeNode<T> getRoot(){
        return this.root;
    }

    public void addToTree(string name,int underMember){
        int traverseStep = this.length;
        TreeNode<T> ptr = FindNullNode(this.root,ref traverseStep);

        ptr.SetValue(name);
        for(int i=1;i<=underMember;i++){
            TreeNode<T> node = new TreeNode<T>(null);
            if(i==1){ptr.SetChild(node); ptr=ptr.Child();}
            else{ptr.SetNext(node);ptr=ptr.Next();}
            this.length++;
        }
    }

    private TreeNode<T> FindNullNode(TreeNode<T> currentTreeNode, ref int traverseStep)
    {
        TreeNode<T> ptr = currentTreeNode;

        if(ptr.GetValue()==null){traverseStep=0; return ptr;}

        if(traverseStep > 0 && currentTreeNode.Child() != null)
        {
            traverseStep++;
            ptr = this.FindNullNode(currentTreeNode.Child(), ref traverseStep);
        }

        if(traverseStep > 0 && currentTreeNode.Next() != null)
        {
            ptr = this.FindNullNode(currentTreeNode.Next(), ref traverseStep);
        }

        return ptr;
    }

    public void FindVacation(TreeNode<T> currentTreeNode,string name,ref Stack<string> boss,ref bool isFind)
    {
        TreeNode<T> ptr = currentTreeNode;
        Stack<string> listboss = boss;

        if(ptr.GetValue()==name){ 
            while(listboss.GetLength()>0){
                Console.WriteLine(listboss.Pop());
            }
            
            return;
        }

        if(currentTreeNode.Child() != null&&!isFind)
        {
           listboss.Push(ptr.GetValue());
            this.FindVacation(currentTreeNode.Child(),name,ref listboss,ref isFind);
            if(listboss.GetLength()!=0){listboss.Pop();}
        }

        if(currentTreeNode.Next() != null&&!isFind)
        {
            this.FindVacation(currentTreeNode.Next(),name,ref listboss,ref isFind);
        }

        return;
    }
}