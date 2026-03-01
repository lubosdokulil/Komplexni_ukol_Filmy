namespace Komplexni_ukol_Filmy.Models
{
    public static class DatabazeFilmu
    {
        // Zde budeme uchovávat všechny filmy po dobu běhu aplikace
        public static List<Film> Seznam { get; set; } = new List<Film>();
    }
}
