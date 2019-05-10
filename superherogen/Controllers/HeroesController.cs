using System;
using Microsoft.AspNetCore.Mvc;
namespace superherogen
{
    public class HeroesController
    {
        public HeroesController
        {
        }

        public Person Get(string firstName, string lastName)
        {
            var p =  new Person() {FirstName = firstName, FastName = lastName};
            p.SetHeroName();
            return p;
        }
    }
}