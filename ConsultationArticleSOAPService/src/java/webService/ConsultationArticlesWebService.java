/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webService;

import controle.Article;
import controle.ArticleDAO;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author RAM
 */
@WebService(serviceName = "ConsultationArticlesWebService")
public class ConsultationArticlesWebService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "getArticles")
    public ArrayList<Article> getArticles(@WebParam(name = "value") String value) {
        try {
            return ArticleDAO.getArticles(value);
        } catch (SQLException ex) {
            Logger.getLogger(ConsultationArticlesWebService.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
    
    @WebMethod(operationName = "getAllArticles")
    public ArrayList<Article> getAllArticles() {
        try {
            return ArticleDAO.getAllArticles();
        } catch (SQLException ex) {
            Logger.getLogger(ConsultationArticlesWebService.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
    
    @WebMethod(operationName = "setArticles")
    public  int setArticles(@WebParam(name = "liste") ArrayList<Article> liste)  {
        try {
            return  ArticleDAO.setArticles(liste);
        } catch (SQLException ex) {
            Logger.getLogger(ConsultationArticlesWebService.class.getName()).log(Level.SEVERE, null, ex);
        }
        return -1;
    }
    
    @WebMethod(operationName = "getLocalSearch")
    public ArrayList<Article> getLocalSearch(@WebParam(name = "value") String value,@WebParam(name = "liste") ArrayList<Article> liste) {
        try {
            return ArticleDAO.getLocalSearch(value,liste);
        } catch (SQLException ex) {
            Logger.getLogger(ConsultationArticlesWebService.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }

}
