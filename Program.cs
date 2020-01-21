using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main()
        {

        }
        class Tree
        {
            public class Node
            {
                private int value;
                public Node Left { get; private set; }
                public Node Right { get; private set; }
                public Node(int value)
                {
                    this.value = value;
                    Left = null;
                    Right = null;
                }
                public void Add(int newValue)
                {
                    if (value >= newValue)
                    {
                        if (Left == null) Left = new Node(newValue);
                        else Left.Add(newValue);
                    }
                    else
                    {
                        if (Right == null) Right = new Node(newValue);
                        else Right.Add(newValue);
                    }
                }
                public List<int> GetList(List<int> answer)
                {
                    Left?.GetList(answer);
                    answer.Add(value);
                    Right?.GetList(answer);
                    return answer;
                }
                public override String ToString() => string.Join(", ", GetList(new List<int>()));

            }


            public Node Root { get; private set; }
            public void WriteTree(Node Current)
            {
                if (Current != null)
                {
                        WriteTree(Current.Left);
                        Console.Write(Current.value);
                        WriteTree(Current.Right);
                }
            }
            public bool IsNode(int SrcdVal, Node node_)
            {
                if (node_.value == SrcdVal) return true;
                else
                {
                    IsNode(SrcdVal, node_.Left);
                    IsNode(SrcdVal, node_.Right);
                }
                return false;
            }
            public int GetMin(Node curr)
            {
                int min;
                min = curr.value;
                while(curr!=null)
                {
                    GetMin(curr.Left);
                }
                return min;
            }
            public int GetMax(Node curr)
            {
                int max;
                max = curr.value;
                while (curr != null)
                {
                    GetMin(curr.Right);
                }
                return max;
            }
            public int Count(Node curr)
            {
                int count=0;
                count++;
                if (curr != null)
                {
                    Count(curr.Left);
                    Count(curr.Right);
                }
                return count;
            }
        }

    }
}
