using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AjoutArticleWCFService
{
    [DataContract]
    public class Article
    {
        private String titre;
        private String texte;
        private int likes;
        private int dislikes;

        public Article() {
            this.titre = "";
            this.texte = "";
            this.likes = 0;
            this.dislikes = 0;
        }


        public Article(String titre, String texte) {

            this.titre = titre;
            this.texte = texte;
            this.likes = 0;
            this.Dislikes = 0;

        }

        [DataMember]
        public String Titre
        {
            get { return titre; }
            set
            {
                if (titre != value)
                {
                    titre = value;
                }
            }
        }

        [DataMember]
        public String Texte
        {
            get { return texte; }
            set
            {
                if (texte != value)
                {
                    texte = value;
                }
            }
        }

        [DataMember]
        public int Likes
        {
            get { return likes; }
            set
            {
                if (likes != value)
                {
                    likes = value;
                }
            }
        }

        [DataMember]
        public int Dislikes
        {
            get { return dislikes; }
            set
            {
                if (dislikes != value)
                {
                    dislikes = value;
                }
            }
        }


    }
}