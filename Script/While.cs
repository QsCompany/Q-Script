using System;


namespace QsScript {


	[Serializable]
    public class While : Expression
    {
        public Expression body;
        public Expression test;
        public While()
        {

        }
        public While(Expression test, Expression body)
        {
            this.test = test;
            this.body = body;
        }
        protected override BasicObject calc()
        {
            BasicObject r = Void.Value;
            while (test.Calc().ToNumbre<bool>())
            {
                r = body.Calc();
                if (IsBreak) return VM.StopBreak();
                if (IsReturn) return r;
            }
            return r;
        }
    }


}