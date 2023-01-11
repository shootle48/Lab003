using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003
{
    internal class Student
    {
        public string _name;
        public string _ID;
        public int _birth;
        public double _height;
        public double _garde;
        public string _field;

        public string NAME
        {
            get { return _name; }
        }
        public string ID
        {
            get { return _ID; }
        }

        public int Birth
        {
            get { return _birth; }
        }

        public double Height
        {
            get { return _height; }
        }

        public double Garde
        {
            get { return _garde; }
        }

        public string Field
        {
            get { return _field; }
        }

        public Student(string name, string id, int birth, double height,double garde, string field)
        {
            this._name = name;
            this._ID = id; 
            this._birth = birth;
            this._height = height;
            this._garde= garde;
            this._field = field;
        }
    }
}
