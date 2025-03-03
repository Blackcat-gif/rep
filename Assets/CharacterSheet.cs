using UnityEngine;

public class character : MonoBehaviour
{
    [SerializeField] string characterName = "Tav";
    [SerializeField] int proficiency = 0;
    [SerializeField] bool usingFinesseWeapon;
    [SerializeField] [Range (-5, 5)] int strengthModifier = 0;
    [SerializeField] [Range (-5, 5)] int dexterityModifier = 0;

    private int hitModifier = 0;
    private int enemyArmorClass = 0;
    private int attackRoll = 0;
    private int diceRoll = 1;
    
    void Start()
    {
        if (usingFinesseWeapon)
        {
            if (strengthModifier > dexterityModifier)
            {
                hitModifier = strengthModifier + proficiency;
            }

            else hitModifier = dexterityModifier + proficiency;
        }

        else hitModifier = strengthModifier + proficiency;

        if (hitModifier > 0)
        {
            Debug.Log(characterName + "'s Hit Modifier: +" + hitModifier);
        }
        else Debug.Log(characterName + "'s Hit Modifier: " + hitModifier);


        enemyArmorClass = Random.Range(10, 21);

        Debug.Log("Enemy Armor Class: " + enemyArmorClass);

        diceRoll = Random.Range(1, 21);

        Debug.Log(characterName + " rolled a " + diceRoll);

        attackRoll = diceRoll + hitModifier;

        if (attackRoll >= enemyArmorClass)
        {
            Debug.Log(characterName + " successfully landed a hit!");
        }
        else Debug.Log(characterName + " missed!");       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
