/********************************************************************
*** NAME : Spencer Zakaras***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 3***
*** DUE DATE : 3/10/23***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : this assignment is to use classes & inheretence to print out a charecter stat block. this file defines the parent NewVegas class. ***
********************************************************************/

namespace NewVegasNS; //shared namespace

    public abstract class NewVegas //declare NewVegas Class & prepare to define IView functions
    {
        public int Strength{get;set;} //strength int variable storage & get/set methods
        public int Perception{get;set;} //Perception int variable storage & get/set methods
        public int Endurance{get;set;} //Endurance int variable storage & get/set methods
        public int Charisma{get;set;} //Charisma int variable storage & get/set methods
        public int Intelligence{get;set;} //Intelligence int variable storage & get/set methods
        public int Agility{get;set;} //Agility int variable storage & get/set methods
        public int Luck{get;set;} //Luck int variable storage & get/set methods


        /********************************************************************
*** METHOD NewVegas ***
*********************************************************************
*** DESCRIPTION : This is the Copy Contructor of the NewVegas object ***
*** INPUT ARGS : original - NewVegas Object to copy ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : original ***
*** RETURN : N/A ***
********************************************************************/
        public NewVegas(NewVegas original) //copy constructor
        {
            Strength = original.Strength;
            Perception = original.Perception; //Truth is, the game was rigged from the start
            Endurance = original.Endurance;
            Charisma = original.Charisma;
            Intelligence = original.Intelligence;
            Agility = original.Agility;
            Luck = original.Luck;
        }



/********************************************************************
*** METHOD NewVegas ***
*********************************************************************
*** DESCRIPTION : This is the default value Contructor of the NewVegas object ***
*** INPUT ARGS : name, strength, perception, endurance, charisma, Intelligence, Agility, Luck - All of these properties have default values initialized ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : name, strength, perception, endurance, charisma, Intelligence, Agility, Luck
*** RETURN : N/A ***
********************************************************************/
        public NewVegas(int strength = 5, int perception = 5, int endurance = 5, int charisma = 5, int intelligence = 5, int agility = 5, int luck = 5) //default values constructor
        {
            Strength = strength; //hail Caesar
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;

        }

         /********************************************************************
        *** METHOD ToString ***
        *********************************************************************
        *** DESCRIPTION : This is the overidden ToString function, which creates it's string from NewVegas variables ***
        *** INPUT ARGS : N/A ***
        *** OUTPUT ARGS : String - returns string it created ***
        *** IN/OUT ARGS : String ***
        *** RETURN : String ***
        ********************************************************************/
        public override string ToString()
        {
            string ToReturn = $"Strength:      " + Strength + "\nPerception:    " + Perception + "\nEndurance:     " + Endurance + "\nCharisma:      " + Charisma + "\nIntelligence:  " + Intelligence + "\nAgility:       " + Agility + "\nLuck:          " + Luck;
            return ToReturn;
        }
    }