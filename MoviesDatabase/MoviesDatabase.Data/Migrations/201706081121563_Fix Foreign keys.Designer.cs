// <auto-generated />
namespace MoviesDatabase.Data.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class FixForeignkeys : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(FixForeignkeys));
        
        string IMigrationMetadata.Id
        {
            get { return "201706081121563_Fix Foreign keys"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
