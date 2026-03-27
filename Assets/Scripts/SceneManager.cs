using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class SceneManager : MonoBehaviour
{
    public GameObject transition;

    public void Update()
    {

     if (Keyboard.current.anyKey.wasPressedThisFrame){
        Button button = transition.GetComponent<Button>();
        button.onClick.Invoke();
     }
    }
}