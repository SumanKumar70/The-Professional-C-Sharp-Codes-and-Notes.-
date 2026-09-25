using System;

class Button
{
   
    public event EventHandler Clicked;

   
    public void Click()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[]args)
    {
        Button button = new Button();

       
        button.Clicked += ButtonClicked;

     
        button.Click();
    }

    
    static void ButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Button was clicked!");
    }
}
