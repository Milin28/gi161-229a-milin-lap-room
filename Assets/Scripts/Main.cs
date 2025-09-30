using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //private List<Monster> monsters = new<Monster>();
    public Hero hero;
    public List<Monster> monstersPrefabs; // เก็บหลายตัว
    public List<Weapon> weaponsPrefabs;

    public Monster currentMonster; //เก็บตัวเดียว
    public List<Monster> monsters = new List<Monster>();
    public List<Weapon> weapons = new List<Weapon>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        Weapon Sword = Instantiate(weaponsPrefabs[0], new Vector3(-3,-1,0), Quaternion.identity);
        Weapon dagger = Instantiate(weaponsPrefabs[1], new Vector3(-3, -2, 0), Quaternion.identity);
        Weapon Claws = Instantiate(weaponsPrefabs[2], new Vector3(-3, -3, 0), Quaternion.identity);
        Weapon axe = Instantiate(weaponsPrefabs[3], new Vector3(-3, -4, 0), Quaternion.identity);

        Sword.InitWeapon("Sword", 5);
        dagger.InitWeapon("Dagger", 3);
        Claws.InitWeapon("Claws", 4);
        axe.InitWeapon("Axe", 6);




        hero.Init("The Knight", 20, 10);
        hero.ShowStat();


        /*
        SpawnMonter(MonsterType.Dragon);
        SpawnMonter(MonsterType.Goblin);
        SpawnMonter(MonsterType.Orc);
        */

        Monster dragonObj = Instantiate(monstersPrefabs[0]);
        Dragon dragon1 = dragonObj.GetComponent<Dragon>();
        if (dragon1 != null)
        {
            dragon1.InitlizedDragon("Gorash Dragon");
        }
        monsters.Add(dragonObj);

        Monster goblinObj = Instantiate(monstersPrefabs[1]);
        Goblin goblin1 = goblinObj.GetComponent<Goblin>();
        if (goblin1 != null)
        {
            goblin1.InitlizedGoblin("Smolderfang Goblin");
        }
        monsters.Add(goblinObj);
        Monster orcObj = Instantiate(monstersPrefabs[2]);
        Orc orc1 = orcObj.GetComponent<Orc>();
        if (orc1 != null)
        {
            orc1.InitlizedOrc("Org Orc");
        }



        //show stsat
        foreach (var m in monsters)
        {
            m.ShowStat();
            m.Roar();
        }
        Debug.Log("----- The Battle Begin -----");
        currentMonster = monsters[0];
        hero.Attack(currentMonster, 10);
        currentMonster.ShowStat();
        currentMonster.Attack(hero);

        currentMonster.Attack(currentMonster, 5);
        //monster defeated- hero earn  loot golds
        Debug.Log($"Monster {currentMonster.Name} is defeated!");
        hero.EarnGold(currentMonster.DropReward());
        hero.ShowStat();

        Debug.Log("----- Battle with Weapon -----");
        hero.EquipWeapon(Sword);
        goblin1.EquipWeapon(dagger);
        dragon1.EquipWeapon(Claws);
        orc1.EquipWeapon(axe);

        hero.Attack(goblin1, hero.EquippedWeapon);
        foreach (Monster mon in monsters)
        { 
            mon.Attack(hero, mon.EquippedWeapon);
        }
        /*
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
        Debug.Log("----- The Battle Begin -----");
        currentMonster = monsters[0];
        hero.Attack(currentMonster ,10);
        currentMonster.ShowStat();
        currentMonster.Attack(hero);

        currentMonster.Attack(currentMonster, 5);
        //monster defeated- hero earn  loot golds
        Debug.Log($"Monster {currentMonster.Name} is defeated!");
        hero.EarnGold(currentMonster.DropReward());
        hero.ShowStat();





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

    /*public void SpawnMonter(MonsterType monsterType)
    {
        Monster monterPrefab = monstersPrefabs[(int)monsterType];
        Monster monster = Instantiate(monterPrefab);
        monster.Init(monsterType);
        monsters.Add(monster);

    }*/
}