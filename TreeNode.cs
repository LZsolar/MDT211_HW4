class TreeNode<T>
{
    private string value;
    private TreeNode<T> next = null;
    private TreeNode<T> child = null;

    public TreeNode(string value)
    {
        this.SetValue(value);
    }

    public void SetNext(TreeNode<T> next)
    {
        this.next = next;
    }

    public void SetChild(TreeNode<T> child)
    {
        this.child = child;
    }

    public TreeNode<T> Next()
    {
        return this.next;
    }

    public TreeNode<T> Child()
    {
        return this.child;
    }

    public string GetValue()
    {
        return this.value;
    }

    public void SetValue(string value)
    {
        this.value = value;
    }
}