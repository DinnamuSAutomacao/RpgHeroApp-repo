using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHeroApp.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{this.Name} lançou sua magia!";
        }
    }
}
