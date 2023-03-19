namespace WebAppLearn.Data
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
    }
}
