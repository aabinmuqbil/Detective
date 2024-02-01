using Meta.WitAi.Json;
using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MetaV12 : MonoBehaviour
{
    public InputActionProperty conInput;
    public AppVoiceExperience voiceExperience;
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        voiceExperience.VoiceEvents.OnPartialResponse.AddListener(SetSaidVocie);
    }

    // Update is called once per frame
    void Update()
    {
        if (conInput.action.WasPerformedThisFrame())
        {
            Debug.Log("is working");
            Sart();
            
        }
        else if(conInput.action.WasReleasedThisFrame()){
            Stop();
    
            }
    }
    public void Sart()
    {
        voiceExperience.Activate();
    }
    public void Stop()
    {
        voiceExperience.Deactivate();
    }
    private void SetSaidVocie(WitResponseNode response)
    {
        textMeshProUGUI.text = response["intents"][0]["name"].Value.ToString();
        Instantiate(Cube);
    }
}
