using System;
using System.Collections.Generic;

namespace Application2
{
    public class ApplicationLogic
    {

        private List<Person> people { get; set; }

        public ApplicationLogic()
        {
            this.people = new List<Person>();
        }


        /*
         * Create the data buffer
         */
        public List<Person> createDataBuffer(FileManager file)
        {
            //Create an array of splitted strings
            foreach (var line in file.Lines)
            {
                String[] splittedLine = line.Split(';');
           
                //Fill a person object
                people.Add(new Person()
                {
                    Age    = Convert.ToInt32(splittedLine[1]),
                    Gender = Convert.ToChar(splittedLine[0]),
                    Weight = Convert.ToDouble(splittedLine[2]),
                    Height = Convert.ToDouble(splittedLine[3])
                });
            }//foreach

            return people;
            
        }//createDataBuffer()
    

    }//Class
}//namespace