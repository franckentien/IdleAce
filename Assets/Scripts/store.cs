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
        this.storeCount += 1;
        this.storeCountText.text = this.storeCount.ToString();

        // Debug.Log(this.storeCount);
    }

    /// <summary>
    /// The start.
    /// Use this for initialization
    /// </summary>
    private void Start ()
    {
        this.storeCount = 1;
    }

    /// <summary>
    /// The update.
    /// Update is called once per frame
    /// </summary>
    private void Update () {
		
	}


}
