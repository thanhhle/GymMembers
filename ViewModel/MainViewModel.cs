using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GymMembers.Model;
using GymMembers.View;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Input;
namespace GymMembers.ViewModel
{
    /// <summary>
    /// The VM for the main screen that shows the member list.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// The list of registered members.
        /// </summary>
        private ObservableCollection<Member> _members;

        /// <summary>
        /// The currently selected member.
        /// </summary>
        private Member _selectedMember;

        /// <summary>
        /// The database that keeps track of saving and reading the registered members.
        /// </summary>
        /// /// </summary>
        private MemberDB _database;

        /// <summary>
        /// The currently selected member in the list box.
        /// </summary>
        public Member SelectedMember
        {
            get
            {
                return _selectedMember;
            }
            set
            {
                Set<Member>(() => this.SelectedMember, ref _selectedMember, value);
            }
        }

        /// <summary>
        /// The list of registered members.
        /// </summary>
        public ObservableCollection<Member> MemberList
        {
            get { return _members; }
        }

        /// <summary>
        /// The command that triggers adding a new member.
        /// </summary>
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// The command that triggers exiting the application.
        /// </summary>
        public ICommand ExitCommand { get; private set; }

        /// <summary>
        /// The command that triggers changing a member.
        /// </summary>
        public ICommand ChangeCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _members = new ObservableCollection<Member>();
            _database = new MemberDB(MemberList);
            _members = _database.GetMemberships();
            AddCommand = new RelayCommand(AddMethod);
            ExitCommand = new RelayCommand<IClosable>(ExitMethod);
            ChangeCommand = new RelayCommand(ChangeMethod);
            Messenger.Default.Register<MessageMember>(this, ReceiveMember);
            Messenger.Default.Register<NotificationMessage>(this, ReceiveMessage);
        }

        /// <summary>
        /// Shows a new add screen.
        /// </summary>
        public void AddMethod()
        {
            AddWindow add = new AddWindow();
            add.Show();
        }

        /// <summary>
        /// Opens the change window.
        /// </summary>
        public void ChangeMethod()
        {
            if (SelectedMember != null)
            {
                ChangeWindow change = new ChangeWindow();
                change.Show();
                Messenger.Default.Send(SelectedMember);
            }
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="window">The window to close.</param>
        public void ExitMethod(IClosable window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        /// <summary>
        /// Gets a new member for the list.
        /// </summary>
        /// <param name="m">The member to add. The message denotes how it is added.
        /// "Update" replaces at the specified index, "Add" adds it to the list.</param>
        public void ReceiveMember(MessageMember m)
        {
            if (m.Message == "Update")
            {
                /* Another method for update
                SelectedMember.FirstName = m.FirstName;
                SelectedMember.LastName = m.LastName;
                SelectedMember.Email = m.Email;
                _database.SaveMemberships();
                _members = _database.GetMemberships();
                RaisePropertyChanged("MemberList");
                */
                
                MemberList[MemberList.IndexOf(SelectedMember)] = new Member(m.FirstName, m.LastName, m.Email);
            }
            else if (m.Message == "Add")
            {
                MemberList.Add(new Member(m.FirstName, m.LastName, m.Email));
            }
            _database.SaveMemberships();
        }


        /// <summary>
        /// Gets text messages.
        /// </summary>
        /// <param name="msg">The received message. "Delete" means the currently selected member is deleted.</param>
        public void ReceiveMessage(NotificationMessage msg)
        {
            if (msg.Notification == "Delete")
            {
                MemberList.Remove(SelectedMember);
                _database.SaveMemberships();
            }
        }
    }
}