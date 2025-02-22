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


            List<ChatMessage> messages =
            [
                new UserChatMessage("Tell me a 1 paragraph story like im "+this.numericUpDown1.Value+" years old about why the "+this.textBox1.Text+" is good for me, then repeat that story in " + this.textBox3.Text),
];

            ChatCompletion completion = client.CompleteChat(messages);

            //using JsonDocument structuredJson = JsonDocument.Parse(completion.Content[0].Text);

            this.OutPutBox.Text = ($"Final answer: " + completion.Content[0].Text);
            this.OutPutBox.Show();
            //Console.WriteLine("Reasoning steps:");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataInputForm dataInputForm= new DataInputForm();
            dataInputForm.Show();
        }
    }
}
