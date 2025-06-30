using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    internal class listed
    {
        public Notes Head{  get; set; }
        public listed()
        {
            Head = null;
        }
        public listed(string data)
        {
                Head= new Notes(data);
        }
        public void AddStart(string data)
        {
            if(Head == null)
            {

                Head = new Notes(data);

             }
            else
            {
                Notes node =new Notes(data);
                node.next = Head;
                Head = node;
            }
        }
        private Notes Last()
        {
            Notes node =Head;
            while(node != null)
            {
                node = node.next;
            }
            return node;
        }
        public void AddEnd(string data)
        {
            if(Head == null)
            {
                Head = new Notes(data);
            }
            else
            {
                Last().next = new Notes(data);
            }
        }
        public override string ToString()
        {
            string linkedlist = "";
            Notes node = Head;
            while(node != null)
            {
                linkedlist += node.Data + " --> ";
                node = node.next;
               
            }
            return linkedlist;
        }
        public void Delete(string data)
        {
            if (Head.Data == data)
            {
               Head = Head.next;
            }
            else
            {
                Notes node = Head;
                while(node.next != null)
                {
                    if(node.next.Data == data)
                    {
                        if (node.next != Last())
                            node.next = node.next.next;
                        else node.next = null;
                    }
                }
            }
        }


    }
}
