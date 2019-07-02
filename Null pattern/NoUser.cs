namespace Null_pattern
{
    class NoUser : Utilisateur
    {
        public override string GetName() => string.Empty;

        public override bool IsNull() => true;
    }
}
