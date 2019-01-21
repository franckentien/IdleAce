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

    /// <summary>
    /// The current balance text.
    /// </summary>
    public Text currentBalanceText;

    /// <summary>
    /// The progress slider.
    /// </summary>
    public Slider progressSlider;

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

    private float baseStoreProfit;

    /// <summary>
    /// The timer.
    /// </summary>
    private float storeTimer = 4f;

    /// <summary>
    /// The current timer.
    /// </summary>
    private float currentTimer = 0;

    private bool startTimer;

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
            this.currentBalanceText.text = this.currentBalance.ToString("C2");
        }

    }

    /// <summary>
    /// The store on click.
    /// </summary>
    public void StoreOnClick()
    {
        if (!this.startTimer)
        {
            Debug.Log("Start timer");
            this.startTimer = true;
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
        this.baseStoreProfit = 1f;
        this.storeCountText.text = this.storeCount.ToString();
        this.currentBalanceText.text = this.currentBalance.ToString("C2");
        this.startTimer = false;
    }

    /// <summary>
    /// The update.
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
        if (this.startTimer)
        {
            this.currentTimer += Time.deltaTime;

            if (this.currentTimer > this.storeTimer)
            {
                Debug.Log("End of Timer");
                this.startTimer = false;
                this.currentTimer = 0;
                this.currentBalance += this.baseStoreProfit * this.storeCount;
                this.currentBalanceText.text = this.currentBalance.ToString("C2");
            }
        }

        this.progressSlider.value = this.currentTimer / this.storeTimer;
    }


}
