using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineScript : MonoBehaviour
{
	[SerializeField] protected Sprite vineBoulder;
	[SerializeField] protected Sprite winter_sprite;
	[SerializeField] protected Sprite summer_sprite;
	private bool boulderCheck;
	private SpriteRenderer m_spriterenderer;
	private GameObject boulder;

	void Awake()
	{
		m_spriterenderer = this.GetComponent<SpriteRenderer>();
		boulderCheck = false;
	}
	// Start is called before the first frame update
	void Start()
	{
		SeasonChangeButtonScript.instance.OnSeasonChange.AddListener(OnSeasonChangeListener);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnSeasonChangeListener()
	{
		if (boulderCheck)
		{
			if (!LevelManagerScript.instance.isWinter)
			{
				m_spriterenderer.sprite = vineBoulder;
				Destroy(boulder);
				this.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>().enabled = false;
			}
		}
		else
		{
			if (LevelManagerScript.instance.isWinter)
			{
				m_spriterenderer.sprite = winter_sprite;
			}
			else
			{
				m_spriterenderer.sprite = summer_sprite;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Boulder"))
		{
			boulderCheck = true;
			boulder = collision.gameObject;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (m_spriterenderer.sprite != vineBoulder && collision.gameObject.CompareTag("Boulder"))
		{
			boulderCheck = false;
		}
	}
}
