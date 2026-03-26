namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f846ddb9-d8cf-4d8c-b5df-eb6eb6b984a1");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("62202779-5711-4f2d-ae40-de4e7c43c3ba");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,209,106,27,49,16,124,15,228,31,150,123,186,3,35,154,215,166,13,212,198,9,129,208,150,248,92,40,165,15,178,110,125,86,57,73,135,86,231,212,45,249,247,174,36,59,113,206,41,100,193,248,180,26,205,206,12,11,86,26,164,94,42,132,26,189,151,228,214,65,204,156,93,235,118,240,50,104,103,207,207,254,158,159,1,215,64,218,182,176,216,81,64,115,121,220,58,126,104,140,179,255,189,244,40,230,54,232,160,145,222,130,17,243,45,218,112,128,254,72,237,93,234,221,105,22,97,209,151,11,181,65,35,63,179,7,248,8,197,146,252,119,169,54,161,168,126,230,55,253,176,234,180,2,213,73,34,72,87,175,144,192,123,152,74,194,87,110,50,201,222,254,17,159,219,178,96,221,32,108,157,110,224,139,93,200,45,219,40,221,234,23,170,0,132,182,65,63,129,76,56,197,53,123,74,180,159,124,75,128,213,51,221,17,115,172,21,171,16,79,108,7,26,172,46,95,194,50,47,236,162,29,118,93,230,115,149,241,35,108,131,74,27,217,65,239,181,138,17,165,71,226,6,67,189,235,177,153,185,110,48,246,155,236,6,252,176,71,94,149,49,197,175,17,94,140,7,235,53,148,153,232,10,46,222,165,170,94,34,70,134,98,161,184,165,153,180,10,59,108,88,64,240,3,50,237,41,142,130,143,171,192,203,72,178,197,26,77,223,201,16,37,91,124,128,59,167,100,167,255,200,85,135,139,132,43,179,145,37,161,231,101,181,28,59,111,170,184,71,114,131,87,140,113,158,73,38,112,58,38,214,211,158,228,253,42,38,80,156,12,32,145,98,185,165,218,185,169,110,243,169,168,68,237,246,2,170,55,184,96,245,185,33,174,157,55,50,148,35,119,60,248,2,56,197,244,155,47,239,79,18,143,21,54,222,61,164,20,230,191,21,246,209,232,129,103,12,127,124,62,238,63,249,239,241,31,231,229,107,52,227,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5b87e6b9-c497-fb64-aa86-a113ff74ef06"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("62202779-5711-4f2d-ae40-de4e7c43c3ba"),
				CreatedInSchemaUId = new Guid("f846ddb9-d8cf-4d8c-b5df-eb6eb6b984a1"),
				ModifiedInSchemaUId = new Guid("f846ddb9-d8cf-4d8c-b5df-eb6eb6b984a1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f846ddb9-d8cf-4d8c-b5df-eb6eb6b984a1"));
		}

		#endregion

	}

	#endregion

}

