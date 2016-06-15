using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProfiler
{
    class Animal
    {
        int age;
        string name;
        string breed;

        private int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        private string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public virtual void displayAge()
        {

        }

        public virtual void displayName()
        {

        }

        public virtual void displayBreed()
        {

        }

        public virtual void setAge()
        {

        }

        public virtual void setName()
        {

        }

        public virtual void setBreed()
        {

        }
    }
}
