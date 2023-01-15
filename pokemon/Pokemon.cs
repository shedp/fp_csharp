// ALWAYS REMEMBER THE SEMI-COLON
namespace PokemonGame
{
using System;
//convention for c# is for squiggle brackets to be in line below
//class will have method, constructor
class Pokemon
{
    //making it private or public will lock/unlock access outside the class oo but can expose private,
    //when you make it private, put an underscore in front of variable name
    private string _Name {get; set;} //will auto create getter and setter
    public string Name
    {
        get { return _Name;}
        set { _Name = value;} //if you don't want to let them set , you can remove this
    }
    private int _HP {get; set;}
    public int HP
    {
        get{ return _HP;}
        set { _HP = value;} //if you don't want to let them set , you can remove this
    }
    private int _Attack {get; set;}
    public int Attack
    {
        get{ return _Attack;}
        set { _Attack = value;}
    }
    private int _Defense {get; set;}
    public int Defense
    {
        get{ return _Defense;}
        set { _Defense = value;}
    }

    public Pokemon(string name, int hp, int attack, int defense)
    {
        _Name = name;
        _HP = hp;
        _Attack = attack;
        _Defense = defense;
    }
    //overloading to create new constructor in pokemon class that randomize
    public Pokemon(string name)
    {
        _Name = name;
        Random rand = new Random();
        _HP = rand.Next(30,150); //Next(min,max)
        _Attack = rand.Next(30,100);
        _Defense = rand.Next(30,40);
    }

    public void AttackOpponent(Pokemon opponent) //void means we are not returning anything
    {
        int damage = _Attack + opponent.Defense;
        opponent.HP -= damage;
        Console.WriteLine(_Name + " attack " + opponent.Name + " for " + damage);
    }
}
}