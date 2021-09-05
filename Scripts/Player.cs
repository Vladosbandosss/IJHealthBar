using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]  private GameObject _panel;

    private float _currentHealth = 50;
    private float _maxHealth = 100;
    private float _minHealth =0;

    public float currentHealth => _currentHealth;
    public float maxHealth => _maxHealth;
    public float minHealth => _minHealth;


    private void Start()
    {
        _panel.SetActive(false);
    }

    public void ChangeHealthInfo()
    {
        StartCoroutine(nameof(ShowText));
    }

   private IEnumerator ShowText()
    {
        _panel.SetActive(true);

        yield return new WaitForSeconds(1f);

        _panel.SetActive(false);

        StopShowingText();
    }

    private void StopShowingText()
    {
        StopCoroutine(nameof(ShowText));
    }
}
