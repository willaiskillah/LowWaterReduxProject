using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer Rory;
    public Sprite defaultimage;
    public Sprite left;
    public Sprite right;
    public Sprite defaultimage2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rory = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            Rory.sprite = right;
            Rory.transform.position = new Vector3 (Rory.transform.position.x + .2f, Rory.transform.position.y);
        }
    
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            Rory.sprite = left;
            Rory.transform.position = new Vector3 (Rory.transform.position.x - .2f, Rory.transform.position.y);
        }

        if (Keyboard.current.rightArrowKey.wasReleasedThisFrame)
        {
            Rory.sprite = defaultimage;
            Rory.transform.position = new Vector3 (Rory.transform.position.x + -.2f, Rory.transform.position.y);
        }

        if (Keyboard.current.leftArrowKey.wasReleasedThisFrame)
        {
            Rory.sprite = defaultimage2;
            Rory.transform.position = new Vector3 (Rory.transform.position.x - -.2f, Rory.transform.position.y);
        }
    }

}
