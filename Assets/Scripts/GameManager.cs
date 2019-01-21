using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The game manager.
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// The current balance text.
    /// </summary>
    public Text currentBalanceText;

    /// <summary>
    /// The current balance.
    /// </summary>
    private float currentBalance;


    /// <summary>
    /// The start.
    /// Use this for initialization
    /// </summary>
    private void Start()
    {
        this.currentBalance = 0f;
        this.currentBalanceText.text = this.currentBalance.ToString("C2");
    }

    /// <summary>
    /// The update.
    /// Update is called once per frame
    /// </summary>
    private void Update () {
		
	}

    /// <summary>
    /// The add to balance.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void AddToBalance(float amount)
    {
        this.currentBalance += amount;
        this.currentBalanceText.text = this.currentBalance.ToString("C2");
    }

    /// <summary>
    /// The can buy.
    /// </summary>
    /// <param name="amountToSpend">
    /// The amount To spend.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    public bool CanBuy(float amountToSpend)
    {
        return !(amountToSpend > this.currentBalance);
    }
}
