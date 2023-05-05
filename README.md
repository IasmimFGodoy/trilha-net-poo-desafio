# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
## Projeto finalizado:
<h3 align = "center"> Classe abstrata Smartphone: adicionadas as propriedades: Modelo, IMEI e Memória e depois adicionado ao construtor: </h3>

<div align="center">

![image](https://user-images.githubusercontent.com/106850969/236525856-dfd64826-4428-4d18-96db-e5b4a6a1b43d.png)

</div>

<h3 align = "center"> Classe Nokia: Adicionado herança da classe abstrata Smartphone, construtor e sobrescrito o método InstalarAplicativo(): </h3>

<div align="center">

![image](https://user-images.githubusercontent.com/106850969/236526168-1af41d9c-bde0-4687-abf6-63bbc8a08655.png)

</div>

<h3 align = "center"> Classe Iphone: Adicionado herança da classe abstrata Smartphone, construtor e sobrescrito o método InstalarAplicativo(): </h3>

<div align="center">

![image](https://user-images.githubusercontent.com/106850969/236526820-8bde83d4-333b-401d-9288-866c420e3b8c.png)

</div>

<h3 align = "center"> Program.cs: Abstraindo as classes filhas para o program.cs: </h3>

<div align="center">

![image](https://user-images.githubusercontent.com/106850969/236526982-07753cd9-fc52-434a-bfc2-657481ab1d09.png)

</div>
