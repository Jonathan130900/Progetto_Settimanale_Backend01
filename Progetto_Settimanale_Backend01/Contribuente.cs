using System;

public class Contribuente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public char Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public decimal RedditoAnnuale { get; set; }

    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }


    public decimal CalcolaImposta()
    {
        decimal imposta = 0;

        if (RedditoAnnuale <= 15000)
            imposta = RedditoAnnuale * 0.23m;
        else if (RedditoAnnuale <= 28000)
            imposta = (15000 * 0.23m) + ((RedditoAnnuale - 15000) * 0.27m);
        else if (RedditoAnnuale <= 55000)
            imposta = (15000 * 0.23m) + (13000 * 0.27m) + ((RedditoAnnuale - 28000) * 0.38m);
        else if (RedditoAnnuale <= 75000)
            imposta = (15000 * 0.23m) + (13000 * 0.27m) + (27000 * 0.38m) + ((RedditoAnnuale - 55000) * 0.41m);
        else
            imposta = (15000 * 0.23m) + (13000 * 0.27m) + (27000 * 0.38m) + (20000 * 0.41m) + ((RedditoAnnuale - 75000) * 0.43m);

        return imposta;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} {Cognome}\n" +
               $"Data di nascita: {DataNascita:dd-MM-yyyy} ({Sesso})\n" +
               $"Codice Fiscale: {CodiceFiscale}\n" +
               $"Comune di residenza: {ComuneResidenza}\n" +
               $"Reddito annuale dichiarato: {RedditoAnnuale:N2} €\n" +
               $"IMPOSTA DA VERSARE: {CalcolaImposta():N2} €";
    }
}
