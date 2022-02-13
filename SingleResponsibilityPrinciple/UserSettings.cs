namespace SingleResponsibilityPrinciple
{
    class UserSettings
    {
        private User User;
        private UserAuth Auth;

        public UserSettings(User user)
        {
            this.User = user;
            this.Auth = new UserAuth(user: user);
        }

        public void ChangeSettings(Settings settings)
        {
            if (this.Auth.VerifyCredentials())
            {
                // ...
            }
        }
    }

    internal class Settings
    {
    }
}
