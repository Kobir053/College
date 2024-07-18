namespace College
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionString = "Data Source=LAPTOP-P5J1UI1F;User ID = sa;initial catalog=College;Password=1234;Connect Timeout = 30;Encrypt=False;";
            DBContext dbctxt = new DBContext(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FormHandler formHandler = new FormHandler(dbctxt);
            formHandler.Show("Form1");

            Application.Run();
        }
    }
}