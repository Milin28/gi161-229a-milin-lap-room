using UnityEngine;

public class Dragon : Monster
{
    public override int LootReward => 30;
    public void InitlizedDragon(string name)
    {
        base.Init(name, 40, 8);
    }
    public override void Roar()
    {
        Debug.Log("Rawrrrrrr!!!!");
    }
  
    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attacks {target.Name} with Fire Breath for {AttackPower} damage!");
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
