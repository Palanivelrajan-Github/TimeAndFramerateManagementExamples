using UnityEngine;

public class TimeFrameCount : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    private float _secTimer;
    void Update()
    {
        _secTimer += Time.deltaTime;
        if (_secTimer > 1.0f)
        {
            Debug.Log(Time.frameCount);
            _secTimer = 0.0f;
        }
    }
}
