/********************************************************************
*** NAME : Spencer Zakaras***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 3***
*** DUE DATE : 3/10/23***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : this assignment is to use classes & inheretence to print out a charecter stat block. this file defines two enumerated data types used in those stat blocks. ***
********************************************************************/

namespace NewVegasNS; //shared namespace


    public static class Global //Global Class containing two enumerated data types, avalible to all files with shared namespace
    {
        public enum ArmorType //enumerated data type defined for Armor Type
        {
            NONE,
            LEATHER,
            METAL,
            POWER
       }

       public enum WeaponType //enumerated data type defined for Weapon types
        {
            NONE,
            KNIFE,
            PISTOL,
            RIFLE,
            SHOTGUN
       }
    }