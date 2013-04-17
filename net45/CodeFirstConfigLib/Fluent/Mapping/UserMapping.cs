namespace CodeFirstConfigLib.Fluent.Mapping
{
    public class UserMapping: EntityTypeConfigurationBase<FluentUser>
    {
        public UserMapping()
        {
            HasKey(x => x.UserIdentity);
            
            Ignore(x=>x.NotMapThis);

            Property(x => x.UpdatedDate).IsConcurrencyToken();

            HasRequired(x => x.Nationality).WithRequiredPrincipal();
            
            ToTable("User");
        }
    }
}
