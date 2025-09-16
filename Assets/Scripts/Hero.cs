using UnityEngine;

public class Hero : Character
{
    //Attributes
    
    private int gold;
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
    }
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
    
      


    public void EarnGold(int amount)
    {
        if(amount > 0)
        { 
            Gold += amount;
        }
        
    }
    
   
    
    
}