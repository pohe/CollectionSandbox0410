using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Player
    {
        private int _id;  //Unikt id
        private string _name;
        private string _adr;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

       public string Name
       {
            get { return _name; }
            set { _name = value; }
       }


       public string Address
        {
            get { return _adr; }
            set { _adr = value; }
       }

       public Player(int id, string name, string adr)
       {
           _id = id;
           _name = name;
           _adr = adr;
       }

       public override string ToString()
       {
           return $"Id: {_id}  Name: {_name}   Adr: {_adr}";
       }
    }
}
