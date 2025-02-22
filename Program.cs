using OpenAI;
using OpenAI.Chat;
using OpenAI.Models;
using OpenAI.FineTuning;
using OpenAI.Embeddings;
using OpenAI.RealtimeConversation;

namespace WinFormsAppWithAPIINtegration

{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


