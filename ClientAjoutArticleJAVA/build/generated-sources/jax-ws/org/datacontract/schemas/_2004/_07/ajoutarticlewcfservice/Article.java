
package org.datacontract.schemas._2004._07.ajoutarticlewcfservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour Article complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType name="Article"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Dislikes" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="Likes" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="Texte" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Titre" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Article", propOrder = {
    "dislikes",
    "likes",
    "texte",
    "titre"
})
public class Article {

    @XmlElement(name = "Dislikes")
    protected Integer dislikes;
    @XmlElement(name = "Likes")
    protected Integer likes;
    @XmlElementRef(name = "Texte", namespace = "http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", type = JAXBElement.class, required = false)
    protected JAXBElement<String> texte;
    @XmlElementRef(name = "Titre", namespace = "http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", type = JAXBElement.class, required = false)
    protected JAXBElement<String> titre;

    /**
     * Obtient la valeur de la propriété dislikes.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getDislikes() {
        return dislikes;
    }

    /**
     * Définit la valeur de la propriété dislikes.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setDislikes(Integer value) {
        this.dislikes = value;
    }

    /**
     * Obtient la valeur de la propriété likes.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getLikes() {
        return likes;
    }

    /**
     * Définit la valeur de la propriété likes.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setLikes(Integer value) {
        this.likes = value;
    }

    /**
     * Obtient la valeur de la propriété texte.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getTexte() {
        return texte;
    }

    /**
     * Définit la valeur de la propriété texte.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setTexte(JAXBElement<String> value) {
        this.texte = value;
    }

    /**
     * Obtient la valeur de la propriété titre.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getTitre() {
        return titre;
    }

    /**
     * Définit la valeur de la propriété titre.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setTitre(JAXBElement<String> value) {
        this.titre = value;
    }

}
