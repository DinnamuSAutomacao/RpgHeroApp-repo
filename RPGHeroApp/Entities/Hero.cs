using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHeroApp.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero() { }

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada!";
        }

        public override string ToString()
        {
            return $"Dados do herói - Name:{this.Name}, Level: {this.Level}, Hero Type:{this.HeroType}";
        }
    }
}
