using NewVegasNS; //File Linking Namespace 
Console.WriteLine("made it here"); //test to open main

    Courier Charecter = new Courier(8, 3, 2, 4, 6, 6, 7, Global.ArmorType.POWER, Global.WeaponType.KNIFE); //create NewVegas charecter object to test input & default values constructor
    Courier Charecter2 = new Courier(); //create NewVegas charecter object to test default values constructor 
    Courier Charecter3 = new Courier(Charecter);//create NewVegas charecter object to test copy constructor

    Console.WriteLine(Charecter.ToString()); //print out charecter stats using diffrent constructors
    Console.WriteLine(Charecter2.ToString());
    Console.WriteLine(Charecter3.ToString());