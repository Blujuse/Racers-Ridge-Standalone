using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VAG_TROPHIES : MonoBehaviour
{

    [SerializeField] GameObject[] Trophies;
    public static int ActiveTrophies;

    [SerializeField] Text ThrophyText;

    [SerializeField] GameObject VAG_Trophie;
    //[SerializeField] GameObject VAG_ArcadeTrophie;
    [SerializeField] GameObject AAS_Trophie;
    [SerializeField] GameObject AAS_ArcadeTrophie;
    [SerializeField] GameObject ATA_Trophie;
    [SerializeField] GameObject ATA_ArcadeTrophie;
    [SerializeField] GameObject CYU_Trophie;
    [SerializeField] GameObject CYU_ArcadeTrophie;
    [SerializeField] GameObject EBA_Trophie;
    [SerializeField] GameObject EBA_ArcadeTrophie;
    [SerializeField] GameObject EBD_Trophie;
    [SerializeField] GameObject EBD_ArcadeTrophie;
    [SerializeField] GameObject FMA_Trophie;
    [SerializeField] GameObject FMA_ArcadeTrophie;
    [SerializeField] GameObject HKN_Trophie;
    [SerializeField] GameObject HKN_ArcadeTrophie;
    [SerializeField] GameObject HLL_Trophie;
    [SerializeField] GameObject HLL_ArcadeTrophie;
    [SerializeField] GameObject IHA_Trophie;
    [SerializeField] GameObject IHA_ArcadeTrophie;
    [SerializeField] GameObject JBA_Trophie;
    [SerializeField] GameObject JBA_ArcadeTrophie;
    [SerializeField] GameObject JHO_Trophie;
    [SerializeField] GameObject JHO_ArcadeTrophie;
    [SerializeField] GameObject JKE_Trophie;
    [SerializeField] GameObject JKE_ArcadeTrophie;
    [SerializeField] GameObject JRO_Trophie;
    [SerializeField] GameObject JRO_ArcadeTrophie;
    [SerializeField] GameObject KCY_Trophie;
    [SerializeField] GameObject KCY_ArcadeTrophie;
    [SerializeField] GameObject LTA_Trophie;
    [SerializeField] GameObject LTA_ArcadeTrophie;
    [SerializeField] GameObject MAL_Trophie;
    [SerializeField] GameObject MAL_ArcadeTrophie;
    [SerializeField] GameObject MLI_Trophie;
    [SerializeField] GameObject MLI_ArcadeTrophie;
    [SerializeField] GameObject MLO_Trophie;
    [SerializeField] GameObject MLO_ArcadeTrophie;
    [SerializeField] GameObject MMI_Trophie;
    [SerializeField] GameObject MMI_ArcadeTrophie;
    [SerializeField] GameObject MRO_Trophie;
    [SerializeField] GameObject MRO_ArcadeTrophie;
    [SerializeField] GameObject QME_Trophie;
    [SerializeField] GameObject QME_ArcadeTrophie;
    [SerializeField] GameObject RRG_Trophie;
    [SerializeField] GameObject RRG_ArcadeTrophie;
    [SerializeField] GameObject SAN_Trophie;
    [SerializeField] GameObject SAN_ArcadeTrophie;
    [SerializeField] GameObject SAS_Trophie;
    [SerializeField] GameObject SAS_ArcadeTrophie;
    [SerializeField] GameObject SCH_Trophie;
    [SerializeField] GameObject SCH_ArcadeTrophie;
    [SerializeField] GameObject SWA_Trophie;
    [SerializeField] GameObject SWA_ArcadeTrophie;
    [SerializeField] GameObject THU_Trophie;
    [SerializeField] GameObject THU_ArcadeTrophie;
    [SerializeField] GameObject TTA_Trophie;
    [SerializeField] GameObject TTA_ArcadeTrophie;
    [SerializeField] GameObject VBR_Trophie;
    [SerializeField] GameObject VBR_ArcadeTrophie;
    [SerializeField] GameObject WHA_Trophie;
    [SerializeField] GameObject WHA_ArcadeTrophie;







    private void Awake()
    {
        // for cleaning Data
        //PlayerPrefs.DeleteAll();
        
       

        SetPlayerPrefffffssss();
        PlayerPrefs.Save();
    }


    void Start()
    {
        HandleThrophies();



        ActiveTrophies = 0;

        for (int i = 0; i < Trophies.Length; i++)
        {
            if (Trophies[i].activeInHierarchy == true)
            {
                ActiveTrophies++;

            }
        }

        
        ThrophyText.text = ActiveTrophies.ToString();
        Debug.Log("Trophies Unlocked: " + ActiveTrophies);

        if (ActiveTrophies == 30)
        {
            PlayerPrefs.SetInt("VAG_Trophie_Int", 1);
            PlayerPrefs.Save();
        }

    }


    void SetPlayerPrefffffssss()
    {
        if(PlayerPrefs.GetInt("VAG_Trophie_Int") != 1)
            PlayerPrefs.SetInt("VAG_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("AAS_Trophie_Int") != 1)
            PlayerPrefs.SetInt("AAS_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("ATA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("ATA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("CYU_Trophie_Int") != 1)
            PlayerPrefs.SetInt("CYU_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("EBA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("EBA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("EBD_Trophie_Int") != 1)
            PlayerPrefs.SetInt("EBD_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("FMA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("FMA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("HKN_Trophie_Int") != 1)
            PlayerPrefs.SetInt("HKN_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("HLL_Trophie_Int") != 1)
            PlayerPrefs.SetInt("HLL_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("IHA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("IHA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("JBA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("JBA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("JHO_Trophie_Int") != 1)
            PlayerPrefs.SetInt("JHO_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("JKE_Trophie_Int") != 1)
            PlayerPrefs.SetInt("JKE_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("JRO_Trophie_Int") != 1)
            PlayerPrefs.SetInt("JRO_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("KCY_Trophie_Int") != 1)
            PlayerPrefs.SetInt("KCY_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("LTA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("LTA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("MAL_Trophie_Int") != 1)
            PlayerPrefs.SetInt("MAL_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("MLI_Trophie_Int") != 1)
            PlayerPrefs.SetInt("MLI_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("MLO_Trophie_Int") != 1)
            PlayerPrefs.SetInt("MLO_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("MMI_Trophie_Int") != 1)
            PlayerPrefs.SetInt("MMI_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("MRO_Trophie_Int") != 1)
            PlayerPrefs.SetInt("MRO_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("QME_Trophie_Int") != 1)
            PlayerPrefs.SetInt("QME_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("RRG_Trophie_Int") != 1)
            PlayerPrefs.SetInt("RRG_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("SAN_Trophie_Int") != 1)
            PlayerPrefs.SetInt("SAN_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("SAS_Trophie_Int") != 1)
            PlayerPrefs.SetInt("SAS_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("SCH_Trophie_Int") != 1)
            PlayerPrefs.SetInt("SCH_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("SWA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("SWA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("THU_Trophie_Int") != 1)
            PlayerPrefs.SetInt("THU_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("TTA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("TTA_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("VBR_Trophie_Int") != 1)
            PlayerPrefs.SetInt("VBR_Trophie_Int", 0);
        if (PlayerPrefs.GetInt("WHA_Trophie_Int") != 1)
            PlayerPrefs.SetInt("WHA_Trophie_Int", 0);

    }

    void HandleThrophies()
    {
        if (PlayerPrefs.GetInt("VAG_Trophie_Int") == 1) 
        {
            VAG_Trophie.SetActive(true);
            //VAG_ArcadeTrophie.SetActive(true); 
        }
        else
        {
            VAG_Trophie.SetActive(false);
            //VAG_ArcadeTrophie.SetActive(false);
        }
        if (PlayerPrefs.GetInt("AAS_Trophie_Int") == 1)
        {
            AAS_Trophie.SetActive(true);
            AAS_ArcadeTrophie.SetActive(true);
        }
        else
        {
            AAS_Trophie.SetActive(false);
            AAS_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("ATA_Trophie_Int") == 1)
        {
            ATA_Trophie.SetActive(true);
            ATA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            ATA_Trophie.SetActive(false);
            ATA_ArcadeTrophie.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYU_Trophie_Int") == 1)
        {
            CYU_Trophie.SetActive(true);
            CYU_ArcadeTrophie.SetActive(true);
        }
        else
        {
            CYU_Trophie.SetActive(false);
            CYU_ArcadeTrophie.SetActive(false); 
        }
        if (PlayerPrefs.GetInt("EBA_Trophie_Int") == 1)
        {
            EBA_Trophie.SetActive(true);
            EBA_ArcadeTrophie.SetActive(true);
        }
        else
        { 
            EBA_Trophie.SetActive(false);
            EBA_ArcadeTrophie.SetActive(false);
        }
        if (PlayerPrefs.GetInt("EBD_Trophie_Int") == 1)
        {
            EBD_Trophie.SetActive(true);
            EBD_ArcadeTrophie.SetActive(true);
        }
        else
        {
            EBD_Trophie.SetActive(false);
            EBD_ArcadeTrophie.SetActive(false); 
        }
        if (PlayerPrefs.GetInt("FMA_Trophie_Int") == 1)
        {
            FMA_Trophie.SetActive(true);
            FMA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            FMA_Trophie.SetActive(false);
            FMA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("HKN_Trophie_Int") == 1)
        {
            HKN_Trophie.SetActive(true);
            HKN_ArcadeTrophie.SetActive(true);
        }
        else
        {
            HKN_Trophie.SetActive(false);
            HKN_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("HLL_Trophie_Int") == 1)
        {
            HLL_Trophie.SetActive(true);
            HLL_ArcadeTrophie.SetActive(true);
        }
        else
        { 
            HLL_Trophie.SetActive(false);
            HLL_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("IHA_Trophie_Int") == 1)
        {
            IHA_Trophie.SetActive(true);
            IHA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            IHA_Trophie.SetActive(false);
            IHA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("JBA_Trophie_Int") == 1)
        {
            JBA_Trophie.SetActive(true);
            JBA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            JBA_Trophie.SetActive(false);
            JBA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("JHO_Trophie_Int") == 1)
        {
            JHO_Trophie.SetActive(true);
            JHO_ArcadeTrophie.SetActive(true);
        }
        else
        {
            JHO_Trophie.SetActive(false);
            JHO_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("JKE_Trophie_Int") == 1)
        {
            JKE_Trophie.SetActive(true);
            JKE_ArcadeTrophie.SetActive(true);
        }
        else
        {
            JKE_Trophie.SetActive(false);
            JKE_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("JRO_Trophie_Int") == 1)
        {
            JRO_Trophie.SetActive(true);
            JRO_ArcadeTrophie.SetActive(true);
        }
        else
        {
            JRO_Trophie.SetActive(false);
            JRO_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("KCY_Trophie_Int") == 1)
        {
            KCY_Trophie.SetActive(true);
            KCY_ArcadeTrophie.SetActive(true);
        }
        else
        {
            KCY_Trophie.SetActive(false);
            KCY_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("LTA_Trophie_Int") == 1)
        {
            LTA_Trophie.SetActive(true);
            LTA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            LTA_Trophie.SetActive(false);
            LTA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("MAL_Trophie_Int") == 1)
        {
            MAL_Trophie.SetActive(true);
            MAL_ArcadeTrophie.SetActive(true);
        }
        else
        { 
            MAL_Trophie.SetActive(false);
            MAL_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("MLI_Trophie_Int") == 1)
        {
            MLI_Trophie.SetActive(true);
            MLI_ArcadeTrophie.SetActive(true);
        }
        else
        {
            MLI_Trophie.SetActive(false);
            MLI_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("MLO_Trophie_Int") == 1)
        {
            MLO_Trophie.SetActive(true);
            MLO_ArcadeTrophie.SetActive(true);
        }
        else
        {
            MLO_Trophie.SetActive(false);
            MLO_ArcadeTrophie.SetActive(false);
        }

        if (PlayerPrefs.GetInt("MMI_Trophie_Int") == 1)
        {
            MMI_Trophie.SetActive(true);
            MMI_ArcadeTrophie.SetActive(true);
        }
        else
        {
            MMI_Trophie.SetActive(false);
            MMI_ArcadeTrophie.SetActive(false);
        }

        if (PlayerPrefs.GetInt("MRO_Trophie_Int") == 1)
        {
            MRO_Trophie.SetActive(true);
            MRO_ArcadeTrophie.SetActive(true);
        }
        else
        {
            MRO_Trophie.SetActive(false);
            MRO_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("QME_Trophie_Int") == 1)
        {
            QME_Trophie.SetActive(true);
            QME_ArcadeTrophie.SetActive(true);
        }
        else
        {
            QME_Trophie.SetActive(false);
            QME_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("RRG_Trophie_Int") == 1)
        {
            RRG_Trophie.SetActive(true);
            RRG_ArcadeTrophie.SetActive(true);
        }
        else
        {
            RRG_Trophie.SetActive(false);
            RRG_ArcadeTrophie.SetActive(false);
        }

        if (PlayerPrefs.GetInt("SAN_Trophie_Int") == 1)
        {
            SAN_Trophie.SetActive(true);
            SAN_ArcadeTrophie.SetActive(true);
        }
        else
        {
            SAN_Trophie.SetActive(false);
            SAN_ArcadeTrophie.SetActive(false);
        }

        if (PlayerPrefs.GetInt("SAS_Trophie_Int") == 1)
        {
            SAS_Trophie.SetActive(true);
            SAS_ArcadeTrophie.SetActive(true);
        }
        else
        {
            SAS_Trophie.SetActive(false);
            SAS_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("SCH_Trophie_Int") == 1)
        {
            SCH_Trophie.SetActive(true);
            SCH_ArcadeTrophie.SetActive(true);
        }
        else
        {
            SCH_Trophie.SetActive(false);
            SCH_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("SWA_Trophie_Int") == 1)
        {
            SWA_Trophie.SetActive(true);
            SWA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            SWA_Trophie.SetActive(false);
            SWA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("THU_Trophie_Int") == 1)
        {
            THU_Trophie.SetActive(true);
            THU_ArcadeTrophie.SetActive(true);
        }
        else
        {
            THU_Trophie.SetActive(false);
            THU_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("TTA_Trophie_Int") == 1)
        {
            TTA_Trophie.SetActive(true);
            TTA_ArcadeTrophie.SetActive(true);
        }
        else
        {
            TTA_Trophie.SetActive(false);
            TTA_ArcadeTrophie.SetActive(false); 
        }

        if (PlayerPrefs.GetInt("VBR_Trophie_Int") == 1)
        {
            VBR_Trophie.SetActive(true);
            VBR_ArcadeTrophie.SetActive(true);
        }
        else
        {
            VBR_Trophie.SetActive(false);
            VBR_ArcadeTrophie.SetActive(false);
        }

        if (PlayerPrefs.GetInt("WHA_Trophie_Int") == 1)
        {
            WHA_Trophie.SetActive(true);
            WHA_ArcadeTrophie.SetActive(true);
        }
        else
        { 
            WHA_Trophie.SetActive(false);
            WHA_ArcadeTrophie.SetActive(false); 
        }
    }

}
