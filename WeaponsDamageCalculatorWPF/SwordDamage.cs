﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WeaponsDamageCalculator
{
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public int Roll;
        //private fields are lowercase
        private decimal magicMultiplier = 1M;
        private int flamingDamage = 0;
        public int Damage;

        private void CalculateDamage()
        {
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                magicMultiplier = 1.75M;
            }
            else
            {
                magicMultiplier = 1M;
            }

            CalculateDamage();
            Debug.WriteLine($"SetMagic finished: {Damage} (roll: {Roll})");
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();

            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
            Debug.WriteLine($"SetFlaming finished: {Damage} (roll: {Roll})");
        }
    }
}
