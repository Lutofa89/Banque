//Créer une classe "Personne" implémentant:
//  les propriétés publiques
//  string Name
//  string LastName
//  DateTime BirthDate
//commentaire AHMED 06 11 2022

namespace Banque
{


    public class Personne
    {

        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

    }
    
    public class CurrentAccount
    {
        public string Number { get; set; }  
        public double Balance { get; set; }

        public double CreditLine { get; set; }

        public Personne Owner { get; set; }

        void Withdrawat(double amount)
        {
            Balance = Balance - amount;
        }

        public class Bank
        {
            
        }
    }













}
