using UnityEngine;

public abstract class Character : MonoBehaviour
{
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
    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }
    
    
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
    public void TakeDamage(int damageValue)
    {
        health -= damageValue;

    }
    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage !");
        target.TakeDamage(AttackPower);
    }
    public bool IsAlive() { return health > 0; }
}
