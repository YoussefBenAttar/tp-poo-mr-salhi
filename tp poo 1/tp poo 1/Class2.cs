using System;

class Article
{
    protected int numero_Serie;
    protected double prixHT;
    protected int quantite_Stock;
    protected int quantite_Minimale;


    public Article()
    {

    }

    public Article(int numero_Serie, double prixHT, int quantite_Stock, int quantite_Minimale)
    {
        this.numero_Serie = numero_Serie;
        this.prixHT = prixHT;
        this.quantite_Stock = quantite_Stock;
        this.quantite_Minimale = quantite_Minimale;
    }

    public override string ToString()
    {
        return GetType().name + ":/n" + "Numero de série:" + this.numero_Serie + "/n Le prix Hors Taxe :" + this.prixHT + "/n" + " la quantite de Stock :" + this.quantite_Stock + "/n" + "La quantite Minimale " + this.quantite_Minimale;
    }


    public void Sapprovisionner(int qte)
    {
        this.quantite_Stock += qte;
    }


    public void Achat(int qte)
    {
        this.quantite_Stock -= qte;
        if (this.quantite_Stock < this.quantite_Minimale)
            console.writeLine("Erreur")
        }
}