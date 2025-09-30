using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string weaponName { get; private set; }
    public int BonusDamage { get; private set; }
    public void InitWeapon(string Name, int damageValue)
    {
        weaponName = Name;
        BonusDamage = damageValue;
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
