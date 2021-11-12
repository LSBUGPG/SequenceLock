using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public GameObject [] switches;
    public UnityEvent onUnlock;
    int position;

    void Start()
    {
        position = 0;
    }

    public void Input(GameObject button)
    {
        if (position < switches.Length)
        {
            if (switches[position] == button)
            {
                position++;
                if (position == switches.Length)
                {
                    onUnlock.Invoke();
                }
            }
            else
            {
                position = 0;
            }
        }
    }
}
