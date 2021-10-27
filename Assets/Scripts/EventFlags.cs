using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFlags : MonoBehaviour {
    private bool knifeFlag;
    private bool scratchingFlag;
    private bool scratchingGoneFlag;
    private bool scratchSoundFlag;
    private bool vaseFlag;
    private bool vaseBreakFlag;
    private bool ashFlag;
    private bool newspaperFlag;
    private bool paintingFlag;
    private bool paintingGoneFlag;
    private bool teacherClueFlag;
    private bool dollsFlag;
    private bool wallClueFlag;
    private bool shadowFlag;

    // Start is called before the first frame update
    void Start() {
        knifeFlag = false;
        scratchingFlag = false;
        scratchingGoneFlag = false;
        scratchSoundFlag = false;
        vaseFlag = false;
        vaseBreakFlag = false;
        ashFlag = false;
        newspaperFlag = false;
        paintingFlag = false;
        paintingGoneFlag = false;
        teacherClueFlag = false;
        dollsFlag = false;
        wallClueFlag = false;
        shadowFlag = false;
    }

    public bool getSGoneFlag() 
        {
        return scratchingGoneFlag;
    }

    public void setSGoneFlag(bool state) { 
        scratchingGoneFlag = state;
    }

    public bool getPGoneFlag() {
        return paintingGoneFlag;
    }

    public void setPGoneFlag(bool state) {
        paintingGoneFlag = state;
    }

    public bool getPaintingFlag() {
        return paintingFlag;
    }

    public void setPaintingFlag(bool state) {
        paintingFlag = state;
    }
    public bool getScratchingFlag() {
        return scratchingFlag;
    } 

    public void setScratchingFlag(bool state) {
        scratchingFlag = state;
    }

    public bool getKnifeFlag() {
        return knifeFlag;
    }

    public void setKnifeFlag(bool state) {
        knifeFlag = state;
    }

    public bool getVaseFlag() {
        return vaseFlag;
    }

    public void setVaseFlag(bool state) {
        vaseFlag = state;
    }

    public bool getVaseBreakFlag (){
        return vaseBreakFlag;
    }    
    
    public void setVaseBreakFlag(bool state) {
        vaseBreakFlag = state;
    }

    public bool getAshFlag() {
        return ashFlag;
    }

    public void setAshFlag(bool state) {
        ashFlag = state;
    }

    public bool getSSoundFlag() {
        return scratchSoundFlag;
    }

    public void setSSoundFlag(bool state) {
        scratchSoundFlag = state;
    }

    public bool getNewspaperFlag() {
        return newspaperFlag;
    }

    public void setNewspaperFlag(bool state) {
        newspaperFlag = state;
    }

    public bool getTeacherClueFlag() {
        return teacherClueFlag;
    }

    public void setTeacherClueFlag(bool state) {
        teacherClueFlag = state;
    }

    public bool getDollsFlag() {
        return dollsFlag;
    }

    public void setDollsFlag(bool state) {
        dollsFlag = state;
    }

    public bool getWallClueFlag() {
        return wallClueFlag;
    }

    public void setWallClueFlag(bool state) {
        wallClueFlag = state;
    }

    public bool getShadowFlag() {
        return shadowFlag;
    }

    public void setShadowFlag(bool state) {
        shadowFlag = state;
    }
    // Update is called once per frame

}
