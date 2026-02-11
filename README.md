# 💰 Minha Conta API

Uma API RESTful para gerenciamento de lançamentos financeiros desenvolvida com .NET 8, Entity Framework Core e PostgreSQL.

## 🚀 Tecnologias

- **.NET 8** - Framework principal
- **ASP.NET Core Web API** - Framework para APIs REST
- **Entity Framework Core** - ORM para acesso a dados
- **PostgreSQL** - Banco de dados principal
- **SQLite In-Memory** - Banco de dados para testes
- **AutoMapper** - Mapeamento de objetos
- **Swagger/OpenAPI** - Documentação da API
- **Docker** - Containerização

## 📋 Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop) (opcional)
- [PostgreSQL](https://www.postgresql.org/download/) (para produção)

## 🛠️ Instalação e Execução

### Opção 1: Usando Docker (Recomendado)

```bash
# Build da imagem
docker build . -t minhaconta

# Executar o container
docker run --name minhaconta -p 8081:80 -d minhaconta
```

### Opção 2: Desenvolvimento Local

```bash
# Restaurar pacotes
dotnet restore

# Compilar a solução
dotnet build

# Executar a API
dotnet run --project ./src/MinhaContaApi.WebApi
```

## 🌐 Acesso

- **Swagger UI**: https://localhost:5001/swagger
- **API Base**: https://localhost:5001
- **Docker**: http://localhost:8081

## 📚 Endpoints

### Lancamentos

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| `GET` | `/lancamento` | Listar todos os lançamentos |
| `GET` | `/lancamento/{id}` | Buscar lançamento por ID |
| `POST` | `/lancamento` | Criar novo lançamento |
| `DELETE` | `/lancamento/{id}` | Excluir lançamento |

### Exemplo de Request

```json
POST /lancamento
{
  "descricao": "Compra de material de escritório",
  "data": "2024-01-15",
  "valor": 150.75
}
```

## 🏗️ Estrutura do Projeto

```
src/
├── MinhaContaApi.WebApi/          # API Web
├── MinhaContaApi.Services/        # Camada de Serviços
└── MinhaContaApi.Repositories/   # Camada de Repositórios
```

## 🔧 Configuração

A aplicação utiliza o padrão `Directory.Build.props` para gerenciamento centralizado de versões e pacotes.

## 📝 Referências

- **Repositório**: [GitHub](https://github.com/zclt/minha-conta-api)
- **Docker Hub**: [Link](https://hub.docker.com/r/zclt/minha-conta-api)
- **Artigo sobre Deploy**: [Automating .NET deployment with GitHub Actions and Docker](https://medium.com/@kova98/automating-net-deployment-with-github-actions-and-docker-d43109d34f88)
- **Docker Scout**: [Integrate Docker Scout with GitHub](https://docs.docker.com/scout/integrations/source-code-management/github/)

## 📄 Licença

Este projeto está sob licença MIT.