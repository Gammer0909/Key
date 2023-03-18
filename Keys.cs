using System;
using CodeMaker;


public class Button
{

    public static LinkedList<string> codes = new LinkedList<string>();

    string buttonName;

    ConsoleColor[] colors = new ConsoleColor[4] { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow };

    public void Press()
    {
        Random r = new Random();
        Console.BackgroundColor = colors[r.Next(0, 4)];
        Console.Write(" ");
        Console.ResetColor();
        Console.WriteLine("The Button beeps");

    }

    public void AddCode(string code)
    {

        codes.AddLast(code);

    }

    public Button(string name)
    {

        this.buttonName = name;

    }

}

class Key
{

    Button[] buttons;

    private Room position;
    public enum Room
    {
        LivingRoom,
        Bathroom,
        Kitchen,
        Bedroom,
    }

    public Room Locate()
    {

        Random r = new Random();
        int roomNumber = r.Next(0, 4);
        Room room = (Room) roomNumber; 
        this.position = room;
        return room;

    }

    public Key(Button b)
    {

        this.buttons = new Button[1];
        this.buttons[0] = b;



    }

    public void AddButton(Button b)
    {

        if (this.buttons == null)
        {

            this.buttons = new Button[1];
            this.buttons[0] = b;

        }
        else
        {

            Button[] temp = new Button[this.buttons.Length + 1];
            for (int i = 0; i < this.buttons.Length; i++)
            {

                temp[i] = this.buttons[i];

            }
            temp[this.buttons.Length] = b;
            this.buttons = temp;

        }

    

    }

}



public class Mainprgm
{

    static void Main(string[] args)
    {   
        Button lockButton = new Button("lock");
        Button unlockButton = new Button("unlock");
        Key k = new Key(lockButton);
        k.AddButton(unlockButton);
        lockButton.AddCode(Coder.CreateCode(10));
        unlockButton.AddCode(Coder.CreateCode(10));
        k.Locate(); //no need to print location, it prints in the method.
        lockButton.Press();
        unlockButton.Press();

    }


}