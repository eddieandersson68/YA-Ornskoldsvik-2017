namespace PersonRegistry
{
    class Child : Person
    {
        public Child (string Genderprefix, string Firstname, string Lastname) : base (Genderprefix , Firstname, Lastname)
        {
        }

        public override string GetPerson()
        {
            return $"{_genderPrefix} {_firstName.ToLower()} {_lastName.ToLower()}";
        }
    }
}