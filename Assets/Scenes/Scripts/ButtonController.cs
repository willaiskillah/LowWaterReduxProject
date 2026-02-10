using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonController : MonoBehaviour
{
    public SpriteRenderer theSR;
    public Sprite defaultimage;
    public Sprite pressedImage;

    public KeyCode keytopress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keytopress))
        {
            theSR.sprite = pressedImage;
        }

        if(Input.GetKeyUp(keytopress))
        {
            theSR.sprite = defaultimage;
        }
    }
}

