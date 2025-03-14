namespace cwiczenia1.Inheritance;

public class A : IMyInterface
{
    // Property
    public int Number { get; set; }
    
    //private int number;

    public A(int number)
    {
        //this.number = number;
        Number = number;
    }
    
    //public int getNumber() { return number; }
    //public void setNumber(int number) { this.number = number; }
    
    public virtual void SendMessage(string message)
    {
        Console.WriteLine(message);
    }
}