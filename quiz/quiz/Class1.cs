using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface IQestion
    {
        bool Validation();
        object Conservation();
        bool IsDeleted { get; set; }
    }
    public abstract class Qestion : IQestion
    {
        public string str;
        public abstract bool Validation();
        public object Conservation()
        {
            return this.MemberwiseClone();
        }
        public bool IsDeleted { get; set; }
    }
    public class TextAr:Qestion
    {
        public override bool Validation()
        {
            throw new NotImplementedException();
        }
    }
    public class MandatoryChoice : Qestion
    {
        enum E { };
        int chcked;
        public override bool Validation()
        {
            throw new NotImplementedException();
        }
    }
    public class MultipleChoice : Qestion
    {
        enum E { };
        int[,] chcked = new int[E.GetNames(typeof(E)).Length,2];
        public override bool Validation()
        {
            throw new NotImplementedException();
        }
    }






}
