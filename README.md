# DIO - Trilha .NET - Fundamentos 

## Desafio de Projeto: Estacionamento
### Contexto:
- Eu foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações,
como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.


### Solução
- Classe "Estacionamento" construida de acordo com o diagrama abaixo:

 ![image](https://github.com/user-attachments/assets/c867bbd9-1488-4381-ae6f-b9c70811884d)


A classe contém três variáveis, sendo:

- **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

- **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

- **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

- **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
Esse método também realiza a chamada de um terceiro método **ValidaPlaca**, que válida utilizando Regex, se o formato da placa está correto de acordo com os dois modelos existentes,
o qual um deles não é mais emitido. Os modelos são: "padrão Mercosul" (exemplo: **ABC1D23**) de 2019 e o modelo do ano de 1990 (exemplo: **ABCD-1234**). 

- **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento.
Após isso, realiza o seguinte cálculo: **precoInicial + (precoPorHora * horas)**, exibindo para o usuário.

- **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibi a mensagem "Não há veículos estacionados".
  
Por último, foi feito um menu interativo em **Program.cs** com as seguintes ações implementadas:

**Cadastrar veículo
Remover veículo
Listar veículos
Encerrar**


#### Pré-requisitos:
- Lógica de Programação e POO;
- Conhecimentos Básico(C#, .NET, Git, GitHub);

  
