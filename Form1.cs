using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Media_Player_cs
{
    public partial class Form1 : Form
    {
        Music m = new Music();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m.initialize_music(Tabela_Musicas);
            Update_Name.Enabled = true;
            Current_Music_Label.Text = "";
        }
        private void Play_Button_Click(object sender, EventArgs e)
        {
            m.play_music();
        }
        private void Pause_Button_Click(object sender, EventArgs e)
        {
            m.pause_music();
        }
        private void Baixar_Som_Button_Click(object sender, EventArgs e)
        {
            string som_string = Interaction.InputBox("Quanto de som (0-100)");
            int volume = Convert.ToInt32(som_string);
            m.alterar_volume(volume);
        }
        private void Next_Button_Click(object sender, EventArgs e)
        {
            m.next_music();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            m.back_music();
        }
        private void Update_Name_Tick(object sender, EventArgs e)
        {
            Current_Music_Label.Text = m.current_music();
            if (m.song_playing())
                m.next_music();
        }
        private void Choose_Music_Button_Click(object sender, EventArgs e)
        {
            string index_music = Interaction.InputBox("Indice da música");
            int index = Convert.ToInt32(index_music);
            m.choose_music(index);
        }
    }
}
