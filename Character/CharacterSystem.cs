using Godot;
using System;

public class CharacterSystem : Node
{
<<<<<<< Updated upstream
    private int _energy;
    private int _health;
    private int _damage;
    private int _speed;

    [Export] public int MaxHealth { get; set; }
    [Export] public int MinHealth { get; set; }

    [Export] public int MaxEnergy { get; set; }
    [Export] public int MinEnergy { get; set; }

    [Export] public int StartDamage { get; set; }
    [Export] public int StartSpeed { get; set; }

    public int Damage
    {
        get => _damage;
        set
        {
            var oldDamage = _damage;
            _damage = value;
            if (oldDamage != _damage) EmitSignal(nameof(DamageChanged), oldDamage, _damage);
        }
    }

    public int Speed
    {
        get => _speed;
        set
        {
            var oldSpeed = _speed;
            _speed = value;
            if (oldSpeed != _speed) EmitSignal(nameof(SpeedChanged), oldSpeed, _speed);
        }
    }

    public int Health
    {
        get => _health;
        private set
        {
            var oldHealth = _health;
            _health = Mathf.Clamp(value, MinHealth, MaxHealth);
            EmitSignal(nameof(HealthChanged), oldHealth, _health);
        }
    }

    public int Energy
    {
        get => _energy;
        private set
        {
            var oldEnergy = _energy;
            _energy = Mathf.Clamp(value, MinEnergy, MaxEnergy);
            EmitSignal(nameof(EnergyChanged), oldEnergy, _energy);
        }
    }

    [Signal] public delegate void HealthChanged(int oldHealth, int newHealth);
    [Signal] public delegate void EnergyChanged(int oldEnergy, int newEnergy);
    [Signal] public delegate void DamageChanged(int oldDamage, int newDamage);
    [Signal] public delegate void SpeedChanged(int oldSpeed, int newSpeed);

    public override void _Ready()
    {
        Health = MaxHealth;
        Energy = MaxEnergy;
        Damage = StartDamage;
        Speed = StartSpeed;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void RestoreHealth(int health)
    {
        Health += health;
    }

    public void UseEnergy(int energy)
    {
        Energy -= energy;
    }

    public void RestoreEnergy(int energy)
    {
        Energy += energy;
    }

    public void ResetHealth()
    {
        Health = MaxHealth;
    }

    public void ResetEnergy()
    {
        Energy = MaxEnergy;
    }

    public void Reset()
    {
        ResetHealth();
        ResetEnergy();
    }
=======
	private int _energy;
	private int _health;
	private int _damage;
	private int _speed;

	[Export] public int MaxHealth { get; set; }
	[Export] public int MinHealth { get; set; }

	[Export] public int MaxEnergy { get; set; }
	[Export] public int MinEnergy { get; set; }

	[Export] public int StartDamage { get; set; }
	[Export] public int StartSpeed { get; set; }

	public int Damage
	{
		get => _damage;
		set
		{
			var oldDamage = _damage;
			_damage = value;
			if (oldDamage != _damage) EmitSignal(nameof(DamageChanged), oldDamage, _damage);
		}
	}

	public int Speed
	{
		get => _speed;
		set
		{
			var oldSpeed = _speed;
			_speed = value;
			if (oldSpeed != _speed) EmitSignal(nameof(SpeedChanged), oldSpeed, _speed);
		}
	}

	public int Health
	{
		get => _health;
		private set
		{
			var oldHealth = _health;
			_health = Mathf.Clamp(value, MinHealth, MaxHealth);
			EmitSignal(nameof(HealthChanged), oldHealth, _health);
		}
	}
	public int Energy
	{
		get => _energy;
		private set
		{
			var oldEnergy = _energy;
			_energy = Mathf.Clamp(value, MinEnergy, MaxEnergy);
			EmitSignal(nameof(EnergyChanged), oldEnergy, _energy);
		}
	}

	[Signal] public delegate void HealthChanged(int oldHealth, int newHealth);
	[Signal] public delegate void EnergyChanged(int oldEnergy, int newEnergy);
	[Signal] public delegate void DamageChanged(int oldDamage, int newDamage);
	[Signal] public delegate void SpeedChanged(int oldSpeed, int newSpeed);

	public override void _Ready()
	{
		Health = MaxHealth;
		Energy = MaxEnergy;
		Damage = StartDamage;
		Speed = StartSpeed;
	}

	public void TakeDamage(int damage)
	{
		Health -= damage;
	}

	public void RestoreHealth(int health)
	{
		Health += health;
	}

	public void UseEnergy(int energy)
	{
		Energy -= energy;
	}

	public void RestoreEnergy(int energy)
	{
		Energy += energy;
	}

	public void ResetHealth()
	{
		Health = MaxHealth;
	}

	public void ResetEnergy()
	{
		Energy = MaxEnergy;
	}

	public void Reset()
	{
		ResetHealth();
		ResetEnergy();
	}
>>>>>>> Stashed changes
}
