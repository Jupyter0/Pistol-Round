using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    private bool isOpen;
    [SerializeField]
    private GameObject door;
    protected override void Interact()
    {
        isOpen = !isOpen;
        door.GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}
