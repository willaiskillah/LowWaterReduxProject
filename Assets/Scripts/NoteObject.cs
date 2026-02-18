using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
public class NoteObject : MonoBehaviour
{
    public bool canBePressed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            if (canBePressed)
            {
                GameObject.Find("Light Purple Block").SetActive(false);
            }
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            if (canBePressed)
            {
                GameObject.Find("Dark Purple Block").SetActive(false);
            }
        }
    }
private void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Activator")
    {
        canBePressed = true;
    }
}

private void OnTriggerExit2D(Collider2D other)
{
    if (other.tag == "Activator")
    {
        canBePressed = false;
    }
}

}