using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncuhareket : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    Vector2 velocity;
    [SerializeField]
    float hiz = default;
    [SerializeField]
    float hizlanma = default;
    [SerializeField]
    float yavaslama = default;
    [SerializeField]
    float ziplamagucu = default;
    [SerializeField]
    int ziplamalimiti = 2;
    int ziplamasayisi;
    Joystick joystick;
    joystickbutton joystickbutton;
    bool zipliyor;
    void Start()
    {
        joystickbutton = FindObjectOfType<joystickbutton>();
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        joystick = Object.FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
       
         klavyekontrol();

     
      
       
    }
    void klavyekontrol()
        {
        float hareketinput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;
        if(hareketinput>0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketinput * hiz,hizlanma*Time.deltaTime);
            animator.SetBool("walk", true);
            scale.x=0.3f;
        }
        else if (hareketinput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketinput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("walk", true);
            scale.x = -0.3f;
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0,yavaslama * Time.deltaTime);
            animator.SetBool("walk", false);
        }
        transform.localScale = scale;
        transform.Translate(velocity * Time.deltaTime);
        if(Input.GetKeyDown("space"))
        {
            ziplamayibaslat();
        }
        if(Input.GetKeyUp("space"))
        {
            ziplamayidurdur();
        }
    }
    void joystickkontrol()
    {
        float hareketinput = joystick.Horizontal;
        Vector2 scale = transform.localScale;
        if (hareketinput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketinput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("walk", true);
            scale.x = 0.3f;
        }
        else if (hareketinput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketinput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("walk", true);
            scale.x = -0.3f;
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            animator.SetBool("walk", false);
        }
        transform.localScale = scale;
        transform.Translate(velocity * Time.deltaTime);
        if (joystickbutton.tusabasildi==true && zipliyor==false)
        {
            zipliyor = true;
            ziplamayibaslat();
        }
        if (joystickbutton.tusabasildi == false && zipliyor==true)
        {
            zipliyor = false;
            ziplamayidurdur();
        }
    }
    void ziplamayibaslat()
    {

        if(ziplamasayisi<ziplamalimiti)
        {
            FindObjectOfType<seskontrol>().ziplamases();
            rb2d.AddForce(new Vector2(0f, ziplamagucu), ForceMode2D.Impulse);
            animator.SetBool("jump", true);
            FindObjectOfType<sliderkontrol>().Sliderdeger(ziplamalimiti, ziplamasayisi);
        }
        
    }
    void ziplamayidurdur()
    {
        animator.SetBool("jump", false);
        ziplamasayisi++;
        FindObjectOfType<sliderkontrol>().Sliderdeger(ziplamalimiti, ziplamasayisi);
    }
    public void ziplamayisifirla()
    {
        ziplamasayisi = 0;
        FindObjectOfType<sliderkontrol>().Sliderdeger(ziplamalimiti, ziplamasayisi);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="olum")
        {
            FindObjectOfType<oyunkontrol>().oyunubitir();
        }
    }
    public void oyunbitti()
    {
        Destroy(gameObject);
    }
}
