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
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //sk - proj - 9JVRMoF5LkjleA7llY7ukzjhOQpOTkJQtUHL5oU7f2zjtSHQ5HeUmgMrWaC4IpRjpSlaVF1nnnT3BlbkFJyYgXe9vKV2AZ15FB34m - Z5T7V36QKDfEHKs6QniWiTRbGHYvJ_08phaqhZ0SWZTzrDCezSTy4A

            {
                static async Task Main(string[] args) { 
                
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
