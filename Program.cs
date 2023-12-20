namespace WinFormsApp1
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1(new User
            //{
            //    UserId = 1,
            //    Email = "ruivalien@gmail.com",
            //    FullName = "Test Nguyen",
            //    Password = StaticFunc.ComputeSha256Hash("123456Pass")
            //}));
            Application.Run(new FormLogin());
        }
    }
}