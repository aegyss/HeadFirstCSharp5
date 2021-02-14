using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HeadFirstCSharp5
{
    public class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        decimal Multiplier = 1M;
        int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * Multiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"CalculateDamage finished: {Damage}. Roll: {Roll}");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
                Multiplier = 1.75M;
            else
                Multiplier = 1M;
            CalculateDamage();
            Debug.WriteLine($"SetMagic finished: {Damage}. Roll: {Roll}");
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
            Debug.WriteLine($"SetFlaming finished: {Damage}. Roll: {Roll}");
        }
    }
}
