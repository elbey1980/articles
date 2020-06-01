/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controle;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class ArticleDAO {

    public static ArrayList<Article> getAllArticles() throws SQLException {
        Connection connexion = DataBase.getInstance();
        ArrayList<Article> liste = new ArrayList<>();
        try {
            String sql = "select titre, texte, likes, dislikes from article";
            PreparedStatement stm = connexion.prepareStatement(sql);
            ResultSet rs = stm.executeQuery(sql);

            while (rs.next()) {
                liste.add(new Article(rs.getString("titre"), rs.getString("texte"),
                        rs.getInt("likes"), rs.getInt("dislikes")));
            }
        } catch (SQLException ex) {
            Logger.getLogger(ArticleDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        connexion.close();
        return liste;
    }

    public static ArrayList<Article> getArticles(String v) throws SQLException {
        ArrayList<Article> sourceList;
        ArrayList<Article> resultList = new ArrayList<>();
        sourceList = ArticleDAO.getAllArticles();

        final String value = v.toLowerCase();
        sourceList.forEach((article) -> {
            if (article.getTitre().toLowerCase().contains(value)
                    || article.getTexte().toLowerCase().contains(value)) {
                resultList.add(article);
            }
        });
        return resultList;
    }

    public static int  setArticles(ArrayList<Article> liste) throws SQLException  {
        Connection connexion = DataBase.getInstance();
        int result = -1;
        for(Article article:liste)
            {
                try {
                    result = setArticle(article, connexion);
                } catch (SQLException ex) {
                    Logger.getLogger(ArticleDAO.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        connexion.close();
        return result;
    }

    public static int setArticle(Article article, Connection connexion) throws SQLException {
        int result = -1;
        try {
            Statement st = connexion.createStatement();
            result = st.executeUpdate("update article set likes = " + article.getLikes()
                    + " , dislikes = " + article.getDislikes() + " where titre = '"
                    + article.getTitre() + "' ;");
        } catch (SQLException ex) {
            Logger.getLogger(ArticleDAO.class.getName()).log(Level.SEVERE, null, ex);
        }
        return result;
    }

    public static ArrayList<Article> getLocalSearch(String v,ArrayList<Article> sourceList) throws SQLException {
        
        ArrayList<Article> resultList = new ArrayList<>();
        final String value = v.toLowerCase();
        sourceList.forEach((article) -> {
            if (article.getTitre().toLowerCase().contains(value)
                    || article.getTexte().toLowerCase().contains(value)) {
                resultList.add(article);
            }
        });
        return resultList;
    }
}
