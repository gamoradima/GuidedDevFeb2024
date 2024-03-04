namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a63f9d15-f2ea-4062-8443-a137a10c64ed");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("65f7fd06-a7c5-4c96-bd60-c8089955fd86");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,223,107,219,48,16,126,47,244,127,56,76,31,108,8,162,125,109,183,194,146,165,37,80,182,81,59,125,41,123,80,228,139,171,162,31,70,146,211,101,99,255,251,78,150,211,166,78,6,61,12,150,78,223,125,119,223,199,25,174,209,183,92,32,84,232,28,247,118,29,216,204,154,181,108,58,199,131,180,230,244,228,207,233,9,80,116,94,154,6,202,173,15,168,175,246,83,251,133,90,91,243,223,71,135,108,110,130,12,18,253,71,48,108,190,65,19,118,208,199,62,189,237,115,119,146,134,48,232,242,82,60,161,230,223,72,3,124,134,108,233,221,61,114,21,182,55,14,177,182,122,185,200,138,159,169,186,237,86,74,10,16,138,123,15,9,116,132,15,46,97,202,61,30,121,73,44,131,19,123,132,118,67,179,203,26,97,99,101,13,223,77,201,55,164,40,183,171,103,20,1,60,154,26,221,4,18,225,20,215,36,175,167,253,226,26,15,88,188,209,237,49,199,88,209,20,236,149,109,71,131,197,213,123,88,226,5,215,235,33,7,242,148,40,82,193,8,92,163,144,154,43,104,157,20,209,174,84,197,110,49,84,219,22,235,153,85,157,54,15,92,117,248,105,128,94,231,209,210,31,17,191,44,191,102,227,238,114,13,121,34,187,134,139,243,93,20,239,65,35,97,49,144,45,252,140,27,129,10,107,154,35,184,14,137,249,16,231,131,139,219,65,251,233,121,131,21,234,86,241,16,39,55,248,2,119,86,112,37,127,243,149,194,178,199,229,131,158,165,71,71,11,108,200,127,218,94,118,143,222,118,78,16,200,58,98,153,28,182,137,113,100,117,210,242,101,19,200,14,90,121,214,219,180,240,149,181,83,217,164,91,86,176,202,14,163,20,31,208,67,58,82,130,221,88,167,121,200,71,58,169,241,5,59,159,158,29,216,30,35,60,57,251,210,251,48,255,37,176,141,74,119,245,99,248,223,183,235,112,164,31,125,255,0,223,190,52,12,249,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e44d7abb-d8a0-2596-ee93-7e57b32f8d1a"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("65f7fd06-a7c5-4c96-bd60-c8089955fd86"),
				CreatedInSchemaUId = new Guid("a63f9d15-f2ea-4062-8443-a137a10c64ed"),
				ModifiedInSchemaUId = new Guid("a63f9d15-f2ea-4062-8443-a137a10c64ed")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a63f9d15-f2ea-4062-8443-a137a10c64ed"));
		}

		#endregion

	}

	#endregion

}

