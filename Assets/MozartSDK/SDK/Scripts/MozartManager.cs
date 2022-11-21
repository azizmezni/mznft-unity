﻿namespace Mozart
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;

    /// <summary>
    /// The MozartManager is the brain of the entire Mozart system.  You should
    /// create one of these when your application starts and keep it alive for
    /// the duration of the application with DoNotDestroy.  This will happen
    /// automatically if you use the Prefab.
    /// </summary>
    public class MozartManager : MonoBehaviour
    {
        /// <summary>
        /// Singleton access for the manager, used as a convenience, not by default.
        /// By default you can extend MozartBehavior for your own classes and they will find the manager.
        /// </summary>
        public static MozartManager instance;

        /// <summary>
        /// This is a list of items loaded from the store for this app
        /// </summary>
        public List<NFTItem> storeItems;
        /// <summary>
        /// This is a list of items the user actually has in their inventory for this app
        /// </summary>
        public List<NFTItem> inventoryItems;
        /// <summary>
        /// This is the users temporary session token, it will change every time they sign in with SSO
        /// </summary>
        public string SessionToken = "";
        /// <summary>
        /// This is user data specific to this user
        /// </summary>
        public MozartUser userData = new MozartUser();
        /// <summary>
        /// This is the web services helper for making web services calls in a generic way
        /// </summary>
        public WebServices webs;

        public delegate void ON_LOGIN();
        /// <summary>
        /// This event will fire when the user logs in, there is no data passed.
        /// If you want the user object read it from MozartManager.userData.
        /// </summary>
        public ON_LOGIN onLoggedInEvent;

        public delegate void ON_INVENTORY_LOADED();
        /// <summary>
        /// This event will fire after the inventory response comes back from the server.
        /// </summary>
        public ON_INVENTORY_LOADED onInventoryLoadedEvent;

        public delegate void ON_STORE_LOADED();
        /// <summary>
        /// This event will fire after the store data is loaded from the server and populated.
        /// </summary>
        public ON_STORE_LOADED onStoreLoadedEvent;

        public delegate void ON_PURCHASE_COMPLETE();
        /// <summary>
        /// This will fire after a purchase has been successfully completed.
        /// </summary>
        public ON_PURCHASE_COMPLETE onPurchaseCompleteEvent;

        /// <summary>
        /// IsLoggedIn tells us if a user is logged in or not,
        /// can be used to control session specific ui state.
        /// </summary>
        /// <returns>Bool is user logged in</returns>
        public bool IsLoggedIn()
        {
            return SessionToken != "";
        }

        // Start is called before the first frame update
        void Start()
        {
            if (!instance) instance = this;
            UnityEngine.Object.DontDestroyOnLoad(this.gameObject);
        }

        /// <summary>
        /// Sets the session token for the user after the login is completed.
        /// The MozartSDKLoginButton has logic to automatically call this.
        /// </summary>
        /// <param name="sessionToken"></param>
        public void SetSessionToken(string sessionToken)
        {
            SessionToken = sessionToken;
            if (onLoggedInEvent != null) onLoggedInEvent.Invoke();
        }

        public void SetUserData()
        {

        }

        /// <summary>
        /// Buy a specific item from the store and give it to the user
        /// </summary>
        /// <param name="item"></param>
        public void BuyItem(NFTItem item)
        {
            //TODO: Hook up web services
            if (onPurchaseCompleteEvent != null) onPurchaseCompleteEvent();
        }

        /// <summary>
        /// Request inventory from the server for the current app
        /// </summary>
        public void LoadInventory()
        {
            //TODO: Hook up web services
            if (onInventoryLoadedEvent != null) onInventoryLoadedEvent();
        }

        /// <summary>
        /// Load the store for the current app
        /// </summary>
        public void LoadStore()
        {
            //TODO: Hook up web services
            if (onStoreLoadedEvent != null) onStoreLoadedEvent();
        }
    }

}