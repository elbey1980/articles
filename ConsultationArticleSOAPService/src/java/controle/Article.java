/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controle;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Article {

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

    public Article(String titre, String texte, int likes, int dislikes) {
        this.titre = titre;
        this.texte = texte;
        this.likes = likes;
        this.dislikes = dislikes;
    }

    public String getTitre() {
        return titre;
    }

    public void setTitre(String titre) {
        this.titre = titre;
    }

    public String getTexte() {
        return texte;
    }

    public void setTexte(String texte) {
        this.texte = texte;
    }

    public int getLikes() {
        return likes;
    }

    public void setLikes(int likes) {
        this.likes = likes;
    }

    public int getDislikes() {
        return dislikes;
    }

    public void setDislikes(int dislikes) {
        this.dislikes = dislikes;
    }

}
