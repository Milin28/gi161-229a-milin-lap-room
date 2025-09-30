using UnityEngine;

public class Orc : Monster
{
    public override int LootReward => 10;
    public void InitlizedOrc(string name)
    {
        base.Init(name, 40, 8);
    }
    public override void Roar()
    {
        Debug.Log("Grrrrrrr!!!!");
    }
    
    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacks {target.Name} with Heavy Slash for {AttackPower} damage!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
