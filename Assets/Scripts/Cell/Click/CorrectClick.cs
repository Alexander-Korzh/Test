using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CorrectClick : MonoBehaviour
{
    [SerializeField]
    private LevelLogic logic;
    [SerializeField]
    private Stars stars;
    [SerializeField]
    private RestartLogic restartLogic;
    [SerializeField]
    private BounceEffect contentBounceEffect;
    private void Start()
    {
        logic = transform.root.GetComponent<LevelLogic>();
        stars = transform.root.GetComponent<Stars>();
        restartLogic = transform.root.GetComponent<RestartLogic>();
        contentBounceEffect = transform.GetChild(1).GetComponent<BounceEffect>();
    }
    public void DoActions()
    {
        StartCoroutine(DoActionsCoroutine());
        //Debug.Log("Правильно !!!!!");
    }
    protected IEnumerator DoActionsCoroutine()
    {
        stars.Push();
        contentBounceEffect.DoBounce();
        yield return new WaitUntil(() => DOTween.TotalPlayingTweens() == 0);
        CheckMaxLevel();
    }
    public void CheckMaxLevel()
    {
        if (logic.GetLevel() == LevelLogic.MaxLevel)
        {
            restartLogic.Restart(RestartLogic.DelayBeforeRestart);
        }
        else
        {
            logic.NextLevel();
        }    
    }
}
