/*https://www.codewars.com/kata/517b0f33cd023d848d000001

Something is wrong with our Warrior class.
The strike method does not work correctly.
The following shows an example of this code being used:

var ninja = new Warrior("Ninja");
var samurai = new Warrior("Samurai");

samurai.Strike(ninja, 3);
// ninja.Health should == 70*/

using System;

public class Warrior
{
    private string name;

    public Warrior(string name)
    {
        this.name = name;
    }

    public int Health { get; set; } = 100;

    public void Strike(Warrior enemy, int swings)
    {
        enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
    }
}