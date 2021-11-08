using System;

class Electromenager : Article
{
    private float poinds;
    private int duree_de_garantie;

    public Electromenager(int numero_Serie, double prixHT, int quantite_Stock, int quantite_Minimale, float poinds, int duree_de_garantie)
    {
        this.poinds = poinds;
        this.duree_de_garantie = duree_de_garantie
        }

    public DateTime date_de_fin_garantie;
        {
            DateTime dt;
            return dt = DateTime.Now.AddMonths(this.duree_de_garantie );
    }

    public override string ToString()
    {
        DateTime dt = date_de_fin_garantie;
        return base.ToString() + "/n Le poids:" + this.poids + "/n La durée de garantie:" + dt.ToString();
    }
}