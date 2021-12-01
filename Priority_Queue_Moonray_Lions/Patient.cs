using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue_Moonray_Lions
{
    class Patient
    {
        private string _name;
        private int _priority;
        private Patient _next;
        private Patient _prev;
        


        public Patient(string name, int priority)
        {
            _name = name;
            _priority = priority;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Patient Next
        {
            get { return _next; }
            set { _next = value; }
        }
        public Patient Privious
        {
            get { return _prev; }
            set { _prev = value; }

        }
    }
}
