using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymMembers.Model
{
    /// <summary>
    /// A class that uses a text file to store information about the gym members longterm.
    /// </summary>
    class MemberDB : ObservableObject
    {
        /// <summary>
        /// The list of members to be saved.
        /// </summary>
        private ObservableCollection<Member> _members;

        /// <summary>
        /// Where the database is stored.
        /// </summary>
        private string _filepath = Path.Combine(Path.GetDirectoryName((Path.GetDirectoryName(Directory.GetCurrentDirectory()))), "members.txt");

        /// <summary>
        /// Creates a new member database.
        /// </summary>
        /// <param name="m">The list to saved from or written to.</param>
        public MemberDB(ObservableCollection<Member> m)
        {
            _members = m;
        }


        /// <summary>
        /// Reads the saved text file database into the program's list of members.
        /// </summary>
        /// <returns>The list containing the text file data read in.</returns>
        public ObservableCollection<Member> GetMemberships()
        {
            _members = new ObservableCollection<Member>();
            try
            {
                string line;
                StreamReader input = new StreamReader(new FileStream(_filepath, FileMode.OpenOrCreate, FileAccess.Read));
                while ((line = input.ReadLine()) != null)
                {
                    string[] spearator = { " ", ", " };
                    string[] data = line.Split(spearator, 3, StringSplitOptions.RemoveEmptyEntries);
                    _members.Add(new Member(data[0], data[1], data[2]));
                }
                input.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid e-mail address format.");
            }
            return _members;
        }

        /// <summary>
        /// Saves the program's list of members into the text file database.
        /// </summary>
        public void SaveMemberships()
        {
            StreamWriter output = new StreamWriter(new FileStream(_filepath, FileMode.Create, FileAccess.Write));
            foreach (Member m in _members)
            {
                output.WriteLine(m);
            }
            output.Close();
        }
    }
}