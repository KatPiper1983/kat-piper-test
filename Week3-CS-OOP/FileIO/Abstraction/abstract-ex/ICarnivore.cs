interface ICarnivore
{
     public int Value {get; set;}
     

     void EatMeat(); //assumed to be abstract (traditionally)
     //implied
     //default access modifier in Interfaces is public bc (traditionally)
     //private would not have made sense
}