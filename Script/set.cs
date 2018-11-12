using System;


namespace QsScript {


    [Serializable]
    public class set : Expression
    {
        public FieldPath Path;
        public Expression Value;
        public set()
        {

        }
        public set(Expression @this, string name, Expression s)
        {
            Path = new FieldPath(@this, name);
            Value = s;
        }
        public set(FieldPath path, Expression s)
        {
            Path = path;
            Value = s;
        }

        protected override BasicObject calc()
        {
            BasicObject c = Value.Calc();
            (Path.This?.Calc() ?? VM.CurrentScop).SetData(Path.Name, c);
            return c;
        }
    }


}