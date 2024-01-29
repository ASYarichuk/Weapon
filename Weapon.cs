class Weapon
{
    private int _damage;
    private int _bullets;

    public Weapon(int damage, int bullets)
    {
        _damage = damage;

        if (_damage < 0)
        {
            _damage = 0;
        }

        _bullets = bullets;

        if (_bullets < 0)
        {
            _bullets = 0;
        }
    }

    public void Fire(Player player)
    {
        if(player == null)
        {
            Console.WriteLine("Нет цели для стрельбы");
        }

        player.TakeDamage(_damage);
        _bullets -= 1;
    }
}

class Player
{
    private int _health;

    public Player(int health)
    {
        if (health < 0)
        {
            _health = 0;
        }
        else
        {
            _health = health;
        }
    }

    public void TakeDamage(int damage)
    {
        if(damage < 0)
        {
            Console.WriteLine("Отрицательный урон");
            return;
        }
        else
        {
            _health -= damage;
        }
    }
}

class Bot
{
    private Weapon _weapon = new Weapon(5, 15);

    private void OnSeePlayer(Player player)
    {
        if(player == null)
        {
            Console.WriteLine("Нет видимых целей");
            return;
        }

        _weapon.Fire(player);
    }
}