using UnityEngine;

public class TimeMaximumParticleDeltaTime : MonoBehaviour
{
    private void OnParticleUpdateJobScheduled()
    {
        Debug.Log(Time.maximumParticleDeltaTime);
    }
}