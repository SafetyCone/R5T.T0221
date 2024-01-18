using System;

using R5T.T0132;


namespace R5T.T0221
{
    [FunctionalityMarker]
    public partial interface IEnabledOperator : IFunctionalityMarker
    {
        public string To_String(Enabled enabled)
        {
            var output = enabled switch
            {
                Enabled.Disabled => Instances.Strings.Disabled,
                Enabled.Enabled => Instances.Strings.Enabled,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedSwitchValueException()
            };

            return output;
        }
    }
}
