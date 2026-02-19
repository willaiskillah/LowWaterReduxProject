using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public float timestart;
    public float timeout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            float currentTime = Time.time;
            float timethusfar = currentTime - timestart;
            if (timethusfar > 0.001f)
            //if(Keyboard.current.anyKey.wasPressedThisFrame)
            {
                hasStarted = true;
            }
        } else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
