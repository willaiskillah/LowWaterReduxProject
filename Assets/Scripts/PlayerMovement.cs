using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer Rory;
    public Sprite defaultimage;
    public Sprite pressedImage;

    public Key keytopress;
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
            Rory.sprite = pressedImage;
        }

        if (Keyboard.current.rightArrowKey.wasReleasedThisFrame)
        {
            Rory.sprite = defaultimage;
        }
    }

}
