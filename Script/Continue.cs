using System;


namespace QsScript {

	[Serializable]
    public class Continue : Expression
    {
        public Continue()
        {

        }
        protected override BasicObject calc()
        {
            throw new NotImplementedException();
        }
    }
 

}