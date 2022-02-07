using System;
using System.Collections.Generic;
using System.Linq;
using WMPLib;
using System.IO;
using System.Windows.Forms;

namespace Media_Player_cs
{
    class Music
    {
        private List<WindowsMediaPlayer> lista_musicas { get; set; }
        private int indice { get; set; }
        private short volume { get; set; }
        public void initialize_music(DataGridView tabel)
        {
            lista_musicas = new List<WindowsMediaPlayer>(); 
            indice = 0;
            volume = 5;
            string[] songs_list = Directory.GetFiles("C:\\Users\\Utilizador\\Desktop\\Media Player\\Musicas\\", "*.*", SearchOption.AllDirectories);
            foreach (string url in songs_list)
            {
                WindowsMediaPlayer music = new WindowsMediaPlayer();
                music.URL = url;
                music.settings.volume = 0;
                lista_musicas.Add(music);
                tabel.Rows.Add(indice,current_music());
                indice++;
            }
            foreach(WindowsMediaPlayer music in lista_musicas)
                music.controls.stop();
            indice = 0;
        }
        public void play_music()
        {
            if (indice >= 0 && indice < lista_musicas.Count())
            {
                lista_musicas[indice].controls.play();
                alterar_volume(volume);
            }
        }
        public void back_music()
        {
            if (indice > 0)
            {
                lista_musicas[indice].controls.stop();
                indice--;
                play_music();
            }
        }
        public void next_music()
        {
            if (indice < lista_musicas.Count() - 1)
            {
                lista_musicas[indice].controls.stop();
                indice++;
                play_music();
            }
        }
        public void pause_music()
        {
            lista_musicas[indice].controls.pause();
        }
        public void alterar_volume(int novo_som)
        {
            lista_musicas[indice].settings.volume = novo_som;
            volume = Convert.ToSByte(novo_som);
        }
        public string current_music()
        {
            string result = lista_musicas[indice].URL;
            result = result.Remove(0, 49);
            return result;
        }
        public void choose_music(int index)
        {
            if (index >= 0 && index < lista_musicas.Count())
            {
                lista_musicas[indice].controls.stop();
                indice = index;
                play_music();
            }
        }
        public bool song_playing()
        {
            bool result = false;
            if (lista_musicas[indice].playState.ToString() == "wmppsStopped") result = true;
            return result;
        }
    }
}
