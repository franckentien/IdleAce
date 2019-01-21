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
    /// The store cost.
    /// </summary>
    public float baseStoreCost;

    /// <summary>
    /// The base store profit.
    /// </summary>
    public float baseStoreProfit;

    /// <summary>
    /// The timer.
    /// </summary>
    public float storeTimer = 4f;

    /// <summary>
    /// The store count.
    /// </summary>
    public int storeCount;

    /// <summary>
    /// The progress slider.
    /// </summary>
    public Slider progressSlider;




    /// <summary>
    /// The store count text.
    /// </summary>
    public Text storeCountText;





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
        if (!this.GameManager.CanBuy(this.baseStoreCost))
        {
            return;
        }
        else
        {
            this.storeCount += 1;
            this.storeCountText.text = this.storeCount.ToString();
            this.GameManager.AddToBalance(-this.baseStoreCost);
        }
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
