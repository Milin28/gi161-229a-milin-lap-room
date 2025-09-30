using UnityEngine;

public class Hero : Character
{
    //Attributes
    
    /*private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else
            { gold = value; }
        }
    }*/
    public int Gold { get; private set; }
    private int maxGold = 100;


    //Constructor to create an object
    public void Init (string newName, int newHP ,int newAttackPower)
    {
        base.Init(newName, newHP, newAttackPower);
        Gold = 0;
        

    }
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Hero Gold: {Gold}");
    }
    public void heal(int healAmount)
    {   Health = Mathf.Clamp(Health + healAmount,0, maxHealth);
        Debug.Log($"{Name} heals 20 HP!, cur {Health}");
    }

    public override void Attack(Character target)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
    }
    public override void Attack(Character target, int bonusDamage)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower + bonusDamage);
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage! with {bonusDamage} bonus damage");
    }
    public void EarnGold(int amount)
    {
        if(amount > 0)
        { 
            //Gold += amount;
            Gold = Mathf.Clamp(Gold + amount, 0, maxGold);
        }
         

        /*if (value > 999) { gold = 999; }
        else if (value <= 0) { gold = 0; }
        else
        { gold = value; }*/

    }
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
    
   
    
    
}