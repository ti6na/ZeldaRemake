using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiAssistant : MonoBehaviour
{
    private Text dialogueText;
    private Text dialogueText2;
    private AudioSource talkingAudioSource;
    
    private void Awake()
    {
        talkingAudioSource = transform.Find("talkingSound").GetComponent<AudioSource>();
        
        dialogueText = transform.Find("dialogue").Find("dialogueText").GetComponent<Text>();
        dialogueText2 = transform.Find("dialogue2").Find("dialogueText2").GetComponent<Text>();
        Application.targetFrameRate = 3;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        TextWriter.AddWriter_Static(dialogueText, "it's dangerous to go alone! take this.", 0.1f, true);
        TextWriter.AddWriter_Static(dialogueText2, "it's a secret to everybody.", 0.1f, true);
    }

    /*public void Dialogue1()
    {
        TextWriter.AddWriter_Static(dialogueText, "it's dangerous to go alone! take this.", 0.1f, true);
    }

    public void Dialogue2()
    {
        TextWriter.AddWriter_Static(dialogueText2, "it's a secret to everybody.", 0.1f, true);
    }*/
}
