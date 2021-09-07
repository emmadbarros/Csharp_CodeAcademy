using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace DatingApp
{
    //Custom Exception
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg) : base(msg) { }
        public InvalidDataException(string msg, Exception inner) : base(msg, inner) { }
    }

    public class Profile
    {
        //FIELDS (storage)

        private string _name;

        private int _age;

        private EPronouns _pronouns;

        private string _city;

        private string _country;

        private string _description;

        //ENUM

        //FIXME: add 'Other' with possibility to enter other pronoun if selected
        //FIXME: should display 'HE/HIM', 'She/Her', 'They/Them'
        public enum EPronouns { He, She, They }

        //PROPERTIES

        //_name
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new InvalidDataException("Name must contain uppercase and lowercase letters only.");
                }
                _name = value;
            }
        }

        //_age
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 18 || value > 150)
                {
                    if (value < 18)
                    {
                        throw new InvalidDataException("Sorry, you must be 18 years or older to use this app.");
                    }
                    else
                    {
                        throw new InvalidDataException("Age must be between 18 and 150.");
                    }
                }
                _age = value;
            }
        }

        //_pronouns
        public EPronouns Pronouns
        {
            get
            {
                return _pronouns;
            }

            set
            {
                _pronouns = value;
            }
        }

        //_city
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new InvalidDataException("City must contain uppercase and lowercase letters only.");
                }
                _city = value;
            }
        }

        //_country
        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new InvalidDataException("Country must contain uppercase and lowercase letters only.");
                }
                _country = value;
            }
        }

        //_description
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                //FIXME: check for curses
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9b ()'.-]{1,300}$"))
                {
                    throw new InvalidDataException("Description must be 1 to 300 characters long and only contain uppercase letters, lowercase letters, digits 0-9 and special characters like '().-' .");
                }
                _description = value;
            }
        }

        //CONSTRUCTOR(s)

        public Profile(string name, int age, string pronouns, string city, string country, string description)
        {
            try
            {
                Name = name; //InvalidDateException from setter
                Age = age; //InvalidDateException from setter
                Pronouns = (EPronouns)Enum.Parse(typeof(EPronouns), pronouns, true); // exc from parsing
                City = city; //InvalidDateException from setter
                Country = country; //InvalidDateException from setter
                Description = description; //InvalidDateException from setter
            }
            catch (Exception exc) when (exc is ArgumentException || exc is ArgumentNullException || exc is OverflowException)
            {
                throw new InvalidDataException("Pronoun not found.");
            }
        }

        //OVERRIDES

        public override string ToString()
        {
            return String.Format("Name: {0}\nAge: {1}\nPronouns: {2}\nCity & Country: {3}, {4}\nDescription: {5}", this.Name, this.Age, this.Pronouns.ToString().Equals("He") ? "He/Him" : (this.Pronouns.ToString().Equals("She") ? "She/Her" : "They/Them"), this.City, this.Country, this.Description);
        }
    }
}
