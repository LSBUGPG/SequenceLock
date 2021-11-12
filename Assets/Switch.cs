using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Lock lockObject;

    void OnMouseDown()
    {
        StartCoroutine(Press());
    }

    IEnumerator Press()
    {
        transform.localScale = Vector3.one * 1.1f;
        lockObject.Input(gameObject);
        yield return new WaitForSeconds(0.2f);
        transform.localScale = Vector3.one;
    }
}
