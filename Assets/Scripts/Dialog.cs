using UnityEngine;

[CreateAssetMenu(fileName = "DialogData", menuName = "Dialog/Dialog Data")]
public class Dialog : ScriptableObject
{
    public string dialogName = "Dialog Name";
    public string dialogDescription = "Dialog Description";
    
    public AudioClip npcVoice;
    
    // Quest hedefleri ve diğer özel ayarlar burada tanımlanabilir.
}