namespace ImpelementStackUsingQueue;

public class MyStack {
    private bool first;
    private Queue<int> firstQueue;
    private Queue<int> secondQueue;
    private int top;

    public MyStack() {
        // 1 2 3 4 5
        // 1 2 3 4 5
        this.firstQueue = new Queue<int>();
        this.secondQueue = new Queue<int>();
        this.first = true;
        

    }
    
    public void Push(int x) {
        if (this.first)
        {
            this.firstQueue.Enqueue(x);
        }
        else
        {
            this.secondQueue.Enqueue(x);
        }

        top = x;
    }
    
    public int Pop()
    {
        int item = 0;
        if (first)
        {
            while (this.firstQueue.Count > 1)
            {
                item = firstQueue.Dequeue();
                this.secondQueue.Enqueue(item);
                if (firstQueue.Count == 1)
                {
                    top = item;
                }
                    
            }

            item = firstQueue.Dequeue();
            first = false;
        }
        else
        {
            while (secondQueue.Count > 1)
            {
                item = secondQueue.Dequeue();
                firstQueue.Enqueue(item);
                if (secondQueue.Count == 1)
                {
                    top = item;
                }
            }

            item = secondQueue.Dequeue();
            first = true;
        }

        return item;
    }
    
    public int Top()
    {
        return top;
    }
    
    public bool Empty() {
        if (first)
        {
            return firstQueue.Count == 0;
        }

        return secondQueue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */