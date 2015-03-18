using Anycmd.Xacml.Interfaces;

// ReSharper disable once CheckNamespace
namespace Anycmd.Xacml.Runtime.Functions
{
	/// <summary>
	/// Function implementation, in order to check the function behavior use the value of the Id
	/// property to search the function in the specification document.
	/// </summary>
	public class Rfc822NameSubset : BaseSubset
	{
		#region IFunction Members

		/// <summary>
		/// The id of the function, used only for notification.
		/// </summary>
		public override string Id
		{
			get{ return Consts.Schema1.InternalFunctions.Rfc822NameSubset; }
		}

		/// <summary>
		/// Defines the data type for which the function was defined for.
		/// </summary>
		public override IDataType DataType
		{
			get{ return DataTypeDescriptor.Rfc822Name; }
		}

		#endregion
	}
}
