using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] List<GameObject> glossinessBodyWorkParts = new List<GameObject>();
    [SerializeField] List<GameObject> colouredBodyWorkParts = new List<GameObject>();
 
    [SerializeField] Slider glossinessSlider;

    [SerializeField] RectTransform texture;
    [SerializeField] Texture2D rgbSprite;
    private void Start()
    {
        if(glossinessBodyWorkParts != null)
            glossinessSlider.value = glossinessBodyWorkParts[0].GetComponent<MeshRenderer>().material.GetFloat("_Smoothness");
    }

    public void OnClickPickerColor() 
    {
        if(colouredBodyWorkParts != null)
            SetColor();
    }

    void SetColor() 
    {
        Vector3 imagePos = texture.position;
        float globalPosX = Input.mousePosition.x - imagePos.x;
        float globalPosY = Input.mousePosition.y - imagePos.y;

        int localPosX = (int)(globalPosX * (rgbSprite.width / texture.rect.width));
        int localPosY = (int)(globalPosY * (rgbSprite.height / texture.rect.height));

        Color c = rgbSprite.GetPixel(localPosX, localPosY);
        SetActualColor(c);
    }

    void SetActualColor(Color c)
    {
        foreach (GameObject bodyPart in colouredBodyWorkParts)
        {
            bodyPart.GetComponent<MeshRenderer>().material.color = c;
        }
    }

    public void SetGlossiness()
    {
        if (glossinessBodyWorkParts != null)
            foreach (GameObject bodyPart in glossinessBodyWorkParts)
            {
                bodyPart.GetComponent<MeshRenderer>().material.SetFloat("_Smoothness", glossinessSlider.value);
            }
    }
}
