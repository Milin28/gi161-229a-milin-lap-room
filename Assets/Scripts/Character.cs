using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public Weapon EquippedWeapon { get; private set; }
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Hero"; }
            else name = value;
        }
    }
    public int Health { get; protected private set; }
    protected private int maxHealth = 100;
    /*
    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }*/


    //Constructor to create an object
    public void Init(string newName, int newHP, int newAttackPower)
    {
        Name = newName;
        Health = newHP;
        AttackPower = newAttackPower;
       
    }
    //
    public int AttackPower { get; set; }

    

    
    //Methoods
    public virtual void ShowStat()
    {
        Debug.Log($"Character name: {Name} | Character Health: {Health} | Character AttackPower: {AttackPower}");

    }
    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
        
    }
    public void TakeDamage(int damageValue)
    {
        //Health -= damageValue;
        //วิธีที่ 1
        //if (Health < 0) Health = 0;//check min
        //else if (Health > maxHealth) Health = maxHealth;///check max
        //วิธีที่ 2
        Mathf.Clamp(Health - damageValue , 0, maxHealth);
        Debug.Log($"{Name} takes {damageValue} damage !, cur {Health}");
    }
    public abstract void Attack(Character target);
    public abstract void Attack(Character target, int bonusDamage);
    public virtual void Attack(Character target, Weapon weapon)
    {
        if (weapon != null)
        {
            int damage = AttackPower + weapon.BonusDamage;
            target.TakeDamage(damage);
            Debug.Log($"{Name} uses a {weapon.weaponName} with Bonus{weapon.BonusDamage}" + $"-> deals total {damage} ");

        }
    }
   
    public abstract void OnDefeated();

    /*public virtual void Attack(Character target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage !");
        target.TakeDamage(AttackPower);
    }*/
    public bool IsAlive() { return Health > 0; }
}
