class Weapon
{
    private int _damage;
    private int _bullets;

    public Weapon(int damage, int bullets)
    {
        if (damage < 0)
        {
            _damage = 0;
        }
        else
        {
            _damage = damage;
        }

        if (bullets < 0)
        {
            _bullets = 0;
        }
        else
        {
            _bullets = bullets;
        }
    }

    public void Fire(Player player)
    {
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
        if (damage == null)
            return;

        if(damage < 0)
        {
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
            return;

        _weapon.Fire(player);
    }
}