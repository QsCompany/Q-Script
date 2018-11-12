using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QsScript {


	[Serializable]
    public class Bloc : Expression
    {
        public List<Expression> instructions = new List<Expression>();
        public Bloc()
        {

        }
        public Bloc Add(Expression exp)
        {
            instructions.Add(exp);
            return this;
        }
        public Bloc Add(Expression[] exp)
        {
            instructions.AddRange(exp);
            return this;
        }




        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

        }

        protected override BasicObject calc()
        {
            BasicObject r = Void.Value;
            foreach (var exp in instructions)
            {
                r = exp.Calc();
                if (IsReturn)
                    return r;
                else if (IsBreak)
                    break;
            }
            return r;
        }


    }

}