using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "CharacterCharacter Data")]
public class CharacterData : ScriptableObject
{
    public string npcName = "NPC Name";
    public int npcLevel = 1;
    public float npcHealth = 100f;
    public float npcAttackDamage = 10f;
    public float npcSpeed = 2f;

    public GameObject npcModelPrefab;
    public Material npcMaterial;
   

    [Header("Dialogues")]
    public string[] greetings;
    public string[] questDialogues;

    [Header("Quests")]
    public Dialog[] availabledDialogs;

    
}