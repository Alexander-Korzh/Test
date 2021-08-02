using DG.Tweening;
using System.Collections;
using UnityEngine;

public class EaseInBounceEffect : TransformEffects
{
    protected BoxCollider2D contentCollider;
    void Start()
    {
        contentCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    public IEnumerator UncliclablePunch()
    {
        contentCollider.enabled = false;
        yield return PunchPosition().WaitForCompletion();
        contentCollider.enabled = true;
    }
    public void Create()
    {
        StartCoroutine(UncliclablePunch());
    }
}
