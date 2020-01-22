using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        public static int count, min, max;
        static void Main()
        {
            Tree t = new Tree();
            t.Add(4);
            t.Add(10);
            t.Add(1);
            t.Add(6);
            t.Add(8);
            t.Contains(23);
        }

        public class Node
        {
            private int value;
            public int GetValue()
            {
                int newValue;
                newValue = value;
                return newValue;
            }
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
                    if (newValue > max) max = Left.GetValue();
                    if (newValue < min) min = Left.GetValue();
                }
                else
                {
                    if (Right == null) Right = new Node(newValue);
                    else Right.Add(newValue);
                    if (newValue > max) max = Right.GetValue();
                    if (newValue < min) min = Right.GetValue();
                }
                
                count++;
            }
            public bool Contains(Node curr, int SrcdVal)
            {
                if (curr.GetValue() != SrcdVal) return true;
                else
                {
                    Contains(curr.Right, SrcdVal);
                    Contains(curr.Left, SrcdVal);
                }
                return false;
            }
            /*public List<int> GetList(List<int> answer)
            {
                Left?.GetList(answer);
                answer.Add(value);
                Right?.GetList(answer);
                return answer;
            }
            public override String ToString() => string.Join(", ", GetList(new List<int>()));*/

            public void Write()
            {
                Left?.Write();
                Console.Write(value + " ");
                Right?.Write();
            }
            public int Count(Node curr)
            {
                count++;
                if (curr.GetValue() == 0) return count;
                else
                {
                    if (Left != null) Count(Left);
                    if (Right != null) Count(Right);
                }
                return count;
            }

        }

        class Tree
        {
            private Node Root;
            public Tree()
            {
                Root = null;
            }
            public void WriteTree(Node Current)
            {
                if (Root != null)
                {
                    Current.Write();
                }
                else Console.Write("no tree");
            }
            public bool Contains(int SrcdVal)
            {
                if (Root == null)
                    return false;

                return Root.Contains(Root, SrcdVal);
            }
            /*public int GetMin(Node curr)
            {
                int min;
                min = curr.GetValue();
                while (curr != null)
                {
                    GetMin(curr.Left);
                }
                return min;
            }
            public int GetMax(Node curr)
            {
                if (Root == null) Console.WriteLine("No tree");
                else Root.Max(Root);
                int max;
                max = curr.GetValue();
                while (curr != null)
                {
                    GetMin(curr.Right);
                }
                return max;
            }
            public void Count(Node curr)
            {
                if (Root == null) Console.Write('0');
                else Root.Count(Root);
            }*/
            public void Add(int newValue)
            {
                if (Root == null)
                {
                    Root = new Node(newValue);
                    max = Root.GetValue();
                    min = Root.GetValue();
                    count++;
                }
                else Root.Add(newValue);
            }
            public int Max()
            {
                return max;
            }
            public int Min()
            {
                return min;
            }
            public int Count()
            {
                return count;
            }
        }

    }
}