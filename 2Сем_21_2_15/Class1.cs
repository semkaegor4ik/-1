﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Сем_21_2_15
{
    public class BinaryTree	//класс, реализующий АТД «дерево бинарного поиска со счетчиком вершин в дереве»
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного
        //поиска
        private class Node
        {
            public object inf;	//информационное поле
            public int counter;
            public Node left;	//ссылка на левое поддерево
            public Node rigth;	//ссылка на правое поддерево

            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                counter = 1;
                left = null;
                rigth = null;
            }

            //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
            public static void Add(ref Node r, object nodeInf)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    r.counter++;
                    if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                    {
                        Add(ref r.left, nodeInf);
                    }
                    else
                    {
                        Add(ref r.rigth, nodeInf);
                    }
                }
            }

            public static void Preorder(Node r)	//прямой обход дерева
            {
                if (r != null)
                {
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                    Preorder(r.left);
                    Preorder(r.rigth);
                }
            }

            public static void Inorder(Node r)	//симметричный обход дерева
            {
                if (r != null)
                {
                    Inorder(r.left);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                    Inorder(r.rigth);
                }
            }

            public static void Postorder(Node r)	//обратный обход дерева
            {
                if (r != null)
                {
                    Postorder(r.left);
                    Postorder(r.rigth);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                }
            }


            public static void Part(ref Node t, int k)
            {
                int x = (t.left == null) ? 0 : t.left.counter;
                if (x > k)
                {
                    Part(ref t.left, k);
                    RotationRigth(ref t);
                    //Console.WriteLine("Ротация вправо");
                }
                if (x < k)
                {
                    Part(ref t.rigth, k - x - 1);
                    //Console.WriteLine("Ротация влево");
                    RotationLeft(ref t);
                }
                //if (x == k) Console.WriteLine("Выбран элемент ({0}, {1})", t.inf, t.counter); 
            }



            public static void Balancer(ref Node t)
            {
                if (t == null || t.counter == 1) return;
                Part(ref t, t.counter / 2);
                //Preorder(t);
                //Console.WriteLine();
                Balancer(ref t.left);
                Balancer(ref t.rigth);

            }

            //неявная балансировка дерева бинарного поиска
            public static void InsertRandom(ref Node r, object nodeInf, Random rnd)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    if (rnd.Next() < int.MaxValue / (r.counter + 1))
                    {
                        InsertToRoot(ref r, nodeInf);
                    }
                    else
                    {
                        r.counter++;
                        if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                        {
                            InsertRandom(ref r.left, nodeInf, rnd);
                        }
                        else
                        {
                            InsertRandom(ref r.rigth, nodeInf, rnd);
                        }
                    }
                }
            }

            //поиск ключевого узла в дереве
            public static void Search(Node r, object key, out Node item)
            {
                if (r == null)
                {
                    item = null;
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        item = r;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            Search(r.left, key, out item);
                        }
                        else
                        {
                            Search(r.rigth, key, out item);
                        }
                    }
                }
            }

            //самоорганизующийся поиск ключевого узла в дереве
            public static void SearchToRoot(ref Node r, object key)
            {
                if (r != null)
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            SearchToRoot(ref r.left, key);
                            RotationRigth(ref r);

                        }
                        else
                        {
                            SearchToRoot(ref r.rigth, key);
                            RotationLeft(ref r);
                        }
                    }
                }
            }

            public static void Count(ref Node r)
            {
                r.counter = 1;
                if (r.left != null) r.counter += r.left.counter;
                if (r.rigth != null) r.counter += r.rigth.counter;
            }

            public static void RotationRigth(ref Node t)
            {
                Node x = t.left;
                t.left = x.rigth;
                x.rigth = t;

                Count(ref t);
                Count(ref x);

                t = x;


            }

            public static void RotationLeft(ref Node t)
            {
                Node x = t.rigth;
                t.rigth = x.left;
                x.left = t;

                Count(ref t);
                Count(ref x);

                t = x;


            }

            public static void InsertToRoot(ref Node t, object item)
            {
                if (t == null)
                {
                    t = new Node(item);
                }
                else
                {
                    t.counter++;
                    if (((IComparable)(t.inf)).CompareTo(item) > 0)
                    {
                        InsertToRoot(ref t.left, item);
                        RotationRigth(ref t);
                    }
                    else
                    {
                        InsertToRoot(ref t.rigth, item);
                        RotationLeft(ref t);
                    }
                }
            }

            public static bool Func(ref Node t, int n,ref int c, ref int count, ref List<int> a)
            {
                while(c!=0)
                {
                    t.left
                    c--;
                }
                return true;
            }

            public static void HeigthTree(Node t, ref int count, ref int heigth)
            {
                if (t != null) // если текущий узел не пустой
                {
                    if (count > heigth) //и длина пути от корня до текущего узла больше высоты дерева, то
                    {
                        heigth = count; // полагаем в качестве высоты дерева длину пути до текущего узла
                    }
                    count++; // в любом случае увеличиваем длину пути от корня до текущего узла
                    HeigthTree(t.left, ref count, ref heigth); //обходим левое поддерево
                    HeigthTree(t.rigth, ref count, ref heigth); //обходим правое поддерево
                    count--; //после чего уменьшаем длину пути от корня до текущего узла
                }
            }

        }		//конец вложенного класса

        Node tree;		//ссылка на корень дерева

        //свойство позволяет получить доступ к значению информационного поля корня дерева 
        public object Inf
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        public int Counter
        {
            get { return tree.counter; }

        }

        public void Func(int n)
        {
            int heigth = HeigthTree();
            List<int> list = null;
            int count = 0;
            bool flag= Node.Func(ref tree, n,ref heigth, ref count, ref list);
            if(flag)
            {

            }
            else
            {

            }
        }

        public int HeigthTree()
        {
            int count = 0;
            int heigth = 0;
            Node.HeigthTree(tree, ref count, ref heigth); //начинаем подсчет высоты с корня дерева
            return heigth;
        }


        public BinaryTree()	//открытый конструктор
        {
            tree = null;
        }

        private BinaryTree(Node r) //закрытый конструктор
        {
            tree = r;
        }

        public void Add(object nodeInf)	//добавление узла в дерево
        {
            Node.Add(ref tree, nodeInf);
        }

        //организация различных способов обхода дерева
        public void Preorder()
        {
            Node.Preorder(tree);
        }

        public void Inorder()
        {
            Node.Inorder(tree);
        }

        public void Postorder()
        {
            Node.Postorder(tree);
        }

        //поиск ключевого узла в дереве
        public BinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BinaryTree t = new BinaryTree(r);
            return t;
        }

        //Самоорганизующийся поиск ключевого узла в дереве
        public void SearchToRoot(object key)
        {
            Node.SearchToRoot(ref tree, key);


        }


        public void InsertToRoot(object item)
        {
            Node.InsertToRoot(ref tree, item);
        }


        public void Balancer()
        {
            Node.Balancer(ref tree);

        }
        public void InsertRandom(object nodeInf)
        {
            Random rnd = new Random();
            Node.InsertRandom(ref tree, nodeInf, rnd);
        }


    }
}
