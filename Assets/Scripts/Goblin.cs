using UnityEngine;

public class Goblin : Monster
{
    public override int LootReward => 5;
    public void InitlizedGoblin(string name)
    {
        base.Init(name, 40, 8);
    }
    public override void Roar()
    {
       Debug.Log("Uuuta Uuuuuuuuuuta");
    }
    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacks {target.Name} with Quick Stab for {AttackPower} damage!");
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
