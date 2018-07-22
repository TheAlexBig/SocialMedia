using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace SocialMedia
{
    class VideoPost: Post {
        protected bool isPlaying = false;
        protected int currenDuration = 0;
        protected Timer timer;
        public string VideoURL { get; set; }
        public int LonguitudVideo { get; set; }

        public VideoPost(string titulo, bool espublico, string usuarioemisor, string url, int longuitud )
        {
            this.Titulo = titulo;
            this.EsPublico = espublico;
            this.UsuarioEmisor = usuarioemisor;
            this.VideoURL = url;
            this.LonguitudVideo = longuitud;
        }
        public void Play() {
            currenDuration = 0;
            Console.WriteLine("El video se ha iniciado.");
            timer = new Timer(1000);
            timer.Elapsed += HandleTimer;
            timer.Start();
        }
        private void HandleTimer(Object source, ElapsedEventArgs e) {
            if (currenDuration < LonguitudVideo) { 
            currenDuration++;
            Console.WriteLine("Duracion actual {0}", currenDuration);
            }
            else
            {
                timer.Stop();
                timer.Dispose();
                Console.WriteLine("Se acabo el video");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - por {2} \n {3} ", this.ID, this.Titulo, this.UsuarioEmisor, this.VideoURL);
        }
    }
}
