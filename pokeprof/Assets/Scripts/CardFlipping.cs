using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum CardState
{
    Front,
    Back
}

public class CardFlipping : MonoBehaviour
{
    public GameObject mFront;
    public GameObject mBack;
    public float mTime = 1.5f;
    private bool isActive = false;

    public void Init()
    {
        mFront.transform.eulerAngles = new Vector3(0, 90, 0);
        mBack.transform.eulerAngles = Vector3.zero;
    }

    private void Start()
    {
        Init();
    }

    public void StartFront()
    {
        if (isActive)
            return;
        StartCoroutine(ToFront());
    }

    IEnumerator ToFront()
    {
        isActive = true;
        mBack.transform.DORotate(new Vector3(0, 90, 0), mTime);
        for (float i = mTime; i >= 0; i -= Time.deltaTime)
            yield return 0;
        mFront.transform.DORotate(new Vector3(0, 0, 0), mTime);
        isActive = false;
    }
}
