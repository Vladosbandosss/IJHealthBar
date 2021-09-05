using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHeal : MonoBehaviour
{
    [SerializeField] private Slider _healthbar;

    [SerializeField] private float _maxHealth;

    private float _health;
    private float _minHealth = 0;
    private float _damage = 10f;
    private float _heal = 10f;

    private float _smothing = 5;

    private void Awake()
    {  
        _health = _maxHealth;
        _healthbar.maxValue = _maxHealth;
        _healthbar.value = _health;
    }

    private void Update()
    {
        ChangeHealth();
    }

    private void TakeDamege()
    {
        GameObject.Find("Player").GetComponent<Player>().ChangeHealthInfo();

        _health -= _damage;
        
        if (_health < _minHealth)
        {
            _health = _minHealth;
        }

    }

    private void Heal()
    {
        GameObject.Find("Player").GetComponent<Player>().ChangeHealthInfo();

        _health += _heal;
       
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }

    }
   
    private void ChangeHealth()
    {

        if (_healthbar.value != _health)
        {
            _healthbar.value = Mathf.Lerp(_healthbar.value, _health, _smothing * Time.deltaTime);
           
        }

    }

}