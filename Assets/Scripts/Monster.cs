using Unity.VisualScripting;
using UnityEngine;

public abstract class Monster : Character
{
    //Attributes
    public abstract int LootReward { get; }

    private bool defeated = false;
    /*
    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        }

    }
    bool defeated;
    public MonsterType monsterType;
    public void Init(MonsterType monType)
    {
        monsterType = monType;
        switch (monType)
        {
            case MonsterType.Dragon:
                Init("Dragon", 20, 15 ,100);
                lootReward = 100;
                break;
            case MonsterType.Goblin:
                Init("Goblin", 10, 5, 20);
                lootReward = 20;
                break;
            case MonsterType.Orc:
                Init("Orc", 15, 10, 50);
                lootReward = 50;
                break;
        }
    }

    //Constructor to create an object
    public void Init(string newName, int newHP, int newAttackPower, int newLootReward)
    {
        base.Init(newName, newHP, newAttackPower);
        LootReward = newLootReward;
       
    }*/
    public abstract void Roar();
    
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Monster Loot Reward: {LootReward}");
    }
    public override void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
        //Debug.Log($"{Name} Monter attacks {target.Name} for {AttackPower} damage!");
    }
    public override void Attack(Character target, int bonusDamage)
    {
        target.TakeDamage((AttackPower*2) +(bonusDamage /2));
        Debug.Log($"{Name} Monter attacks {target.Name} for {AttackPower} damage! with {bonusDamage} bonus damage");
    }
    public int DropReward()
    { 
        return LootReward;
    }
    public override void OnDefeated()
    {
        throw new System.NotImplementedException();
    }
}   