using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmTabControlApp.Models
{
   public class ModelClass
    {
        public static readonly Random random = new Random();
        public PersonClass[] GetPeople() => new PersonClass[]
        {
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Jane Doe", Birthday = new DateTime(1974, 1, 17), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" },
            new PersonClass() { Id = random.Next(0, 1_000_000), FullName = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgc_s7XbEi30VvcmRyAurEfFPD1aPcmzf2GnOtrIaM6FTop3DQ2g" }
        };
    }
}
