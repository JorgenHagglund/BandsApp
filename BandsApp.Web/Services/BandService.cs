using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    List<Band> bands = new List<Band>
    {
        new Band { Id = 1, Name = "Jorn", Description = "Jorn is a Norwegian hard rock and metal band fronted by vocalist Jørn Lande. Other members include guitarist Tore Moren, bassist Sid Ringsby and drummer Francesco Jovino. The band was established in 2000 by Lande and the debut album Starfire was released the same year. The band was the main artist at ProgPower USA in 2006, and they played at the Norway Rock Festival and the Metal Heart Festival in 2007, as well as the Jorddunst Festival in 2009. They also played at the Norway Rock Festival in 2010.", Image = "/Images/Jorn.jpg", VideoUrl= "https://www.youtube.com/embed/aL8HZuHi9AQ?si=LHI6pejhlc3_2xLx"},
        new Band { Id = 2, Name = "Iron Maiden", Description = "Iron Maiden are an English heavy metal band formed in Leyton, East London, in 1975 by bassist and primary songwriter Steve Harris. Although fluid in the early years of the band, the line-up for most of the band's history has consisted of Harris, lead vocalist Bruce Dickinson, drummer Nicko McBrain, and guitarists Dave Murray, Adrian Smith and Janick Gers. As pioneers of the new wave of British heavy metal movement, Iron Maiden released a series of UK and US Platinum and Gold albums, including 1980's debut album, 1981's Killers, and 1982's The Number of the Beast – its first album with Dickinson, who in 1981 replaced Paul Di'Anno as lead singer. The addition of Dickinson was a turning point in their career, establishing them as one of heavy metal's most important bands. The Number of the Beast is among the most popular heavy metal albums of all time, having sold almost 20 million copies worldwide.", Image = "/Images/IronMaiden.jpg", VideoUrl= "https://www.youtube.com/embed/86URGgqONvA?si=STTFbZgCF8AR9CDq" },
        new Band { Id = 3, Name = "Amazarashi", Description = "Amazarashi (stylized as amazarashi) is a Japanese rock band from Aomori, currently signed to Sony Music Japan. Formed in 2007, its members are Hiromu Akita (lead vocals, guitar, songwriter) and Manami Toyokawa (keyboard).[1] They have released six singles which have all reached the top 20 of the Oricon charts.", Image = "/Images/Amazarashi.webp", VideoUrl = "https://www.youtube.com/embed/gB3gUq5A1W0?si=DMOTIBeKVoO3gmGp" }
    };

    public Band[] GetAllBands() =>
        bands.OrderBy(b => b.Name)
        .ToArray();

    public Band? GetBandById(int id) =>
        bands.SingleOrDefault(b => b.Id == id);
}
