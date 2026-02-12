using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ButtonController : MonoBehaviour
{
    public SpriteRenderer theSR;
    public Sprite defaultimage;
    public Sprite pressedImage;

    public Key keytopress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[keytopress].wasPressedThisFrame)
        {
            theSR.sprite = pressedImage;
        }

        if (Keyboard.current[keytopress].wasReleasedThisFrame)
        {
            theSR.sprite = defaultimage;
        }
    }
}

