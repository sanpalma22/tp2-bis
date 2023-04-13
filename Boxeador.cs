class Boxeador
{
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public int Peso { get; set; }
    public int PotenciaGolpes { get; set; }
    public int VelocidadPiernas { get; set; }
    public Boxeador(string nom = "", string pais = "", int peso = 0, int pg = 0, int vp = 0)
    {
        Nombre = nom;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }
    public double ObtenerSkil()
    {
        Random rdm = new Random();
        int numRandom = rdm.Next(1, 10);
        double numSkill = VelocidadPiernas * 0.6 + PotenciaGolpes * 0.8 + numRandom;
        return numSkill;
    }
}