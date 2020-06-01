<%-- 
    Document   : index
    Created on : 23 nov. 2019, 08:54:40
    Author     : RAM
--%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
    <head>
        <title>TODO supply a title</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="style.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <form id="frm" name="Form" action="saveArticle" method="post">
            <table id="table" border="1" align="center">
                <thead>
                    <tr>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr><td colspan="2" align="center" >Saisie nouveau article</td></tr>
                    <tr>
                        <td>Titre </td>
                        <td  ><input  name="titre" size="66" maxlength="100" type="text" value="" required="" /></td>
                    </tr>
                    <tr>
                        <td>Texte </td>
                        <td>
                            <textarea rows='7' name="texte" cols='50' maxlength="65000" required=""></textarea>
                        </td>
                    </tr>
                    <tr align="center">
                        <td colspan="2" align="center"><input type="submit" value="envoyer" name="submit" /></td>   
                    </tr>
                    <tr align="center">
               <td colspan="2" align="center"> <h4 ><font color="${requestScope.resultat == 1?'green':'red'}"> ${requestScope.message}   </font></h4></td>  
                </tr>
                </tbody>
            </table>
        </form> 
    </body>
</html>
