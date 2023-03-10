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