Exercício: CRUD de Produtos
Contexto: você vai construir uma mini API REST para gerenciar um catálogo de produtos. Sem scaffolding, sem copiar de tutorial — só você e o que já sabe.

O domínio
Um Produto tem:

Id (inteiro, chave primária)
Nome (string, obrigatório, máx 100 chars)
Preco (decimal)
Estoque (inteiro)
CriadoEm (DateTime)


O que você vai construir
1. Estrutura do projeto

Cria um projeto ASP.NET Core Web API. Sem template com controllers já prontos — usa o minimal ou cria a estrutura na mão.
2. A entidade e o contexto

Define a classe Produto e um AppDbContext. Usa EF Core com banco SQLite (mais simples pra treino local — sem Oracle aqui). Configura a string de conexão no appsettings.json.
3. Migrations

Cria e aplica a migration inicial via CLI. O banco tem que existir de verdade no disco antes de você rodar qualquer endpoint.
4. Os endpoints
Método Rota  O que faz
GET    /produtos      Lista todos
GET    /produtos/{id} Busca um por ID
POST   /produtos      Cria novo
PUT    /produtos/{id} Atualiza existente
DELETE /produtos/{id} Remove

5. DTOs

Não exponha a entidade diretamente. Cria um ProdutoRequestDto (pra entrada) e um ProdutoResponseDto (pra saída). Mapeia manualmente — sem AutoMapper por agora.
6. Camadas

Separa em pelo menos duas camadas: Controller e Service. O controller não acessa o DbContext diretamente.

Restrições (parte do exercício)

Não use scaffolding (dotnet aspnet-codegenerator)
Não copie código de tutorial — se travar, tenta deduzir pela analogia com Express/Next.js e me pergunta
O POST deve retornar 201 Created com o objeto criado
O GET /{id} deve retornar 404 se não encontrar
O PUT deve retornar 404 se o ID não existir


Perguntas pra você pensar antes de começar a codar

No Express você faz app.get('/rota', handler) — qual é o equivalente declarativo em ASP.NET Core?
Como você vai injetar o AppDbContext no Service sem instanciar na mão?
O que um IActionResult tem em comum com o objeto que você retorna num handler do Next.js?


Começa pela estrutura e pelo DbContext — quando tiver isso funcionando, me mostra o que fez e seguimos pra próxima camada.