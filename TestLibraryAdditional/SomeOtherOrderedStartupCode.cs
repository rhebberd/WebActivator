using TestLibrary;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(TestLibraryAdditional.SomeOtherOrderedStartupCode), "StartCode")]
[assembly: PreApplicationStartMethod(typeof(TestLibraryAdditional.SomeOtherOrderedStartupCode), "StartOrderedCode", Order = 2)]

// This is in another assembly to help prove we can order activation methods across assemblies
namespace TestLibraryAdditional
{
	public class SomeOtherOrderedStartupCode
	{
		public static void StartCode()
		{
			ExecutedCode.ExecutedOrder += "StartCode";
		}

		public static void StartOrderedCode()
		{
			ExecutedCode.ExecutedOrder += "StartOrderedCode";
		}
    }
}
