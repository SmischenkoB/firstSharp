using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int obj1, obj2;
            //obj1 = Convert.ToInt32(Console.ReadLine());
            //obj2 = Convert.ToInt32(Console.ReadLine());
            // Console.ReadLine();
            Console.WriteLine("cities , amount_roads");
            
           // Map map = new Map(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
           
        }
    }
    class Roads {
     
    }
    class Node {
        bool visited = false;
        int id, value;
        Node parent;
        public Node(int id) {
            this.id = id;
            value = 0;
        }
        public void SetVisited() { visited = true; }
        public int GetId() => id;
        public void SetParent(Node Par) { this.parent = Par; }
        public void SetValue(int val) { this.value = val; }
        public int GetValue() => value;
    }
    class Map {
        private Roads[] roads;
        private Node[] cities;
        
        

    }

}
