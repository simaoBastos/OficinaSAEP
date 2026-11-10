using OficinaSAEP.Services;

namespace OficinaSAEP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string cpf = "12345678900";
            cpf = Criptografia.Criptografar(cpf);
            Console.WriteLine($"CPF Criptografado: {cpf}");
            Clipboard.SetText(cpf);
            cpf = Criptografia.Descriptografar(cpf);
            Console.WriteLine($"CPF Descriptografado: {cpf}");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}