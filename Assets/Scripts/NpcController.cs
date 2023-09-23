using UnityEngine;
using UnityEngine.UI;

public class NpcController : MonoBehaviour
{
    public Dialog CharacterDialog;
    public AudioSource audioSource; // AudioSource bileşenini buradan atanız

    private void Start()
    {
        // AudioSource bileşenini alın ve atan
        audioSource = GetComponent<AudioSource>();
    }

    public void PressButton()
    {
        if (CharacterDialog != null && CharacterDialog.npcVoice != null)
        {
            // NPC'nin sesini oynat
            audioSource.clip = CharacterDialog.npcVoice;
            audioSource.Play();
        }
    }
}