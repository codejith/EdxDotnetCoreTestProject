

namespace TestApp.Models {
    public class Movie {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genres [] Genre { get; set; }
        public bool IsInStore { get; set; }    
    }

    public enum Genres {
        Action,
        Advanture,
        Comedy,
        Drama,
        War
    }
}