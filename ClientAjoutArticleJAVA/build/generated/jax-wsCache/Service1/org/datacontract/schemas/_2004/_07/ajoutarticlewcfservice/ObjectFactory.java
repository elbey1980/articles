
package org.datacontract.schemas._2004._07.ajoutarticlewcfservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.datacontract.schemas._2004._07.ajoutarticlewcfservice package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _Article_QNAME = new QName("http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", "Article");
    private final static QName _ArticleTexte_QNAME = new QName("http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", "Texte");
    private final static QName _ArticleTitre_QNAME = new QName("http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", "Titre");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.datacontract.schemas._2004._07.ajoutarticlewcfservice
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link Article }
     * 
     */
    public Article createArticle() {
        return new Article();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Article }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", name = "Article")
    public JAXBElement<Article> createArticle(Article value) {
        return new JAXBElement<Article>(_Article_QNAME, Article.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", name = "Texte", scope = Article.class)
    public JAXBElement<String> createArticleTexte(String value) {
        return new JAXBElement<String>(_ArticleTexte_QNAME, String.class, Article.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/AjoutArticleWCFService", name = "Titre", scope = Article.class)
    public JAXBElement<String> createArticleTitre(String value) {
        return new JAXBElement<String>(_ArticleTitre_QNAME, String.class, Article.class, value);
    }

}
