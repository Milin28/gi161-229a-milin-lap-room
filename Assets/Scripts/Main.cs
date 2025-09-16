using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //private List<Monster> monsters = new<Monster>();
    public Hero hero;
    public List<Monster> monstersPrefabs; // เก็บหลายตัว

    public Monster currentMonster; //เก็บตัวเดียว
    public List<Monster> monsters = new List<Monster>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {  
        
        hero.Init("The Knight", 20, 10);
        hero.ShowStat();
        //------Dragon------
        //Spawn Monster gameobject from prefab
        currentMonster = Instantiate(monstersPrefabs[0]);

        //Initialize monster
        currentMonster.Init("Dragon", 20, 15 ,100 );
        

        //Keep track of monster
        monsters.Add(currentMonster);

        //------Orc------
        currentMonster = Instantiate(monstersPrefabs[1]);
        currentMonster.Init("Orc", 15, 10, 50);
        monsters.Add(currentMonster);

        //------Goblin------
        currentMonster = Instantiate(monstersPrefabs[2]);
        currentMonster.Init("Goblin", 10, 5, 20);
        monsters.Add(currentMonster);

        //show stsat
        foreach (var m in monsters)
        {
            m.ShowStat();
        }
















        /*
        //create Hero
        Hero hero = new Hero("The Knight", 20 , 15);

        
        Monster monster = new Monster("Orc", 20 , 5 , 15);
        Monster monster2 = new Monster("Goblin", 15, 4, 10);
        Monster monster3 = new Monster("HO", 15, 4, 10);
        Debug.Log($"Hero name: {hero.Name} | Hero Health: {hero.Health} | Hero Gold: {hero.Gold}");
        monsters.Add(monster);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Evil king",20,10,15));
        //show hero statsts
        //Debug.Log($"Hero name: {hero.Name} | Hero Health: {hero.Health} | Hero Gold: {hero.Gold}");
        hero.showStat();

        Debug.Log($"Monster name: {monster.Name} | Monster Health: {monster.Health} ");
        Debug.Log($"Monster name: {monster2.Name} | Monster Health: {monster2.Health} ");
        Debug.Log($"Monster name: {monster3.Name} | Monster Health: {monster3.Health} ");

        foreach (var m in monsters)
        {
            //Debug.Log($"Monster Name: {m.Name} | Monster Health: {m.Health}");
            m.showstat();
        }
        //Player Attack
        monster2.showstat();
        hero.Attack(monster2);
        monster2.showstat();
        // Monster attack
        hero.showStat


        hero.Name = "NARAKA";
        hero.Health = 100;
        hero.Gold = -999;
        //hero is hit
        hero.TakeDamage(monster.AttackPower);

        //
        Debug.Log($"Hero name: {hero.Name} | Hero Health: {hero.Health} | Hero Gold: {hero.Gold}");
        Debug.Log($"hero is Alive: {hero.IsAlive()}");
        */
    }


}
