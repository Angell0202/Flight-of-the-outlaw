using TMPro;
using UnityEngine;
using System.Collections;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI coinText;
    public PlayerMovement playerMovement;
    private int nextMilestone = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Coin++;
            coinText.text = "Coin: " + Coin.ToString();
            UnityEngine.Debug.Log(Coin);

            if (Coin >= nextMilestone)
            {
                StartCoroutine(MakePlayerInvisible());
                nextMilestone += 100;
            }

            StartCoroutine(DeactivateAndReactivateCoin(other.gameObject));
        }
    }

    private IEnumerator MakePlayerInvisible()
    {
        playerMovement.MakeInvisible();
        yield return new WaitForSeconds(playerMovement.invisibilityDuration);
        playerMovement.MakeVisible();
    }

    private IEnumerator DeactivateAndReactivateCoin(GameObject coin)
    {
        coin.SetActive(false);
        yield return new WaitForSeconds(5f);
        coin.SetActive(true);
    }
}
