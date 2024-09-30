using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI : MonoBehaviour
{
    [SerializeField] private TextMeshPro _Health;
    [SerializeField] private TextMeshPro _Speed;
    [SerializeField] private ImprovementsAbilities _ability;

    private string _textHealth = "Здоровье: ";
    private string _textSpeed = "Скорость: ";

    private void Update()
    {
        _Health.text = _textHealth + _ability.Health;
        _Speed.text = _textSpeed + _ability.Speed;
    }
}
