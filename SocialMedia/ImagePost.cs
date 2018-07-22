using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class ImagePost :Post
    {
        public string ImageURL { get; set; }
        public ImagePost(string titulo, bool espublico, string usuarioemisor, string url) 
        {
            this.ID = GetNextID();
            this.Titulo=titulo;
            this.UsuarioEmisor = usuarioemisor;
            this.EsPublico = espublico;
            this.ImageURL = url;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - por {2}  ", this.ID, this.Titulo, this.UsuarioEmisor);
        }
    }
}
