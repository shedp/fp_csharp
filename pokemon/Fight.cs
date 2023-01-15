namespace PokemonGame;

class Fight
{
    private Pokemon _Player1;
    public Pokemon Player1
    {
        get { return _Player1;}
        set { _Player1 = value;}
    }
    private Pokemon _Player2;
    public Pokemon Player12
    {
        get { return _Player2;}
        set { _Player2 = value;}
    }

    public Fight(Pokemon player1, Pokemon player2)
    {
        _Player1 = player1;
        _Player2 = player1;
    }

    public Pokemon Battle()
    {
        while (_Player1.HP > 0 && _Player2.HP > 0)
        {
            _Player1.AttackOpponent(_Player2);
            if (_Player2.HP > 0)
            {
                _Player2.AttackOpponent(_Player1);
            }
        }
    
        if (_Player1.HP <= 0)
            {
                Console.WriteLine(_Player1.Name + " has fainted");
                return _Player2;
            }

            if (_Player2.HP <= 0)
            {
                Console.WriteLine(_Player2.Name + " has fainted");
                return _Player1;
            }
            return null;
    }
}