using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jogoDaVelha : MonoBehaviour
{
	
	public Button[] botoes = new Button[9];
	public Text msg;
	private  int vezJogador;
	public Sprite imgX;
	public Sprite imgO;
	public Sprite padrao;
	private int jogadas;
	
	
	public void cliqueBotao(int botaoVez){
		
		if (vezJogador == 1){
			if (botoes[botaoVez].enabled == true){
				
				botoes[botaoVez].image.sprite = imgX;
				botoes[botaoVez].enabled = false;
				jogadas = jogadas + 1;
				vezJogador = 2;
				msg.text = "Vez do Jogador 2";
				
			}
		} 
		else{
			if (botoes[botaoVez].enabled == true){
				
				botoes[botaoVez].image.sprite = imgO;
				botoes[botaoVez].enabled = false;
				jogadas = jogadas + 1;
				vezJogador = 1;
				msg.text = "Vez do Jogador 1";
			}
		}
	}
	
	public void iniciarJogo()
	{
		//todas as cartas recebem a imagem inicial e são habilitados
		for (int i = 0; i < 9; i++)
		{
			botoes[i].enabled = true;
			botoes[i].image.sprite = padrao;
			jogadas = 0;
		}

	}

	private bool FimJogo(){
		
		bool finalizou = false;
		
			
		if( (botoes[0].enabled == false) && (botoes[1].enabled == false) && (botoes[2].enabled == false) ){
			if( (botoes[0].image.sprite == botoes[1].image.sprite) && (botoes[1].image.sprite == botoes[2].image.sprite) ){
				finalizou = true;
			}
		} 
		else{
			
			if( (botoes[3].enabled == false) && (botoes[4].enabled == false) && (botoes[5].enabled == false) ){
			if( (botoes[3].image.sprite == botoes[4].image.sprite) && (botoes[4].image.sprite == botoes[5].image.sprite) ){
				finalizou = true;
			}
		  } 
			else{
			
			if( (botoes[6].enabled == false) && (botoes[7].enabled == false) && (botoes[8].enabled == false) ){
			if( (botoes[6].image.sprite == botoes[7].image.sprite) && (botoes[7].image.sprite == botoes[8].image.sprite) ){
				finalizou = true;
			}
		  } 

			
			if( (botoes[0].enabled == false) && (botoes[3].enabled == false) && (botoes[6].enabled == false) ){
			if( (botoes[0].image.sprite == botoes[3].image.sprite) && (botoes[3].image.sprite == botoes[6].image.sprite) ){
				finalizou = true;
			}
		  } 
			else{
			
			if( (botoes[1].enabled == false) && (botoes[4].enabled == false) && (botoes[7].enabled == false) ){
			if( (botoes[1].image.sprite == botoes[4].image.sprite) && (botoes[4].image.sprite == botoes[7].image.sprite) ){
				finalizou = true;
			}
		  } 
			else{
			
			if( (botoes[2].enabled == false) && (botoes[5].enabled == false) && (botoes[8].enabled == false) ){
			if( (botoes[2].image.sprite == botoes[5].image.sprite) && (botoes[5].image.sprite == botoes[8].image.sprite) ){
				finalizou = true;
			}
		  }

			if( (botoes[0].enabled == false) && (botoes[4].enabled == false) && (botoes[8].enabled == false) ){
			if( (botoes[0].image.sprite == botoes[4].image.sprite) && (botoes[4].image.sprite == botoes[8].image.sprite) ){
				finalizou = true;
			}
		  } 
			else{
			
			if( (botoes[2].enabled == false) && (botoes[4].enabled == false) && (botoes[6].enabled == false) ){
			if( (botoes[2].image.sprite == botoes[4].image.sprite) && (botoes[4].image.sprite == botoes[6].image.sprite) ){
				finalizou = true;
			}
		  } 
			
		}
		}
		}
		}
		}


				return finalizou;
	}

	
	
    // Start is called before the first frame update
    void Start()
    {
        vezJogador = 1;
		jogadas = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (FimJogo() == true)
		{
		  botoes[0].enabled = false;
		  botoes[1].enabled = false;
		  botoes[2].enabled = false;
		  botoes[3].enabled = false;
		  botoes[4].enabled = false;
		  botoes[5].enabled = false;
		  botoes[6].enabled = false;
		  botoes[7].enabled = false;
		  botoes[8].enabled = false;
		  		
				if (vezJogador == 1)
				{
				msg.text = "Vencedor é o Jogador 2";
				}
				else
				{
				msg.text = "Vencedor é o Jogador 1";
				}
		} 

		if (FimJogo() == false && jogadas == 9)
		{
		msg.text = "Sem vencedor! Fim de Jogo.";
		}
		
    }
	
}
