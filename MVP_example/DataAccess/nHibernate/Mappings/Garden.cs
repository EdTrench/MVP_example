namespace MVP_example.DataAccess.nHibernate.Mappings
{
    class Garden :  FluentNHibernate.Mapping.ClassMap<Model.Garden.Garden>
    {
        public Garden()
        {
            Table("garden.Garden");
            Id(x => x.Id).Column("GardenID").GeneratedBy.Identity();
            Map(x => x.Name).Column("GardenName");
            Map(x => x.Description).Column("GardenDescription");
        }
    }
}
