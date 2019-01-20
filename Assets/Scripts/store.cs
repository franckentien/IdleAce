using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// The store.
/// </summary>
public class Store : MonoBehaviour
{
    /// <summary>
    /// The current balance.
    /// </summary>
    private float currentBalance;

    public Text CurrentBalanceText;

    /// <summary>
    /// The store cost.
    /// </summary>
    private float baseStoreCost;

    /// <summary>
    /// The store count.
    /// </summary>
    private int storeCount;

    /// <summary>
    /// The store count text.
    /// </summary>
    public Text storeCountText;

    /// <summary>
    /// The buy store on click.
    /// </summary>
    public void BuyStoreOnClick()
    {

        if (this.baseStoreCost > this.currentBalance)
        {
            return;
        }
        else
        {
            this.storeCount += 1;
            this.storeCountText.text = this.storeCount.ToString();
            this.currentBalance -= this.baseStoreCost;
            this.CurrentBalanceText.text = this.currentBalance.ToString("C2");
        }



    }

    /// <summary>
    /// The start.
    /// Use this for initialization
    /// </summary>
    private void Start ()
    {
        this.storeCount = 1;
        this.currentBalance = 0f;
        this.baseStoreCost = 1f;
        this.storeCountText.text = this.storeCount.ToString();
        this.CurrentBalanceText.text = this.currentBalance.ToString("C2");
    }

    /// <summary>
    /// The update.
    /// Update is called once per frame
    /// </summary>
    private void Update () {
		
	}


}
