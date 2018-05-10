using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAO {
    public interface IDao {
        void AggiungiMenu (Menu menu);
        List<Menu> VisualizzaMenus();
        Menu VisualizzaMenu (Menu menu);
    }

    public class DataAccessObject : IDao {
        public void AggiungiMenu(Menu menu) {}

        public Menu VisualizzaMenu(Menu menu) {
            return new DatiMock().MenuMock()[0];
        }

        public List<Menu> VisualizzaMenus() {
            return new DatiMock().MenuMock();
        }
    }

    public class Menu {
        public int Id;
        public DateTime Giorno {get; set;}
        public string TipoPasto {get; set;}
        public List<Pietanza> Pietanze {get; set;}
        public Menu () {}
        public Menu (DateTime giorno, string tipo, List<Pietanza> pietanze) {
            this.Giorno = giorno;
            this.TipoPasto = tipo;
            this.Pietanze = pietanze;
        }
    }
    public class Pietanza {
        public int Id;
        public string NomePietanza {get; set;}
        public string TipoPietanza {get; set;}
        public Pietanza (int id, string nome, string tipo) {
            this.Id = id;
            this.NomePietanza = nome;
            this.TipoPietanza = tipo;
        }
    }

    public class DatiMock {
        public List<Menu> MenuMock () {
            Pietanza piatto1 = new Pietanza(1, "Spaghetti alla Carbonara", "Primo");
            Pietanza piatto2 = new Pietanza(2, "Penne all'Amatriciana", "Primo");
            Pietanza piatto3 = new Pietanza(3, "Risotto Panna e Zafferano", "Primo");
            Pietanza piatto4 = new Pietanza(4, "Minestrone (salutare ma non buono)", "Primo");
            Pietanza piatto5 = new Pietanza(5, "Cotoletta di pollo (che piace tanto a Max e Fede)", "Secondo");
            Pietanza piatto6 = new Pietanza(6, "Omelette alle Erbette", "Secondo");
            Pietanza piatto7 = new Pietanza(7, "Zizzona da 1Kg", "Secondo");
            Pietanza piatto8 = new Pietanza(8, "Maiale Arrosto (per Nauman)", "Secondo");
            Pietanza piatto9 = new Pietanza(9, "Patate Fritte (sempre per Max e Fede)", "Contorno");
            Pietanza piatto10 = new Pietanza(10, "Carote Bollite (salutari, ma un po' meh)", "Contorno");
            Pietanza piatto11 = new Pietanza(11, "Crauti", "Contorno");
            Pietanza piatto12 = new Pietanza(12, "Insalata", "Contorno");
            Pietanza piatto13 = new Pietanza(13, "Tiramisu (per Luca Gent)", "Dolce");
            Pietanza piatto14 = new Pietanza(14, "Torta al Cioccolato (che piace tanto a Matte)", "Dolce");
            Pietanza piatto15 = new Pietanza(15, "Cassata Siciliana (per AlessioTutteCose anche se è assente)", "Dolce");
            Pietanza piatto16 = new Pietanza(16, "Pastiera Napoletana (per Carmen)", "Dolce");
            List<Pietanza> pranzo1 = new List<Pietanza>();
            List<Pietanza> pranzo2 = new List<Pietanza>();
            List<Pietanza> cena1 = new List<Pietanza>();
            List<Pietanza> cena2 = new List<Pietanza>();
            pranzo1.Add(piatto1);
            pranzo1.Add(piatto5);
            pranzo1.Add(piatto9);
            pranzo1.Add(piatto13);
            pranzo2.Add(piatto2);
            pranzo2.Add(piatto6);
            pranzo2.Add(piatto10);
            pranzo2.Add(piatto14);
            cena1.Add(piatto3);
            cena1.Add(piatto7);
            cena1.Add(piatto11);
            cena1.Add(piatto15);
            cena2.Add(piatto4);
            cena2.Add(piatto8);
            cena2.Add(piatto12);
            cena2.Add(piatto16);
            Menu menu1 = new Menu(new DateTime(2018, 5, 9), "Pranzo", pranzo1);
            Menu menu2 = new Menu(new DateTime(2018, 5, 9), "Cena", cena1);
            Menu menu3 = new Menu(new DateTime(2018, 5, 10), "Pranzo", pranzo2);
            Menu menu4 = new Menu(new DateTime(2018, 5, 10), "Cena", cena2);
            List<Menu> menus = new List<Menu>();
            menus.Add(menu1);
            menus.Add(menu2);
            menus.Add(menu3);
            menus.Add(menu4);
            return menus;
        }
    }
}