# Desafio
1.	Qual a arquitetura utilizada para construção do serviço e por qual motivo utilizou desta arquitetura?
R - Procurei utilizar uma arquitetura/design patterns (DDD - Domain Driven Design) por ser um padrão que proporciona
    uma melhor divisão de responsabilidades entre os projetos/camadas de uma solução.
    De um modo de vista mais geral, a manutenção fica mais facil e proporciona o desenvolvimento em cima do Negocio, 
    independente que qual base de dados usar, ou qual vai ser a interface com o usuario, seja uma aplicação web (formularios, 
    webapi, wcf) ou uma aplicação desktop por exemplo um serviço.
    
2.	Qual tecnologia de sistema de banco de dados foi utilizada e por qual motivo utilizou desta tecnologia?
R - Utilizei SQL Server, por alguns motivos: 
  * Por se tratar de uma aplicação que tera, insert, update, delete e Consultas, um banco de dados não relacional pode 
    ter problemas na reescrita
  * A aplicação sugere pelo menos a criação de mais duas ou tres tabelas, isso no SQL Server e facil de ajustar e tras segurança 
    no relacionamento das tabelas. 
  * Por se tratar de um cliente critico (um hostital de grande porte e informações importantes) em minha opinião o SQL Server e mais robusto
    do que as opçoes de base de dados não relacionais. 
    
  * Por ultimo, mas não menos importante para o lado pessoal, meu conhecimento e focado em SQL Server, nessa tecnologia eu consigo resolver problemas de 
    forma mais agil. 
    
