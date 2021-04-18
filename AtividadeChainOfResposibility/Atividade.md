# Atividade: Chain of Responsibility

Um servidor de aplicação bancária que se comunica com outros, deve responder de várias formas diferentes, de acordo com a solicitação da aplicação cliente.

Se a aplicação solicitar uma `Conta`, cujos atributos são separados por ponto-e-vírgula, por exemplo, o servidor deverá responder nesse formato; se a aplicação solicitar XML, o servidor deverá responder XML; se ela pedir separado por % (por cento), a aplicação deverá devolver dessa forma.

Implemente um `Chain of Responsibility` onde, dada uma requisição e uma conta bancária, ela passeia por toda a corrente até encontrar a classe que deve processar a requisição de acordo com o `formato` solicitado, e imprime na tela a conta bancária no formato correto.

Imagine que a classe `Requisição` possui uma propriedade chamada `Formato`, que responde **"XML"**, **"CSV"**, ou **"PORCENTO"**, indicando qual tratamento adequado. Uma `Conta` possui apenas saldo e nome do titular.