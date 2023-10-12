using System;


namespace R5T.T0221
{
    public class ElementTypeRelationshipOperator : IElementTypeRelationshipOperator
    {
        #region Infrastructure

        public static IElementTypeRelationshipOperator Instance { get; } = new ElementTypeRelationshipOperator();


        private ElementTypeRelationshipOperator()
        {
        }

        #endregion
    }
}
