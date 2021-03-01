using UnityEngine;

public class TimeInFixedTimeStep : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(Time.inFixedTimeStep);
    }


    private void FixedUpdate()
    {
        Debug.Log(Time.inFixedTimeStep);
    }
}