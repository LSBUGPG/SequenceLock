using System.Collections;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float scale = 1.1f;
    public float delay = 0.2f;

    public void Trigger()
    {
        StartCoroutine(PulseObjectScale());
    }

    IEnumerator PulseObjectScale()
    {
        transform.localScale = Vector3.one * scale;
        yield return new WaitForSeconds(delay);
        transform.localScale = Vector3.one;
    }
}
