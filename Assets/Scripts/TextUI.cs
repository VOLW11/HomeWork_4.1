using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _Health;
    [SerializeField] private TMP_Text _Speed;
    [SerializeField] private ImprovementsAbilities _ability;

    private string _textHealth = "��������: ";
    private string _textSpeed = "��������: ";

    private void Update()
    {
        _Health.text = _textHealth + _ability.Health.ToString();
        _Speed.text = _textSpeed + _ability.Speed.ToString();
    }
}
