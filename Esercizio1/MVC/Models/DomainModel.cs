using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO;

namespace MVC.Models {
    public class DomainModel {
        DataAccessObject dao = new DataAccessObject();
        public void AggiungiMenu (Menu menu) {
            try {
                dao.AggiungiMenu(menu);
            } catch (SystemException) {
                throw new Exception("Errore di sistema!");
            }
        }
        public List<Menu> VisualizzaMenus () {
            List<Menu> result = null;
            try {
                result = dao.VisualizzaMenus();
            } catch (SystemException) {
                throw new Exception("Errore di sistema!");
            }
            return result;
        }
        public Menu VisualizzaMenu (Menu menu) {
            Menu result = null;
            try {
                result = dao.VisualizzaMenu(menu);
            } catch (SystemException) {
                throw new Exception("Errore di sistema!");
            }
            return result;
        }
    }
}