using System;

class Habit : Article
{
    private double taille;
    private string couleur;

    public Habit(int numero_Serie, double prixHT, int quantite_Stock, int quantite_Minimale, double taille, string couleur) : base(numero_Serie, prixHT, quantite_Stock, quantite_Minimale)
    {
        this.taille = taille;
        this.couleur = couleur;
    }

    public override string ToString()
    {
        return base.ToString() + "/n La taille :" + this.taille + "/n Le couleur :" + this.couleur;
    }
}
