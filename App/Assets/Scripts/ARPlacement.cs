﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class ARPlacement : MonoBehaviour
{

    public GameObject[] arObjectsToSpawn;
    public GameObject placementIndicator;
    public GameObject button;
    public GameObject instructions;
    public GameObject arrowDown;
    public GameObject details;

    private GameObject spawnedObject;
    private Pose PlacementPose;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;

    void Start()
    {
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
        arObjectsToSpawn = Resources.LoadAll<GameObject>("Prefabs");
    }

    // need to update placement indicator, placement pose and spawn 
    void Update()
    {
        if(spawnedObject == null && placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject();
        }

        UpdatePlacementPose();
        UpdatePlacementIndicator();

    }
    void UpdatePlacementIndicator()
    {
        if(spawnedObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if(placementPoseIsValid)
        {
            PlacementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            PlacementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }

    void ARPlaceObject()
    {
        var arObjectToSpawn = getObject();
        spawnedObject = Instantiate(arObjectToSpawn, PlacementPose.position, PlacementPose.rotation);
        instructions.SetActive(false);
        button.SetActive(true);
        details.SetActive(true); //PlayerPrefs.GetString("statue");
        arrowDown.SetActive(true);
    }

    GameObject getObject()
    {
        Debug.Log(PlayerPrefs.GetString("statue"));

        if (PlayerPrefs.GetString("statue") == "Evridika")
        {
            return arObjectsToSpawn[0];
        }
        else if (PlayerPrefs.GetString("statue") == "Plant")
        {
            return arObjectsToSpawn[1];
        }
        else
        {
            return null;
        }
    }
}


