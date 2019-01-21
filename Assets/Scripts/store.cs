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

    /// <summary>
    /// The base store profit.
    /// </summary>
    private float baseStoreProfit;

    /// <summary>
    /// The timer.
    /// </summary>
    private float storeTimer = 4f;

    /// <summary>
    /// The current timer.
    /// </summary>
    private float currentTimer = 0;

    /// <summary>
    /// The start timer.
    /// </summary>
    private bool startTimer;

    /// <summary>
    /// The game n manager.
    /// </summary>
    public GameManager GameManager;

    /// <summary>
    /// The buy store on click.
    /// </summary>
    public void BuyStoreOnClick()
    {
        this.storeCount += 1;
        this.storeCountText.text = this.storeCount.ToString();
        this.GameManager.AddToBalance(-this.baseStoreCost);


        // if (this.baseStoreCost > this.currentBalance)
        // {
        //     return;
        // }
        // else
        // {
        //
        // }
    }

    /// <summary>
    /// The store on click.
    /// </summary>
    public void StoreOnClick()
    {
        if (!this.startTimer)
        {
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
        this.baseStoreCost = 1f;
        this.baseStoreProfit = 1f;
        this.storeCountText.text = this.storeCount.ToString();
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
                this.startTimer = false;
                this.currentTimer = 0;
                this.GameManager.AddToBalance(this.baseStoreProfit * this.storeCount);
            }
        }

        this.progressSlider.value = this.currentTimer / this.storeTimer;
    }


}
