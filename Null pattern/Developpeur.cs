namespace Null_pattern
{
    class Developpeur : Utilisateur
    {
       
        public Developpeur(string v)
        {
            this.Name = v;
        }

        public override string GetName() => Name;

        public override bool IsNull() => false;
    }
}
