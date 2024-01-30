using System;


namespace R5T.T0221
{
	public static class Instances
	{
		public static L0066.IFlagsOperator FlagsOperator => L0066.FlagsOperator.Instance;
		public static L0066.IStringOperator StringOperator => L0066.StringOperator.Instance;
		public static IStrings Strings => T0221.Strings.Instance;
		public static L0066.ISwitchOperator SwitchOperator => L0066.SwitchOperator.Instance;
		[Obsolete("See R5T.L0089")]
		public static IWasFoundOperator WasFoundOperator => T0221.WasFoundOperator.Instance;
	}
}