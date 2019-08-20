using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class ads_Manager : MonoBehaviour
{
    public static ads_Manager instance;

    private string store_id = "3250535";
    private string video_ad = "video";
    private string rewarded_video_ad = "rewardedvideo";
    private string banner_ad = "bannerAd";
    /*
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(store_id, true);    
    }

    public void videoAds()
    {
        if(Monetization.IsReady(video_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;
            if(ad!= null)
            {
                ad.Show();
            }
        }
    }

    public void rewardedVideos()
    {
        if (Monetization.IsReady(rewarded_video_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;
            if (ad != null)
            {
                ad.Show();
            }
        }
    }
}
