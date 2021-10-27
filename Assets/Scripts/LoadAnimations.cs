using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class loadAnimations : MonoBehaviour
{
    [SerializeField]
    private GameObject planeA;

    [SerializeField]
    private GameObject eventFlagHolder;

    [SerializeField]
    private GameObject paintingPrefab;

    [SerializeField]
    private GameObject knifePrefab;

    private GameObject spawnedKnife;

    [SerializeField]
    private GameObject planeB;

    [SerializeField]
    private GameObject planeC;

    [SerializeField]
    private GameObject vasePrefab;

    [SerializeField]
    private GameObject vaseBreakPrefab;

    [SerializeField]
    private GameObject scratchPrefab;

    private GameObject spawnedScratch;

    [SerializeField]
    private GameObject ashPrefab;

    private GameObject spawnedVase, spawnedVaseBreak, spawnedAsh;

    private GameObject spawnedPainting, spawnedScratches, paintingSource;

    [SerializeField]
    private ARPlaneManager aRPlaneManager;

    private bool hasSpawned;
    private bool hasDespawned;
    private bool scratchSpawn, knifeSpawn, vaseBreakSpawn, ashSpawn, readyforKnife;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
