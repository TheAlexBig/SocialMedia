using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class VideoPost: Post {
        private string VideoURL { get; set; }
        private int LonguitudVideo { get; set; }

        public VideoPost(string titulo, bool espublico, string usuarioemisor, string url, int longuitud )
        {
            this.Titulo = titulo;
            this.EsPublico = espublico;
            this.UsuarioEmisor = usuarioemisor;
            this.VideoURL = url;
            this.LonguitudVideo = longuitud;
        }
    }
}
