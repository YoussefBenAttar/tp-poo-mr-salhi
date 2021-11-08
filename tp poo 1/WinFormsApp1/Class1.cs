using System;
using System.Collections.Generic;
using System.Text;

namespace anas_devoir2
{
    class Article
    {

        private int numérodesérie;
        private int prixhorstaxe;
        private int quantitéenstock;
        private int quantitéminimale;

        public Article(int numérodesérie, int prixhorstaxe, int quantitéenstock, int quantitéminimale)
        {
            this.numérodesérie = numérodesérie;
            this.prixhorstaxe = prixhorstaxe;
            this.quantitéenstock = quantitéenstock;
            this.quantitéminimale = quantitéminimale;
        }
        public Article() { }
    }
    class Habit : Article
    {
        private string couleur;
        private string taille;

        public Habit()
        {
        }

        public Habit(string couleur, string taille)
        {
            this.couleur = couleur;
            this.taille = taille;

        }
        class Electroménager : Article
        {
            private int poid;
            private int durée;

            public Electroménager(int poid, int durée)
            {
                this.poid = poid;
                this.durée = durée;
            }

        }

    }

}
