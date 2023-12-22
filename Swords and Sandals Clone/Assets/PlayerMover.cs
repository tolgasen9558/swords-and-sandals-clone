using DG.Tweening;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    float moveDist = 1.0f;
    float moveDuration = 0.5f;

    public void WalkLeft()
    {
        transform
            .DOMoveX(transform.position.x - moveDist, moveDuration)
            .SetEase(Ease.OutSine);
    }

    public void WalkRight()
    {
        transform
            .DOMoveX(transform.position.x + moveDist, moveDuration)
            .SetEase(Ease.OutSine);
    }
}
