//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                                                                                                              ||
//                                                                                 ENV File Configuration System                                                                                ||
//                                                                                                                                                                                              ||
// Description:                                                                                                                                                                                 ||
//      This system provides functionality to load and save configuration values from an .env file for use in any application.                                                                  ||
//      The settings can include API keys, bot tokens, and other user-defined configurations that can be dynamically loaded.                                                                    ||
//                                                                                                                                                                                              ||
// Author: [Void]                                                                                                                                                                               ||
// Beacons: https://beacons.ai/voidpool                                                                                                                                                         ||
// GitHub: https://github.com/V0idpool                                                                                                                                                          ||
// VoidBot Discord Support Server: https://discord.gg/nsSpGJ5saD                                                                                                                                ||
// License:                                                                                                                                                                                     ||
//      You are free to use, modify, and distribute this code, as long as proper attribution is given.                                                                                          ||
//      Void is not responsible for any damages or issues arising from the use of this code.                                                                                                    ||
//                                                                                                                                                                                              ||
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace ENV_Configuration
{
    public partial class Form1 : Form
    {
        private bool isFormVisible = true;

        public Form1()
        {
            InitializeComponent();
        }



        private void nsButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your settings?", "VoidBot Discord Bot [GUI]", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string envFilePath = Application.StartupPath + @"\.env"; // defines path of .env file
                var envSettings = new EnvSettings(envFilePath); // access to EnvSettings class


                // Save all settings to the .env file
                envSettings.WriteValue("GPT_API_KEY", GptApiKey.Text);
                envSettings.WriteValue("YOUTUBE_API_KEY", YoutubeAPIKey.Text);
                envSettings.WriteValue("YOUTUBE_APP_NAME", YoutubeAppName.Text);
                envSettings.WriteValue("DISCORD_BOT_TOKEN", DiscordBotToken.Text);
                envSettings.WriteValue("MONGODB_URL", mongoDBURL.Text);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing or handle other scenarios if necessary
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string envFilePath = Application.StartupPath + @"\.env"; // defines path of .env file
            var envSettings = new EnvSettings(envFilePath); // create an instance of EnvSettings

            // Check and load settings from .env file
            GptApiKey.Text = string.IsNullOrEmpty(envSettings.ReadValue("GPT_API_KEY")) ? "Input API Key..." : envSettings.ReadValue("GPT_API_KEY");
            YoutubeAPIKey.Text = string.IsNullOrEmpty(envSettings.ReadValue("YOUTUBE_API_KEY")) ? "Input API Key..." : envSettings.ReadValue("YOUTUBE_API_KEY");
            YoutubeAppName.Text = string.IsNullOrEmpty(envSettings.ReadValue("YOUTUBE_APP_NAME")) ? "Input Youtube API Keys App Name..." : envSettings.ReadValue("YOUTUBE_APP_NAME");
            DiscordBotToken.Text = string.IsNullOrEmpty(envSettings.ReadValue("DISCORD_BOT_TOKEN")) ? "Input API Key..." : envSettings.ReadValue("DISCORD_BOT_TOKEN");
            mongoDBURL.Text = string.IsNullOrEmpty(envSettings.ReadValue("MONGODB_URL")) ? "Input MongoDB URL..." : envSettings.ReadValue("MONGODB_URL");

        }




        private void nsCheckBox1_CheckedChanged(object sender)
        {
            // Toggle password characters based on the checkbox state
            bool showPassword = nsCheckBox1.Checked;

            GptApiKey.UseSystemPasswordChar = !showPassword;

            YoutubeAPIKey.UseSystemPasswordChar = !showPassword;

            YoutubeAppName.UseSystemPasswordChar = !showPassword;

            DiscordBotToken.UseSystemPasswordChar = !showPassword;

            mongoDBURL.UseSystemPasswordChar = !showPassword;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "ENV files (*.env)|*.env|All files (*.*)|*.*";
                openFileDialog.Title = "Select an ENV File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string envFilePath = openFileDialog.FileName; // Get the selected file path
                    var envSettings = new EnvSettings(envFilePath); // Create an instance of EnvSettings

                    // Load settings from the selected .env file
                    GptApiKey.Text = string.IsNullOrEmpty(envSettings.ReadValue("GPT_API_KEY")) ? "Input API Key..." : envSettings.ReadValue("GPT_API_KEY");
                    YoutubeAPIKey.Text = string.IsNullOrEmpty(envSettings.ReadValue("YOUTUBE_API_KEY")) ? "Input API Key..." : envSettings.ReadValue("YOUTUBE_API_KEY");
                    YoutubeAppName.Text = string.IsNullOrEmpty(envSettings.ReadValue("YOUTUBE_APP_NAME")) ? "Input Youtube API Keys App Name..." : envSettings.ReadValue("YOUTUBE_APP_NAME");
                    DiscordBotToken.Text = string.IsNullOrEmpty(envSettings.ReadValue("DISCORD_BOT_TOKEN")) ? "Input API Key..." : envSettings.ReadValue("DISCORD_BOT_TOKEN");
                    mongoDBURL.Text = string.IsNullOrEmpty(envSettings.ReadValue("MONGODB_URL")) ? "Input MongoDB URL..." : envSettings.ReadValue("MONGODB_URL");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your settings?", "ENV Configuration Tool", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "ENV files (*.env)|*.env|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save ENV File";
                    saveFileDialog.DefaultExt = "env";
                    saveFileDialog.InitialDirectory = Application.StartupPath;

                    // Show the dialog and check if the user selected a file
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string envFilePath = saveFileDialog.FileName; // Get the selected file path
                        var envSettings = new EnvSettings(envFilePath); // Access to EnvSettings class

                        // Save all settings to the .env file
                        envSettings.WriteValue("GPT_API_KEY", GptApiKey.Text);
                        envSettings.WriteValue("YOUTUBE_API_KEY", YoutubeAPIKey.Text);
                        envSettings.WriteValue("YOUTUBE_APP_NAME", YoutubeAppName.Text);
                        envSettings.WriteValue("DISCORD_BOT_TOKEN", DiscordBotToken.Text);
                        envSettings.WriteValue("MONGODB_URL", mongoDBURL.Text);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing or handle other scenarios if necessary
            }
        }

    }
}


