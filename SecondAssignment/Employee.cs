using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    public abstract class Employee
    {
        public abstract void Register(int n);
        public abstract void Updates(int n, int t);
        public MyArray<string> id = new MyArray<string>(100);
        public MyArray<string> name = new MyArray<string>(100);
        public MyArray<string> Street1 = new MyArray<string>(100);
        public MyArray<string> Street2 = new MyArray<string>(100);
        public MyArray<string> area = new MyArray<string>(100);
        public MyArray<string> city = new MyArray<string>(100);
        public MyArray<string> pincode = new MyArray<string>(100);
        public MyArray<string> extra1 = new MyArray<string>(100);
        public MyArray<string> extra2 = new MyArray<string>(100);
        public MyArray<string> extra3 = new MyArray<string>(100);
        public MyArray<string> extra4 = new MyArray<string>(100);
    }
}
