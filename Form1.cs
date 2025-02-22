using OpenAI.Chat;

namespace WinFormsAppWithAPIINtegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatClient client = new(model: "gpt-4o-mini", apiKey: ("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"));

            //ChatCompletion completion = client.CompleteChat("Say 'this is a test.'");

            //Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");

            List<ChatMessage> messages =
            [
                new UserChatMessage("Tell me a 1 paragraph story like im "+this.numericUpDown1.Value+" years old about why the "+this.textBox1.Text+" is good for me, then repeat that story in " + this.textBox3.Text),
];

            ChatCompletion completion = client.CompleteChat(messages);

            //using JsonDocument structuredJson = JsonDocument.Parse(completion.Content[0].Text);

            this.OutPutBox.Text=($"Final answer: " + completion.Content[0].Text);
            this.OutPutBox.Show();
            //Console.WriteLine("Reasoning steps:");


        }
    }
}
