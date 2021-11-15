using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public UnityEvent onClickEffect;
    public UnityEvent<Switch> onPress;

    void OnMouseDown()
    {
        onClickEffect.Invoke();
        onPress.Invoke(this);
    }
}
