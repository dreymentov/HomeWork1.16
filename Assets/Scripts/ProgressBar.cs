using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishPlatforme;
    public Slider Slider;

    private float _startY;
    private float _minimumReachedY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minimumReachedY = Mathf.Min(_minimumReachedY, Player.transform.position.y);
        float finishY = FinishPlatforme.position.y;
        float t = Mathf.InverseLerp(_startY, finishY, _minimumReachedY);
        Slider.value = t;
    }
}
