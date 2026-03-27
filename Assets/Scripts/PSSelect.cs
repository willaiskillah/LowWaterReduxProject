using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Animations;   
public class PSSelect : MonoBehaviour
{
    public GameObject Rory;
    public GameObject Locked1;
    public GameObject Locked2;
    private GameObject Selected;
    private Vector2 PosFL;
    private Vector2 PosL;
    private Vector2 PosC;
    private Vector2 PosR;
    private Vector2 PosFR;
    public bool hasStarted;
    public float timestart;
    public AnimationClip FlyingRory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rory.GetComponent<Animator>().Play("FlyingRory");

        if (hasStarted)
        {

            timestart = Time.time;
            float currentTime = Time.time;
            float timethusfar = currentTime - timestart;
            if (timethusfar > FlyingRory.length)
            {
                hasStarted = true;
            }
         }
            Vector2 PosFL = new Vector2 (-2.5f, 0);
            Vector2 PosL = new Vector2 (-5.09f, -1.05f);
            Vector2 PosC = new Vector2 (0, -0.53f);
            Vector2 PosR = new Vector2 (5.09f, -1.05f);
            Vector2 PosFR = new Vector2 (2.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (hasStarted == true)
        {
           Locked2.transform.position = PosL;
           Locked1.transform.position = PosR;
           Rory.transform.position = PosC;
        }
    }
}