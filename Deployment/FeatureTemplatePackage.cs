using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;
using System.ComponentModel.Composition;

namespace Deployment
{
    [Export(typeof(IImportExtensions))]
    public class AddName : ImportExtension
    {
        public override string GetLongNameOfImport => "AddName";

        public override string GetImportPackageDataFolderName => "AddName";

        public override string GetImportPackageDescriptionText => "AddName";

        public override bool AfterPrimaryImport()
        {
            return true;
        }

        public override bool BeforeImportStage()
        {
            return true;
        }

        public override string GetNameOfImport(bool plural)
        {
            return "AddName";
        }

        public override void InitializeCustomExtension()
        {
            //Do Nothing
        }

    }
}
