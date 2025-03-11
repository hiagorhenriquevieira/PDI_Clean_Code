<h1>Clean Code na Prática</h1>

<h2>Bem-vindo ao repositório Clean Code na Prática!</h2>

Este projeto foi criado com o objetivo de oferecer exemplos práticos para cada capítulo do livro Clean Code, de Robert C. Martin (Uncle Bob).

Aqui, você encontrará códigos ilustrando boas práticas, más práticas e suas refatorações, sempre com o objetivo de tornar o código mais limpo, legível e de fácil manutenção.

O repositório pode ser útil para:
- Desenvolvedores que querem aprender Clean Code na prática.
- Profissionais que desejam revisar conceitos e melhorar a qualidade do seu código.
- Equipes que buscam adotar padrões mais limpos em seus projetos.

Cada diretório representa um capítulo do livro e contém exemplos comentados para facilitar o aprendizado.

<h2>Resumo do Capítulo 1 – Limpeza de Código (Clean Code)</h2>

- O primeiro capítulo do livro Clean Code destaca a importância de escrever código limpo e sustentável. Uncle Bob enfatiza que um código bem escrito não é apenas para ser entendido pelo computador, mas principalmente por outros desenvolvedores.

🛠️ Principais conceitos do capítulo:
- Código limpo é legível e elegante → Deve ser fácil de entender, sem necessidade de explicações extras.
- Bons nomes são essenciais → Variáveis, funções e classes devem ter nomes descritivos e significativos.
- Menos é mais → Um código limpo tende a ser mais enxuto e direto ao ponto.
- Facilidade de manutenção → Um código bem escrito reduz o esforço para corrigir bugs e adicionar novas funcionalidades.
- Código sujo custa caro → A falta de organização e clareza aumenta o tempo de desenvolvimento e manutenção.
  
📌 Exemplo prático no repositório:
- No diretório CodigoLimpo, dentro da pasta Original, você encontrará exemplos do código desorganizado. Já no diretório CodigoLimpo, dentro da pasta AplicacoesCleanCode, estão os mesmos exemplos, porém aplicando boas práticas, como nomeação adequada de variáveis e melhor organização do código, seguindo os princípios do Clean Code.

<h2>Resumo do Capítulo 2 – Nomes Significativos</h2>

- No segundo capítulo de Clean Code, Uncle Bob enfatiza a importância de escolher nomes descritivos e significativos para variáveis, funções, classes e demais elementos do código. Nomes bem escolhidos tornam o código autoexplicativo e facilitam sua manutenção.

🛠️ Principais conceitos do capítulo:
- Evite abreviações e nomes genéricos → Use nomes que expressem claramente o propósito da variável ou função.
  
❌ int d; (o que significa "d"?)

✅ int diasDesdeUltimaCompra; (muito mais claro!)

- Seja específico → Nomes vagos podem gerar confusão. Prefira termos que transmitam exatamente a intenção do código.
  
❌ getData()

✅ getDataNascimentoCliente()

- Evite informações desnecessárias → Não repita palavras sem necessidade.
  
❌ ClienteInfo (se já está em um contexto de cliente, "Info" é redundante).

✅ Cliente.

- Use convenções do idioma → Se a equipe trabalha em português, evite misturar inglês e português nos nomes.

- Nomes de métodos devem indicar ações → Métodos devem ter nomes que expressem suas ações claramente.

✅ calcularDesconto() ao invés de desconto()

📌 Exemplo prático no repositório:
- No diretório NomesSignificativos, dentro da pasta Original, você encontrará exemplos do código desorganizado. Já no diretório NomesSignificativos, dentro da pasta AplicacoesCleanCode, estão os mesmos exemplos, porém aplicando boas práticas, como nomeação adequada de variáveis e melhor organização do código, seguindo os princípios do Clean Code.
