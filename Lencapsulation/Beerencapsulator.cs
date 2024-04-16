using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lencapsulation
{
    internal class Beerencapsulator
    {
        private double _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;
        public Beerencapsulator()
        {           
            
        }
        public double GetAvalaibleBeerVolume()
        {
            return _avalaibleBeerVolume;
        }
        public int GetAvalaibleBottles()
        {
            return _avalaibleBottles;
        }
        public int GetAvalaibleCapsules()
        {
            return _avalaibleCapsules;
        }
        public void SetAvalaibleBottles(int bottles)
        {
            _avalaibleBottles = bottles;
        }
        public void SetAvalaibleCapsules(int capsules)
        {
            _avalaibleCapsules = capsules;
        }
        public void AddBeer(double quantite)
        {


            if (quantite > 0)
            {
                _avalaibleBeerVolume += quantite;
            }
            else
            {
                Console.WriteLine("Quantité de bière ajoutée invalide!!  ");
            }
            

        }
        public int ProduceEncapsulatedBeerBottles(int nbBottles)
        {
           if (nbBottles <= 0)
            {
                Console.WriteLine(" Nombre de bouteilles non valide !!");
                return 0;
            }

             var bouteillesPossibles = _avalaibleBeerVolume / 33;
           

            if( bouteillesPossibles>= nbBottles && _avalaibleCapsules>=nbBottles)
            {
                _avalaibleBottles -= nbBottles;
                _avalaibleCapsules -= nbBottles;
                _avalaibleBeerVolume -= nbBottles * 33;
                return nbBottles;
            }
            if(bouteillesPossibles==0 || _avalaibleCapsules==0 )
            {
                return 0;
            }
             int res = (int)Math.Min(bouteillesPossibles, _avalaibleCapsules);
            _avalaibleBottles -= (int)res;
            _avalaibleCapsules -= (int)res;
            _avalaibleBeerVolume = (int)res;
            return (int)res;

            }
            
        }
    }
 

