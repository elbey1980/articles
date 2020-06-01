using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AjoutArticleWCFService
{
    public class ArticleDAO
    {

        public static int setArticle(Article article)
        {
            int value = 0;
            try
            {

                MySqlConnection cnx = new MySqlConnection();
                cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=articles;";

                cnx.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insert into article values (@titre,@texte, default,default) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("titre", article.Titre);
                cmd.Parameters.AddWithValue("texte", article.Texte);

                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();

                value = 1;
                cnx.Close();
            }
            catch (Exception ex)
            {
                
                value = -1;
            }
            return value;
        }


    }
}