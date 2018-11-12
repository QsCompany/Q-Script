using System;


namespace QsScript {


    [Serializable]
    public class Parent : Expression
    {
        public Expression L;
        public Operation Op;
        public Expression R;
        public Parent()
        {

        }
        public Parent(Expression l, Operation op, Expression r)
        {
            L = l;
            R = r;
            Op = op;
        }

        protected override BasicObject calc()
        {
            BasicObject l = L.Calc();
            return l.Calc(Op, R.Calc());
        }
    }

}