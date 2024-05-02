class Thing
{
    //Scopes

    //Object Scope - exists within any object of this class
    public int objectNum;

     //Class Scope
     public static  int classNum = 10;
     public static int count = 0;
    public Thing()
    {
        objectNum = 100;
        count++;
    }
    
    public static void StaticMethod()
    {
        //Static methods cannot use non-static members (fields and methods)
        System.Console.WriteLine(count);
        System.Console.WriteLine(classNum);
        //System.Console.WriteLine(objectNum);
        //SomeMethod();
        
        System.Console.WriteLine("This is a static method from the Thing Class!");
    }

    //Method Scope
    public void SomeMethod(int paraNum)
    {
        int methodNum = 10;

        //Parameters and variables created within a Method can be used so long as we
        //are still in that method
        System.Console.WriteLine(paraNum);
        System.Console.WriteLine(methodNum);

        //Can still access the Object/Class Scoped variables
        System.Console.WriteLine(objectNum);
        System.Console.WriteLine(classNum);

        //block Scope- any variable created within a *block* of code
        // can only be used within that context
        // Ex: Conditionals/Loops/ etc....

        if(true)
        {
            int blockNum = 100;
            System.Console.WriteLine(blockNum);
        }
        else
        {
            //cannot use block scoped variable above since have left that block of code
            //Console.WriteLine(blockNum)
        }
        for(int i = 1; i<= 100; i++)
        {
            System.Console.WriteLine(i);
        }
        //cannot use the block scoped variable above "i
        //since have left block of code
        //Console.WriteLine(i);
    }
}