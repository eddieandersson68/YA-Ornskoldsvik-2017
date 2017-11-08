namespace PersonRegistry
{
    public class Female : Person
    {
        public Female(string Genderprefix, string Firstname, string Lastname) : base(Genderprefix, Firstname, Lastname)
        {
        }

        public override string GetPerson()
        {
            return $"{_genderPrefix} {_firstName.ToLower()} {_lastName.ToLower()}";
        }
    }
}