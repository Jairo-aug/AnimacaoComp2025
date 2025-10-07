# 🎵 Projeto: Animação com Espectro Sonoro

## 👥 Equipe
- **Brenda Lessa Almeida**  
- **Jairo Augusto de Campos Alff**  

---

## 📖 Descrição
Este projeto foi desenvolvido para o **Trabalho do Grau A – Animação Computadorizada (Unisinos)**.  
Ele demonstra como utilizar o **espectro sonoro de uma música** para gerar animações em Unity.

A implementação segue a **Opção A – Movimentação de Objetos**, onde os cubos da cena reagem ao som em tempo real, mudando de **escala, cor e iluminação** conforme as frequências da música.
Na cena, múltiplos cubos reagem aos diferentes níveis de frequência da música, mudando sua **escala, cor e intensidade de luz** de acordo com o espectro sonoro captado.

---

## 📂 Estrutura do Projeto
Principais scripts e suas funções:

| **Arquivo**             | **Descrição**                                                                                     |
|--------------------------|--------------------------------------------------------------------------------------------------|
| `AudioSpectrum.cs`       | Captura o espectro sonoro da música usando `AudioSource.GetSpectrumData()`.                      |
| `SpectrumObject.cs`      | Faz o mapeamento do espectro para a animação visual de cada cubo (escala, cor e luz).            |
                                        |
---

## ⚙️ Informações Técnicas
- **Engine:** Unity 2022.3.0f1  
- **Linguagem:** C#  
- **Dependências:** Nenhuma (apenas APIs nativas da Unity)  
- **Plataformas-alvo:** Windows e WebGL 

---

## ✅ Checklist de Requisitos
- [x] Leitura do espectro sonoro via `AudioSource.GetSpectrumData()`.  
- [x] Mapeamento de frequências em parâmetros visuais.  
- [x] Ambiente 3D experimental com múltiplos objetos reativos.  
- [x] Efeitos visuais variados (escala, cor, iluminação).  
- [x] Música livre de direitos autorais ou build privada.  

---

## 🔗 Link para a Build
Acesse a versão WebGL:  
[**Itch.io - Animação com Espectro Sonoro**](https://jairo-augusto.itch.io/projeto-espectro-sonoro)

---

## 🎮 Funcionamento
1. A música é reproduzida pelo `AudioSource` do **GameManager**.  
2. O script `AudioSpectrum` extrai o espectro sonoro (64 amostras) a cada frame.  
3. Cada cubo lê um índice do espectro (`spectrumIndex`) e converte a intensidade em movimento e cor.  
4. A luz de cada cubo muda de intensidade e tonalidade conforme o som.  

**Mapeamento utilizado:**
| Faixa | Frequência aproximada | Parâmetro Visual |
|--------|-----------------------|------------------|
| 0–8 | Graves | Escala (pulsação vertical dos cubos) |
| 9–40 | Médias | Cor (transição da cor base para branco) |
| 41–63 | Agudas | Luz (intensidade e brilho variável) |

O valor de cada faixa é suavizado e normalizado para evitar oscilações bruscas, resultando em uma animação fluida e sincronizada com a música.

---

## 💡 Explicação do Mapeamento
O `AudioSource.GetSpectrumData()` divide o áudio em **64 bins** uniformemente distribuídos entre 0 Hz e a **frequência de Nyquist (22050 Hz)**.  
Cada bin representa uma faixa de frequência e retorna sua amplitude (energia). Esses valores são lidos e mapeados diretamente para as propriedades dos objetos:

- **Escala:** proporcional à amplitude dos graves → cubos “pulam” com a batida.  
- **Cor:** baseada na média das frequências médias → altera a saturação e brilho.  
- **Luz:** ligada às frequências agudas → cintilação e flashes sutis.  

Para melhorar a estabilidade visual, os valores passam por **suavização exponencial**:
```csharp
smoothed = smoothed * 0.85f + current * 0.15f;

---

## 💭 Comentários Finais
> Este projeto demonstra de forma prática como utilizar o **espectro sonoro de uma música** para gerar animações reativas em Unity.  
> A proposta mostra como os dados de frequência podem ser transformados em parâmetros visuais dinâmicos — como escala, cor e iluminação — criando uma experiência audiovisual envolvente.  
> O sistema pode ser expandido com:
> - Efeitos de partículas sincronizados ao ritmo da música.  
> - Pós-processamento dinâmico (bloom, cores, distorções).  
> - Interação do jogador com o som (por exemplo, objetos que reagem a microfone ou entrada externa).  
> - Animações de câmera e luz ambiente controladas por faixas de frequência. 