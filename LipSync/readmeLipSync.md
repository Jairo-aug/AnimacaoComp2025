# 🎵 Projeto: Estudo de LipSync

## 👥 Equipe
- **Brenda Lessa Almeida**  
- **Jairo Augusto de Campos Alff**  

---

## 📖 Descrição
Este projeto foi desenvolvido para o **Trabalho do Grau B – Animação Computadorizada (Unisinos)**.  
Ele demonstra como utilizar realizar sincronia de lábios no Blender.

Foi utilizado o addon **LipSync** do blender na versão 4.5 (Importante estar nessa versão e não na 5.0)

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
- **Engine:** Blender 4.5  
- **Linguagem:** Python  
- **Dependências:** Deve estar na versão citada.  

---

## 🎮 Funcionamento
1. Os assets de movimento estão na pasta LIPS, importante adicionar ela na aba **preferências** no blender e linkar a pasta no projeto.  
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