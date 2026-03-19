using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;


public class CharacterSelect : MonoBehaviour
{
    public GameObject Rory;
    public GameObject locked1;
    public GameObject locked2;
    public Animator[] ToggleRight;
    public Animator[] ToggleLeft;
    public float timeStart;
    public float timeout;
    public bool hasStarted;

    void Start()
    {


    }
    

   void Update()
   {
        if (!hasStarted)
        {
            float currentTime = Time.time;
            float timeThusFar = currentTime - timeStart;
            if (timeThusFar > 2f)
            {
                hasStarted = true;
            }
        }

        if (hasStarted == true)
        {
            locked1.transform.position = new Vector2(5.92f, -1.75f);
            locked2.transform.position = new Vector2(5.92f, -1.75f);
        }
    }
   
}
 