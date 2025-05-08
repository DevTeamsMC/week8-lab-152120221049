namespace OOP2_Exp6_Grp10
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,  
            // see https://aka.ms/applicationconfiguration.  
            ApplicationConfiguration.Initialize();
            GameSettings settings = new GameSettings(); // Create an instance of GameSettings  
            Application.Run(new StartGame(settings)); // Pass the instance to StartGame  
        }
    }
}