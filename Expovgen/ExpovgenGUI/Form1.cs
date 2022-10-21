using Expovgen;
using System.Diagnostics;

namespace ExpovgenGUI
{
    public partial class Form1 : Form
    {
        ExpovgenGenerationSettings settings;
        public Form1()
        {
            InitializeComponent();
            settings = new ExpovgenGenerationSettings();
            propertyGrid1.SelectedObject = settings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string>? check = settings.CheckValid();
            //if (check is not null)
            //{
            //    string errorout = "";
            //    foreach (string errorstr in check)
            //    {
            //        errorout += " -> " + errorstr + "\n";
            //    }
            //    MessageBox.Show("Configurações inválidas! Favor resolver os seguintes conflitos:\n\n" + errorout + "\nNenhuma alteração foi realizada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //ExportForm exportForm = new ExportForm(settings);
            //DialogResult dr = exportForm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
                //new CreatingVideoForm(textBox1.Lines,exportForm.Settings).ShowDialog();
                new CreatingVideoForm(textBox1.Lines,settings).ShowDialog();
            //}

            //TODO: (IDEA) Quick video generation wizard.
            /* Idea description:
             *   It's a wizard where you load in a txt file, select
             *   video generation options, and the video is generated
             *   without having to necessarily create a project and all
             *   of that
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new(settings);
            settingsForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MainForm(null).Show();
        }
    }
}