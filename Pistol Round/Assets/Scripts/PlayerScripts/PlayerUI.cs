using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI prompt;
    
    public void UpdateText(string promptMessage)
    {
        prompt.text = promptMessage;
    }
}
