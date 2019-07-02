namespace Null_pattern
{
    abstract class Utilisateur
    {
        public string Name { get; set; }
        public abstract bool IsNull();
        public abstract string GetName();
    }
}
