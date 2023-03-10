/********************************************************************
*** NAME : Spencer Zakaras***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 3***
*** DUE DATE : 3/10/23***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : this assignment is to use classes & inheretence to print out a charecter stat block. this file defines the child courier. ***
********************************************************************/

namespace NewVegasNS; //shared namepsace

public class Courier : NewVegas //Class W/Inheritence from the NewVegas class
{
    public Global.ArmorType Armor{get;set;} //Armor type variable storage & get/set methods
    public Global.WeaponType Weapon{get;set;} //Weapon type variable storage & get/set methods


    /********************************************************************
    *** METHOD Courier ***
    *********************************************************************
    *** DESCRIPTION : This is the default constructor for the Courier class ***
    *** INPUT ARGS : N/A - Courier Instance to copy ***
    *** OUTPUT ARGS : N/A ***
    *** IN/OUT ARGS : N/A ***
    *** RETURN : N/A ***
    ********************************************************************/
    public Courier() : base()//original constructor
    {
        this.Armor = Global.ArmorType.LEATHER;
        this.Weapon = Global.WeaponType.KNIFE;
    }
    

    /********************************************************************
    *** METHOD Courier ***
    *********************************************************************
    *** DESCRIPTION : This is the copy constructor of the Courier Object which takes in an instance of the courier class copies its data & creates an exact copy ***
    *** INPUT ARGS : Original - Courier Instance to copy ***
    *** OUTPUT ARGS : N/A ***
    *** IN/OUT ARGS : Original ***
    *** RETURN : N/A ***
    ********************************************************************/
    public Courier(Courier original) : base(original) //copy constructor
    {
            Weapon = original.Weapon;
            Armor = original.Armor;
    }

    /********************************************************************
    *** METHOD Courier ***
    *********************************************************************
    *** DESCRIPTION : This is the default values constructor for the courier class which takes in SPECIAL trait values and provides default armor & weapons***
    *** INPUT ARGS : int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, Global.ArmorType armor, Global.WeaponType weapon ***
    *** OUTPUT ARGS : N/A ***
    *** IN/OUT ARGS : int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, Global.ArmorType armor, Global.WeaponType weapon ***
    *** RETURN : N/A ***
    ********************************************************************/
    public Courier(int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, Global.ArmorType armor = Global.ArmorType.LEATHER, Global.WeaponType weapon = Global.WeaponType.KNIFE) : base(strength, perception, endurance, charisma, intelligence, agility, luck) //default values constructor
    {
        this.Weapon = weapon;
        this.Armor = armor;
    }


    /********************************************************************
    *** METHOD ToString ***
    *********************************************************************
    *** DESCRIPTION : This is the overidden ToString function, which creates it's string from the parent class ToString function & Courier variables ***
    *** INPUT ARGS : N/A ***
    *** OUTPUT ARGS : String - returns string it created ***
    *** IN/OUT ARGS : String ***
    *** RETURN : String ***
    ********************************************************************/
    public override string ToString() //overidden ToString func concatonating 
   {
        return base.ToString() + $"\nArmour:        " + Armor + $"\nWeapon:        " + Weapon; //return created string from base class & courier
   }



}