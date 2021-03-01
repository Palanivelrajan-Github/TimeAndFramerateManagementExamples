using UnityEngine;

public class TimeFixedUnscaledTime : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(Time.fixedUnscaledTime);
    }
    
}