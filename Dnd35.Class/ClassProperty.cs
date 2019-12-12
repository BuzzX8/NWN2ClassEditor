namespace Dnd35.Class
{
    public abstract class ClassProperty
    {
        protected ClassProperty(int id, int nameId = -1, int descriptionId = -1)
        {
            Id = id;
            NameId = nameId;
            DescriptionId = descriptionId;
        }

        public int Id { get; }

        public int NameId { get; }

        public int DescriptionId { get; }
    }
}