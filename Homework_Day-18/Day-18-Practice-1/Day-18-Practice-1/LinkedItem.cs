using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day_18_Practice_1
{
    public class LinkedItem<T> : ILinkedItem<T>
    {
        public class Node<T>
        {
            // შემდეგი წვეროს მისამართი
            public Node<T> next = null;
            // მონაცემი
            public T data;
        }

        private Node<T> root = null;

        public Node<T> Root
        {
            get
            {
                return root;
            }
        }
        public T this[int index]
        {

            get
            {
                
                    Node<T> current = root;
                    int count = 0;
                    while (current != null)
                    {
                        if (count == index)
                            return current.data;
                        count++;
                        current = current.next;
                    }

                    throw new Exception("Index not found");
                
             
            }
            set
            {
                //Node<T> n = new Node<T> { data = value };
                //if (root == null)
                //{
                //    root = n;
                //}
                //else
                //{
                //    Node<T> curr = root;
                //    while (curr.next != null)
                //    {
                //        curr = curr.next;
                //    }
                //    curr.next = n;
                //}
                try
                {
                    AddItem(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
                

            }
        }
        public bool Exists()
        {
            return root != null;
        }

        public void AddItem(T value)
        {
            Node<T> n = new Node<T> { data = value };
            if (root == null)
            {
                root = n;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }
        }

        public void RemoveItem(T data)
        {
            if (root != null && Object.Equals(root.data, data))
            {
                var node = root;
                root = node.next;
                node.next = null;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    if (Object.Equals(curr.next.data, data))
                    {
                        var node = curr.next;
                        curr.next = node.next;
                        node.next = null;
                        break;
                    }

                    curr = curr.next;
                }
            }
        }

        public void PrintItems()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                Console.WriteLine($"data : {curr.data.ToString()}");
                curr = curr.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                yield return curr.data;
                curr = curr.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
