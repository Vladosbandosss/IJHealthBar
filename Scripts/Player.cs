using System.Collections;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]  private GameObject _panel;
   
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
