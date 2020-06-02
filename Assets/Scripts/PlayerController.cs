using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public Text fruitText;
    public Text colorText;
    public Text winText;

    private Rigidbody rb;

    private int count;

    void Start()
    {
        
        count = 0;

    }
   void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();

        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal * speed * Time.deltaTime, 0, moveVertical * speed * Time.deltaTime);
        Vector3 movement = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);
        //rb.MovePosition(transform.position + movement);
        rb.AddForce(movement);
        
    }

    void OnTriggerEnter(Collider other)
    {
    Debug.Log("OnTrigger!");

        if (other.gameObject.CompareTag("Peach"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Peach");
             SetFruitText("Peach");
            SetColorText("Orange");
           
        }
        else if (other.gameObject.CompareTag("Apple"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Apple");
            SetFruitText("Apple");
            SetColorText("Red");
            
        }
        else if (other.gameObject.CompareTag("Pear"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Pear");
            SetFruitText("Pear");
            SetColorText("Yellow");
           
        }
        else if (other.gameObject.CompareTag("Banana"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Banana");
            SetFruitText("Banana");
            SetColorText("Yellow");
            
        }
        else if (other.gameObject.CompareTag("Plum"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Plum");
            SetFruitText("Plum");
            SetColorText("Violet");
            
        }
        else if (other.gameObject.CompareTag("Oranges"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Oranges");
            SetFruitText("Oranges");
            SetColorText("Orange");
            
        }
        else if (other.gameObject.CompareTag("Grape"))
        {
            count = count + 1;
            other.gameObject.SetActive(false);
//            FindObjectOfType<AudioManager>().Play("Grape");
            SetFruitText("Grape");
            SetColorText("Violet");

        }
        else if (count == 13)
        {
            fruitText.text = "";
            colorText.text = "";
            winText.text = "You win!";

        }
        else
        {
            fruitText.text = "";
            colorText.text = "";
            winText.text = "";

        }
    }
        void SetFruitText(string fruit)
        {
            fruitText.text = "Fruit: " + fruit;
        }
        void SetColorText(string color)
        {
            colorText.text = "Color: " + color;
        }
    
}
