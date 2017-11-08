namespace PersonRegistry
{
    public class Male : Person
    {
        protected string _genderPrefix { get; set; }

        public string GetPrefix()
        {
            return _genderPrefix;
        }

        public Male(string Genderprefix, string Firstname, string Lastname) : base( Firstname, Lastname)
        {
            _genderPrefix = Genderprefix;
        }

        public override string GetPerson()
        {
            return $"{_genderPrefix} {_firstName.ToLower()} {_lastName.ToLower()}";
        }
    }
}