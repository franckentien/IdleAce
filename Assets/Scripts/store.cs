using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using UnityEngine;

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
    /// The buy store on click.
    /// </summary>
    public void BuyStoreOnClick()
    {
        this.storeCount += 1;
        Debug.Log(this.storeCount);
    }

    /// <summary>
    /// The start.
    /// Use this for initialization
    /// </summary>
    private void Start ()
    {
        this.storeCount = 0;
    }

    /// <summary>
    /// The update.
    /// Update is called once per frame
    /// </summary>
    private void Update () {
		
	}


}
