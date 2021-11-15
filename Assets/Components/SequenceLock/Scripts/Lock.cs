using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public Switch [] switches;
    public UnityEvent onUnlock;
    int position;

    void Start()
    {
        position = 0;
    }

    public void Input(Switch button)
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
