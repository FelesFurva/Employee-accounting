using Employee_accounting.Models;

namespace Employee_accounting
{
    public class Database
    {
        public ICollection<UserModel> Users { get; set; }

        public Database()
        {
            Users = new List<UserModel>
            {
                new UserModel
                {
                    Id = 1,
                    Name = "Sergej",
                    Surname = "Lex",
                    Year_of_Birth = 1988,
                    Position = "Senior developer",
                    Department = "IT"
                },
                new UserModel
                {
                    Id = 2,
                    Name = "Sonja",
                    Surname = "Guru",
                    Year_of_Birth = 1993,
                    Position = "Manager",
                    Department = "Human Resources"
                },
                new UserModel
                {
                    Id = 3,
                    Name = "Alex",
                    Surname = "Crow",
                    Year_of_Birth = 1990,
                    Position = "Junior developer",
                    Department = "IT"
                },
                new UserModel
                {
                    Id = 4,
                    Name = "Zanna",
                    Surname = "Croft",
                    Year_of_Birth = 1988,
                    Position = "Designer",
                    Department = "Marketing"
                },
                new UserModel
                {
                    Id = 5,
                    Name = "Coleen",
                    Surname = "Tuft",
                    Year_of_Birth = 1988,
                    Position = "Accountant",
                    Department = "Accounting"
                }
            };
        }

        //public static UserModel user1 = new UserModel
        //{
        //    Id = 1,
        //    Name = "Sergej",
        //    Surname = "Lex",
        //    Year_of_Birth = 1988,
        //    Position = "Senior developer",
        //    Department = "IT"
        //};

        //public static UserModel user2 = new UserModel
        //{
        //    Id = 2,
        //    Name = "Sonja",
        //    Surname = "Guru",
        //    Year_of_Birth = 1993,
        //    Position = "Manager",
        //    Department = "Human Resources"
        //};

        //public static UserModel user3 = new UserModel
        //{
        //    Id = 3,
        //    Name = "Alex",
        //    Surname = "Crow",
        //    Year_of_Birth = 1990,
        //    Position = "Junior developer",
        //    Department = "IT"
        //};
        //public static UserModel user4 = new UserModel
        //{
        //    Id = 4,
        //    Name = "Zanna",
        //    Surname = "Croft",
        //    Year_of_Birth = 1988,
        //    Position = "Designer",
        //    Department = "Marketing"
        //};
        //public static UserModel user5 = new UserModel
        //{
        //    Id = 5,
        //    Name = "Coleen",
        //    Surname = "Tuft",
        //    Year_of_Birth = 1988,
        //    Position = "Accountant",
        //    Department = "Accounting"
        //};

        //public static List<UserModel> userModels = new List<UserModel>
        //{
        //    user1,
        //    user2,
        //    user3,
        //    user4,
        //    user5
        //};

    }
}
