using System;
using System.Collections.Generic;

namespace Challenge_1
{
    public class Stacx
    {
        private int _counter = 0;
        private List<object> _list = new List<object>();

        public void Push(object objData)
        {
            if (objData == null) throw new InvalidOperationException("Null Value can't be Inserted.");

            _list.Add(objData);
            _counter++;
        }

        public void Pop()
        {
            if (_counter <= 0) throw new InvalidOperationException("Stack is Empty.");

            _list.RemoveAt(_counter - 1);
            _counter--;
        }

        public void ShowAll()
        {
            if (_counter <= 0) throw new InvalidOperationException("Stack is Empty.");

            for (int i = 0; i < _counter; i++)
            {
                Console.Write("{0} ", _list[i]);
            }
            Console.WriteLine();
        }

        public void Clear()
        {
            if (_counter <= 0) throw new InvalidOperationException("Stack is Empty.");

            for (int i = _counter; i >= 0; i--)
            {
                _list.RemoveAt(_counter - 1);
            }
        }
    }

    class Program
    {
        static char MenuInput()
        {
            Console.Write("\nStack Initiated\n\tPress 1 - To Push Any value\n\tPress 2 - To Pop Last value\n\tPress 3 - To Clear\n\tPress X - For Exit.\nWhat Your Choice? ");

            return Convert.ToChar(Console.Read());
        }

        static int GetUserInput(Stacx BigList)
        {
            Console.Write("\n\tEnter the Value: ");
            string val = Console.ReadLine();

            BigList.Push(val);
            return 1;
        }

        static int RemoveUserInput(Stacx BigList)
        {
            BigList.Pop();
            return 2;
        }

        static int ClearAll(Stacx BigList)
        {
            BigList.Clear();
            return 3;
        }

        static void Main(string[] args)
        {
            var BigList = new Stacx();
            // BigList.Pop();
            BigList.Push(5);
            BigList.Push(null);
            BigList.Push("Nine");
            BigList.Push('K');
            BigList.Push(true);
            // BigList.Clear();
            BigList.ShowAll();

            // Console.Write("Start The Stack: ");
            // while (Console.ReadKey(true).Key != ConsoleKey.X)
            // {
            //     char letter;

            //     do
            //     {
            //         letter = MenuInput();

            //         switch (letter)
            //         {
            //             case '1':
            //                 Console.Write("\n\tEnter the Value: ");
            //                 string val = Console.ReadLine();
            //                 break;
            //             case '2':
            //                 RemoveUserInput(BigList);
            //                 break;
            //             case '3':
            //                 ClearAll(BigList);
            //                 break;
            //             case 'x':
            //                 Environment.Exit(1);
            //                 break;
            //             default:
            //                 break;
            //         }
            //     } while (letter != 'x');
            // }
        }
    }
}
