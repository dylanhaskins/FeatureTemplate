using Microsoft.Xrm.Tooling.PackageDeployment.CrmPackageExtentionBase;

namespace FeatureABC.Deployment
{
    public class FeatureABC : ImportExtension
    {
        public override string GetLongNameOfImport => "Feature ABC";

        public override string GetImportPackageDataFolderName => "FeatureABC";

        public override string GetImportPackageDescriptionText => "Feature ABC";

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
            return "Feature ABC";
        }

        public override void InitializeCustomExtension()
        {
            //Do Nothing
        }

    }
}
