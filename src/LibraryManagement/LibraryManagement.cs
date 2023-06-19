namespace LibraryManagement
{
    public class LibraryManagement : LibraryManagementCore
    {
        public void RegisterUser(string firstName, string lastName)
        {

        }

        public void RegisterUser(string firstName, string lastName, string userName)
        {
            var foundUser = false;
            foreach (var user in Store.Users)
                if (user.UserName == userName)
                {
                    foundUser = true;
                    break;
                }

            if (foundUser)
                return;

            Store.Users.Add(new User(firstName, lastName, userName));
        }
    }
}
