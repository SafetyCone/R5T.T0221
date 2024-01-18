using System;

using R5T.T0132;


namespace R5T.T0221
{
    [FunctionalityMarker]
    public partial interface IElementTypeRelationshipOperator : IFunctionalityMarker
    {
        public string Append_ElementTypeRelationshipMarkers(
            string typeName,
            ElementTypeRelationships elementTypeRelationships,
            string arrayMarker,
            string referenceMarker,
            string pointerMarker)
        {
            var isArray = Instances.FlagsOperator.Has_Flag(elementTypeRelationships, ElementTypeRelationships.Array);
            if(isArray)
            {
                typeName += arrayMarker;
            }

            var isReference = Instances.FlagsOperator.Has_Flag(elementTypeRelationships, ElementTypeRelationships.Reference);
            if (isReference)
            {
                typeName += referenceMarker;
            }

            var isPointer = Instances.FlagsOperator.Has_Flag(elementTypeRelationships, ElementTypeRelationships.Pointer);
            if (isPointer)
            {
                typeName += pointerMarker;
            }

            return typeName;
        }

        public ElementTypeRelationships Get_ElementTypeRelationship(Type type)
        {
            var output = ElementTypeRelationships.None;

            if (type.IsArray)
            {
                output |= ElementTypeRelationships.Array;
            }

            if (type.IsByRef)
            {
                output |= ElementTypeRelationships.Reference;
            }

            if (type.IsPointer)
            {
                output |= ElementTypeRelationships.Pointer;
            }

            return output;
        }
    }
}
