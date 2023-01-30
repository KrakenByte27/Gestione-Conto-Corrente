namespace Gestione_Calciatori.Classi
{
    class Cliente
    {
        public Cliente(string nome1, string cognome1, string indirizzo1)
        {
            Nome = nome1;
            Cognome = cognome1;
            Indirizzo = indirizzo1;
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public decimal Saldo { get; set; }
    }
}
