namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations.Infrastructure;
    
    public partial class ClientInfo : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201201251113371_ClientInfo"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
