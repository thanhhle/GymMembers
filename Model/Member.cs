using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymMembers.Model
{
    /// <summary>
    /// A class that represents a member of a gym.
    /// </summary>
    public class Member : ObservableObject
    {
        /// <summary>
        /// The member's first name.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// The member's last name.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// The member's email.
        /// </summary>
        private string _email;

        private static readonly int TEXT_LIMIT = 25;


        /// <summary>
        /// A property that gets or sets the member's last name, and makes sure it's not too long.
        /// </summary>
        /// <returns>The member's last name.</returns>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length > TEXT_LIMIT)
                {
                    throw new ArgumentException("Too long");
                }
                if (value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                //_lastName = value;
                Set<string>(() => this.LastName, ref _lastName, value);
            }
        }

        /// <summary>
        /// A property that gets or sets the member's first name, and makes sure it's not too long.
        /// </summary>
        /// <returns>The member's first name.</returns>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length > TEXT_LIMIT)
                {
                    throw new ArgumentException("Too long");
                }
                if (value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                //_firstName = value;
                Set<string>(() => this.FirstName, ref _firstName, value);
            }
        }

        /// <summary>
        /// A property that gets or sets the member's e-mail, and makes sure it's not too long.
        /// </summary>
        /// <returns>The member's e-mail.</returns>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > TEXT_LIMIT)
                {
                    throw new ArgumentException("Too long");
                }
                if (value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                if (value.IndexOf("@") == -1 || value.IndexOf(".") == -1)
                {
                    throw new FormatException();
                }
                //_email = value;
                Set<string>(() => this.Email, ref _email, value);
            }
        }

        public Member() { }

        /// <summary>
        /// Creates a new member.
        /// </summary>
        /// <param name="fName">The member's first name.</param>
        /// <param name="lName">The member's last name.</param>
        /// <param name="email">The member's e-mail.</param>
        public Member(string fName, string lName, string email)
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
        }


        /// <summary>
        /// Text to be displayed in the list box.
        /// </summary>
        /// <returns>A concatenation of the member's first name, last name, and email.</returns>
        public override string ToString()
        {
            return (FirstName + " " + LastName + ", " + Email);
        }
    }
}