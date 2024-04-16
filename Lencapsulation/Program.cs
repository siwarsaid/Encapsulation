namespace Lencapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Beerencapsulator machine = new Beerencapsulator();

            Console.Write("Saisie le volume de bière: ");
            double volumeBeer = double.Parse(Console.ReadLine()+"\n");
            while (volumeBeer <= 0)
            {
                Console.WriteLine("Quantité de bière ajoutée invalide!!  \n");
                Console.Write("Saisie le volume de bière: ");
                volumeBeer = double.Parse(Console.ReadLine() + "\n");
            }
            machine.AddBeer(volumeBeer);

            Console.Write("Saisie les bouteilles vides: ");
            int bouteilles = Int32.Parse(Console.ReadLine() + "\n");
            while (bouteilles < 0)
            {
                Console.WriteLine("Le nombre de bouteilles ne peut pas être négatif !!");
                Console.Write("Saisie les bouteilles vides: ");
                bouteilles = Int32.Parse(Console.ReadLine() + "\n");
            }
            machine.SetAvalaibleBottles(bouteilles);

            Console.Write("Saisie le nombre des capsules : ");
             int capsules = Int32.Parse(Console.ReadLine() + "\n");

             while (capsules < 0) 
              {
                Console.Write("Le nombre de capsules ne peut pas être négatif!! "); 
              
                Console.Write("Saisie le nombre des capsules : \n");
                capsules = Int32.Parse(Console.ReadLine() + "\n");
              }


                machine.SetAvalaibleCapsules(capsules);
            Console.Write("Saisie le nombre des bouteilles a produire: ");
            int boteillesaProduire = Int32.Parse(Console.ReadLine() + "\n");

            Console.WriteLine( machine.ProduceEncapsulatedBeerBottles(boteillesaProduire) + " bouteilles sont produites \n");

            Console.WriteLine(" Volume de bière restant : " + machine.GetAvalaibleBeerVolume() + " cl\n");
            Console.WriteLine(machine.GetAvalaibleBottles() + " bouteilles restantes \n");
            Console.WriteLine(machine.GetAvalaibleCapsules() + " capsules restantes \n");

           
        }

    }
}
