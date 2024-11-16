using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Lab : Building
{

    public static bool wasLabCreated = false;
    public static int buildLevel = 0;
    public Lab()
    {
        // �zelliklerin ba�lang�� de�erlerini atama
        buildingName = "Lab";
        buildingType = BuildingType.Research;
        health = 100;
        buildGoldCost = 1;
        buildFoodCost = 1;
        buildIronCost = 1;
        buildStoneCost = 1;
        buildTimberCost = 1;
        buildTime = 10f;
    }



    public override void UpdateCosts()
    {
        // Bina seviyesine g�re maliyet g�ncelleme
        if (buildLevel == 1)
        {
            buildGoldCost = 1000;
        }
        else if (buildLevel == 2)
        {
            buildGoldCost = 2500;
        }
    }
}