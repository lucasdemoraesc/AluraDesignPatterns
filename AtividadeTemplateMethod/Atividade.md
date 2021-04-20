# Atividade: Template Method

Relatórios são muito parecidos: todos eles contém cabeçalho, corpo, e rodapé. Existem dois tipos de relatórios: simples e complexos.

As diferenças são sutis: relatórios simples possuem cabeçalhos e rodapés de uma linha, apenas com o nome do banco e telefone, respectivamente; relatórios complexos possuem cabeçalhos que informam o nome do banco, endereço, telefone, e rodapés que informam e-mail, e a data atual.

Além disso, dada uma lista de contas, um relatório simples apenas imprime titular e saldo da conta. O relatório complexo exibe titular, agência, número da conta, e saldo.

Use Template Method, e implemente o mecânismo de relatórios. Use dados falsos para os dados do banco.