
# 🦴 Projeto Working Rig — Personagem 3D Riggado com Animações

- **Jairo Augusto de Campos Alff**  

---

## 📝 Descrição do Projeto
Este projeto foi desenvolvido com o objetivo de riggar, animar e integrar um personagem 3D no Unity, aplicando técnicas básicas de animação digital para jogos.

O personagem utiliza um rig humanoide simples e contém três animações independentes, cada uma armazenada em um arquivo FBX separado:

🎵 Dancing Twerk — animação estilizada de dança

🪂 Jumping Down — animação de salto para baixo

🙏 Praying — animação de oração

Todas as animações foram importadas e configuradas no Unity usando um Animator Controller com transições controladas via script.

O objetivo deste exercício é demonstrar o fluxo completo:
importação do modelo → configuração do rig → importação das animações → animator → script para trocar states.
---

## 📂 Estrutura do Projeto
Principais scripts e suas funções:

| **Arquivo**              | **Descrição**                                                                                                         |
|--------------------------|-----------------------------------------------------------------------------------------------------------------------|
| `Dancing Twerk.fbx`      | Animação de dança ( Twerk ).                                                                                          |
| `Jumping Down.fbx`       | Animação de salto.                                                                                                    |
| `Praying.fbx`            | Animação de oração.                                                                                                   |
| `SansAnimator.controller`| Animator Controller com os três states configurados.                                                                  |
| `TrocarAnimacao.cs`      | Script responsável por trocar as animações via teclado.                                                               |
| `PeleOssuda.mat`         | Material aplicado ao personagem.                                                                                      |
| `TexturaSans.jpg`        | Textura do personagem.                                                                                                |

---

## ⚙️ Informações Técnicas
- Engine: Unity 2022.3.0f1
- Modelagem e Rig: Criados no Maya
- Animações: Importadas diretamente do Mixamo
- Formato: FBX com armature humanoide (Humanoid)
- Sistema de Animação: Unity Animator (Mecanim) com três states básicos

---

## 🔗 Link para a Build
Teste o rig do personagem aqui:  
[**Itch.io - Projeto Working Rig**](https://jairo-augusto.itch.io/projetos-animacao-computadorizada)

---

## 🎮 Como Funciona
Na cena, um personagem 3D é exibido com um Animator configurado para trocar entre três animações.

Controles

As animações podem ser trocadas através do teclado:

Tecla	Animação
1	Dancing Twerk
2	Jumping Down
3	Praying

O script TrocarAnimacao.cs envia triggers para o Animator, alternando entre os estados.

---

## 💭 Comentários Finais

Este projeto demonstra a base da animação 3D para jogos usando Unity, Maya e Mixamo.

A partir deste ponto, é possível expandir para:

Blend Trees (transições suaves entre corrida/caminhada)

Estados compostos (camadas superiores/ inferiores do corpo)

Prototipagem de combate ou expressões faciais

Importação de motion capture realista