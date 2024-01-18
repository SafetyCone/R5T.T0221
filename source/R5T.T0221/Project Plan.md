# R5T.T0221
Catch-all for framework-type dependent data types with associated functionality that depends on R5T.L0066.

Allowed dependencies:

	* netstandard2.1
	* R5T.L0066 - The strictly-framework library for the netstandard2.1 target framework.

Can contain only platform types (which rely only on .NET target platform C# intrinsic types), not non-base, composite types (which rely on non-C# intrinsic types).

For base and composite types, see R5T.T0220.