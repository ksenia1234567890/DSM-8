using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр8
{
    public class Dog
    {
        private string breed;
        private int withers;
        private int age;
        private string name;

        // Свойство: имя

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Свойство: порода

        public string Breed
        {
            get
            {
                return breed;
            }
            
            set
            {
                if(value=="боксер" || value == "овчарка" || value == "терьер" || value == "такса" || value == "пудель" || value == "доберман")
                {
                    breed = value;
                }
            }
        }

        // Свойство: высота холки

        public int Withers
        {
            get
            {
                return withers;
            }

            set
            {
                withers = value;
            }
        }

        // Свойство: возраст

        public int Age
        {
            get
            {
                return withers;
            }

            set
            {
               if(value<22)
                {
                    age = value;
                }
            }
        }
    }
}
