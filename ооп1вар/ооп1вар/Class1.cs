using System;

namespace ооп1вар
{
    public class Contact
    {
        public string Name { get; }
        public string Surname { get; }
        public string Address { get; }
        public Group ContactGroup { get; }

        public readonly int Id;

        public string TelephoneNumber { get; set; }
        public string Description { get; set; }

        public Contact(string name, string surname, string address, Group contactGroup, int id)
        {
            Name = name;
            Surname = surname;
            Address = address;
            ContactGroup = contactGroup;
            Id = id;

            TelephoneNumber = "";
            Description = "";
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            Console.WriteLine($"Телефон: {TelephoneNumber}\n" +
                              $"Идентификатор: {Id}\n" +
                              $"Адрес: {Address}\n" +
                              $"Контактная группа: {GetContactGroupInText(ContactGroup)}\n" +
                              $"Заметки о контакте: {Description}");
        }

        private string GetContactGroupInText(Group contactGroup)
        {
            return ContactGroup switch
            {
                Group.Family => "Семья",
                Group.Familiar => "Знакомые",
                Group.Friend => "Друг",
                Group.Work => "Работа",
                Group.WithoutGroup => "Без группы",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    public enum Group
    {
        Family,
        Familiar,
        Friend,
        Work,
        WithoutGroup
    }
}
