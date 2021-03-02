using UnityEngine;

[ExecuteInEditMode]
public class TimeMaximumDeltaTime : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(Time.maximumDeltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log(Time.maximumDeltaTime);
    }

    private void LateUpdate()
    {
        Debug.Log(Time.maximumDeltaTime); // late update and update function number of calling in times are equal
    }
}