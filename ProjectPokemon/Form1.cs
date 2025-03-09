using System.Reflection;

namespace ProjectPokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                Pikachu pikachu = new Pikachu();
                // แก้ไขบรรทัดนี้
                pictureBoxPokemon.Image = Image.FromFile("Images/pikachu.jpg");
                lblPokemonName.Text = "Name: " + pikachu.Name;
                lblPokemonType.Text = "Type: " + pikachu.Type;
                lblPokemonStatus.Text = "Status: " + pikachu.BasicStatus;
            }

        }

        private void df_Click(object sender, EventArgs e)
        {
            Celebi celebi = new Celebi();
            pictureBoxPokemon.Image = Image.FromFile("Images/celebi.jpg");
            lblPokemonName.Text = "Name: " + celebi.Name;
            lblPokemonName.Text = "Name: " + celebi.Name;
            lblPokemonType.Text = "Type: " + celebi.Type;
            lblPokemonStatus.Text = "Status: " + celebi.BasicStatus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Groudon groundon = new Groudon();
            pictureBoxPokemon.Image = Image.FromFile("Images/groudon.jpg");
            lblPokemonName.Text = "Name: " + groundon.Name;
            lblPokemonName.Text = "Name: " + groundon.Name;
            lblPokemonType.Text = "Type: " + groundon.Type;
            lblPokemonStatus.Text = "Status: " + groundon.BasicStatus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Piplup piplub = new Piplup();
            pictureBoxPokemon.Image = Image.FromFile("Images/piplup.jpg");
            lblPokemonName.Text = "Name: " + piplub.Name;
            lblPokemonName.Text = "Name: " + piplub.Name;
            lblPokemonType.Text = "Type: " + piplub.Type;
            lblPokemonStatus.Text = "Status: " + piplub.BasicStatus;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chatot chatot = new Chatot();
            pictureBoxPokemon.Image = Image.FromFile("Images/chatot.jpg");
            lblPokemonName.Text = "Name: " + chatot.Name;
            lblPokemonName.Text = "Name: " + chatot.Name;
            lblPokemonType.Text = "Type: " + chatot.Type;
            lblPokemonStatus.Text = "Status: " + chatot.BasicStatus;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Greninja greninja = new Greninja();
            pictureBoxPokemon.Image = Image.FromFile("Images/greninja.jpg");
            lblPokemonName.Text = "Name: " + greninja.Name;
            lblPokemonName.Text = "Name: " + greninja.Name;
            lblPokemonType.Text = "Type: " + greninja.Type;
            lblPokemonStatus.Text = "Status: " + greninja.BasicStatus;

        }
    }
}
