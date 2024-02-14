# 🔉Screen Sound
`finalizado`

## ✏️ Descrição do projeto
Esse projeto foi desenvolvido durante as aulas do curso "C#: Criando sua primeira aplicação", da plataforma _Alura_.

## 🔨 Funcionalidades
`Registrar uma banda`: ao selecionar essa opção, o usuário deverá informar o nome da banda que deseja registrar, após isso, o programa verificará, por meio da função **ContainsKey**, se a banda informada já está registrada como chave no dicionário de bandas - criado no início do código, tendo o nome da banda como chave e as avaliações como valores -, em caso positivo, o usuário é apenas informado que a banda já existe, porém, em caso negativo, a banda informada será registrada no dicionário, por meio da função **Add**;

  ![image](https://github.com/Maria-Faria/ScreenSound/assets/114308727/d9d7f14b-3209-406a-aa9e-920e62d84b0b)

`Exibir todas as bandas registradas`: a opção 2 do menu levará o usuário a uma tela que contém o nome de todas bandas registradas no dicionário, com a exibição realizada por meio do laço de repetição _foreach_;
  
  ![image](https://github.com/Maria-Faria/ScreenSound/assets/114308727/5361a641-9052-4ed2-bcd1-13fee30a0802)

`Avaliar uma banda`: para avaliar uma banda, o usuário deve selecionar a opção 3 do menu que, por meio da função **AvaliarUmaBanda**, pede que o usuário informe o nome da banda que deseja avaliar, assim, o programa verifica se a banda informada existe no dicionário e, em caso positivo, o usuário é questionado quanto à nota que ele irá atribuir à banda, que deverá ser um valor entre 0 e 100 - caso o usuário não siga esse requisito e informe um valor menor que 0 ou maior que 10, a nota não será registrada -, desse modo, o valor digitado será armazenado no dicionário, de acordo com a chave (nome da banda) informada anteriormente; 

  ![image](https://github.com/Maria-Faria/ScreenSound/assets/114308727/8b8b187a-d68c-43dc-a5ec-5d4813c1d68a)

`Calcular a média de avaliações de uma banda`: caso selecione a opção 4, o usuário deverá informar o nome da banda da qual ele deseja consultar a média de avaliações, assim, após verificar se a banda existe no dicionário, o programa exibe a média de avaliações da mesma, por meio da função **Average**.

  ![image](https://github.com/Maria-Faria/ScreenSound/assets/114308727/8f6572e0-e475-4adb-8865-371473e531c7)

## 📋 Aprendizados
- Criação e manipulação de dicionários em C#
- Utilização de estruturas de decisão e de repetição em C#

## 💻 Demonstração prática
https://github.com/Maria-Faria/ScreenSound/assets/114308727/2ed6bd98-e99b-435d-8a37-5e6d63662a46


