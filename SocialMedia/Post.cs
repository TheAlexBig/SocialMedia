using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class Post
    {
        private static int idPostActual = 0;

        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string UsuarioEmisor { get; set; }
        protected bool EsPublico { get; set; }
        //Constructor
        public Post(string titulo,bool espublico, string usuarioemisor){
            this.ID= GetNextID();
            this.Titulo = titulo;
            this.UsuarioEmisor = usuarioemisor;
            this.EsPublico = espublico;
        }
        public Post() {
        }
        protected int GetNextID()
        {
            return ++idPostActual;
        }

        public void Actualizar(string titulo, bool espublico) {
            this.Titulo = titulo;
            this.EsPublico = espublico;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - por {2} ", this.ID,this.Titulo,this.UsuarioEmisor);
        }
    }
}
